namespace StarCraft.Engine
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading;
    using CustomExceptions;
    using StarCraft.GameObject;
    using StarCraft.Interfaces;
    using StarCraft.Extensions;

    public class StarCraftEngine
    {
        private const int MineralPerCycle = 8;
        private const int GasPerCycle = 8;
        private const int InitWorkercount = 4;
        private const int ThreadSleep = 500;

        private IPlayer playerOne;
        private IPlayer playerTwo;
        private IUserInterfacecs userInterface;
        private IUnitFactory factory = new UnitFactory();
        private StringBuilder output = new StringBuilder();

        public StarCraftEngine(IPlayer playerOne, IPlayer playerTwo, IUserInterfacecs userInterface)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            this.userInterface = userInterface;
        }

        public void InitialiseGame()
        {
            for (int currentWorker = 0; currentWorker < InitWorkercount; currentWorker++)
            {
                this.AddWorker(playerOne);
                this.AddWorker(playerTwo);
            }
        }

        // Live cycle
        public void Run()
        {
            while (true)
            {
                Thread.Sleep(ThreadSleep);

                this.userInterface.ProcessInput();
                this.LogGameInfo();
                this.Update(this.playerOne, this.playerTwo);
                this.LogGameInfo();
                this.Update(this.playerTwo, this.playerOne);
            }
        }

        public void ParceCommand(string input)
        {
            var command = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            this.ProceedPlayerCommand(command);
        }

        private void AddWorker(IPlayer player)
        {
            IGatherer worker;
            switch (player.RaceType)
            {
                case RaceType.Protoss:
                    worker = factory.CreateProbe(player.Position, CommandsConstant.WorkerWithNoName);
                    worker.Work(ResourceType.Minerals);
                    player.AddGameObject(worker);
                    break;
                case RaceType.Terran:
                    worker = factory.CreateScv(player.Position, CommandsConstant.WorkerWithNoName);
                    worker.Work(ResourceType.Minerals);
                    player.AddGameObject(worker);
                    break;
                case RaceType.Zerg:
                    worker = factory.CreateDrone(player.Position, CommandsConstant.WorkerWithNoName);
                    worker.Work(ResourceType.Minerals);
                    player.AddGameObject(worker);
                    break;
            }
        }

        private void Update(IPlayer player, IPlayer opositePlayer)
        {


            foreach (var unit in player.GameObjects)
            {
                if (unit is IGatherer)
                {
                    var worker = unit as IGatherer;

                    if (worker.CollectResources(ResourceType.Minerals))
                    {
                        player.GetMineral(MineralPerCycle);
                    }

                    if (worker.CollectResources(ResourceType.Gas))
                    {
                        player.GetGas(GasPerCycle);
                    }
                }
                if (unit is IFighter)
                {
                    var fighter = unit as IFighter;

                    var opsitePlayerUnitOnSamePossition = opositePlayer.GameObjects.Where(x => fighter.Position == x.Position);
                    var victim = fighter.FindObjectToAttack(opsitePlayerUnitOnSamePossition);
                    if (victim != null)
                    {
                        fighter.Attack(victim);
                        this.output.AppendLine(string.Format(CommandsConstant.AttackMessage, fighter.Name, fighter.AttackDmg, victim.Name));
                    }
                }
            }
            foreach (var gameObject in opositePlayer.GameObjects)
            {
                if (!gameObject.IsAlive())
                {
                    this.output.AppendLine(string.Format(CommandsConstant.IsDeadkMessage, gameObject.GetType().Name, gameObject.Name));
                }
            }
            opositePlayer.RemoveDestroyGameObject();
        }


        private void ProceedPlayerCommand(string[] command)
        {
            try
            {
                switch (command[0])
                {
                    case CommandsConstant.PlayerOne:
                        this.ProceedCommand(command, this.playerOne, this.playerTwo);
                        break;
                    case CommandsConstant.PlayerTwo:
                        this.ProceedCommand(command, this.playerTwo, this.playerOne);
                        break;
                }
            }
            catch (InvalidCommandException e)
            {
                this.output.Append(e.Message);
            }
            catch (Exception e)
            {
                this.output.Append(e.Message);
            }
        }

        private void ProceedCommand(string[] command, IPlayer player, IPlayer opositePlayer)
        {
            switch (command[1])
            {
                case CommandsConstant.Create:
                    this.ProceedCreateCommand(command, player);
                    break;
                case CommandsConstant.Attack:
                    this.ProceedAttackCommand(command, player, opositePlayer);
                    break;
                case CommandsConstant.GoTo:
                    this.ProceedGoToCommand(command, player);
                    break;
                case CommandsConstant.Collect:
                    this.ProceedCollectCommand(command, player);
                    break;
                case CommandsConstant.PrintInfo:
                    this.ProceedPrintInfo(player);
                    break;
                default:
                    throw new InvalidCommandException(CommandsConstant.InvalidCommand);

            }
        }

        private void ProceedCollectCommand(string[] command, IPlayer player)
        {
            var worker = player.GameObjects.FirstOrDefault(f => (f is IGatherer) && f.Name == command[2]);
            ResourceType resource;
            if (command[3] == ResourceType.Minerals.ToString())
            {
                resource = ResourceType.Minerals;
            }
            else
            {
                resource = ResourceType.Gas;
            }

            (worker as IGatherer).Work(resource);

        }

        private void ProceedGoToCommand(string[] command, IPlayer player)
        {
            var unit = player.GameObjects.FirstOrDefault(u => (u is IMovable) && u.Name == command[2]);
            if (unit != null)
            {
                var position = Position.Parse(command[3]);
                var movable = (unit as IMovable);
                movable.GoTo(position);

                this.output.AppendLine(string.Format(CommandsConstant.GoToPositionkMessage, movable.Name, position));
            }
        }

        private void ProceedCreateCommand(string[] command, IPlayer player)
        {
            IGameObject result;

            try
            {
                string methodName = GetMethodName(command);
                Type type = typeof(UnitFactory);
                MethodInfo method = type.GetMethod(methodName);
                result = (IGameObject)method.Invoke(factory, new object[] { player.Position, command[4] });
            }
            catch (Exception)
            {

                throw new InvalidCommandException(CommandsConstant.InvalidCommand);
            }

            if (result != null && player.RaceType == result.Race)
            {
                if (player.Gas < result.GasCost)
                {
                    throw new InvalidCommandException(CommandsConstant.NoGas);
                }
                if (player.Mineral < result.MineralCost)
                {
                    throw new InvalidCommandException(CommandsConstant.NoMinerals);
                }

                player.GetGas(result.GasCost);
                player.GetMineral(result.MineralCost);
                player.AddGameObject(result);

                if (result is IGatherer)
                {
                    var worker = result as IGatherer;
                    worker.CollectResources(ResourceType.Minerals);
                }
            }
        }

        private void ProceedPrintInfo(IPlayer player)
        {
            this.output.Append(player.PrintInfo());
        }

        private string GetMethodName(string[] command)
        {
            StringBuilder result = new StringBuilder();
            result.Append(command[1].First().ToString().ToUpper() + command[1].Substring(1).ToLower());
            result.Append(command[3].First().ToString().ToUpper() + command[3].Substring(1).ToLower());

            return result.ToString();
        }

        private void ProceedAttackCommand(string[] command, IPlayer player, IPlayer opositePlayer)
        {
            var unit = player.GameObjects.FirstOrDefault(f => f is IFighter && f.Name == command[2]);
            var unitToAttack = opositePlayer.GameObjects.FirstOrDefault(f => f.Name == command[3]);
            if (unit == null || unitToAttack == null)
            {
                throw new InvalidCommandException(CommandsConstant.InvalidCommand);
            }
            var fighter = unit as IFighter;
            fighter.ResponseToAttackCommand(unitToAttack);
            this.output.AppendLine(string.Format(CommandsConstant.AttackMessage, fighter.Name, fighter.AttackDmg, unitToAttack.Name));
        }

        private void LogGameInfo()
        {
            if (!this.output.IsEmpty())
            {
                userInterface.VisualaseInformation(this.output.ToString().TrimEnd());
                this.output.Clear();
            }
        }
    }
}