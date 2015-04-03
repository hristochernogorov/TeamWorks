namespace StarCraft.Engine
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading;

    using StarCraft.GameObject;
    using StarCraft.Interfaces;

    public class StarCraftEngine
    {
        private const int MineralPerCycle = 8;
        private const int GasPerCycle = 8;
        private const int InitWorkercount = 4;

        private IPlayer playerOne;
        private IPlayer playerTwo;
        private IUserInterfacecs userInterface;
        private UnitFactory factory = new UnitFactory();

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
                Thread.Sleep(200);

                this.userInterface.ProcessInput();
                this.Update(this.playerOne, this.playerTwo);
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
                    worker = factory.CreateProbe(player.Position,CommandsConstant.WorkerWithNoName);
                    worker.Work(ResourceType.Minerals);
                    player.AddGatherer(worker);
                    break;
                case RaceType.Terran:
                    worker = factory.CreateScv(player.Position, CommandsConstant.WorkerWithNoName);
                    worker.Work(ResourceType.Minerals);
                    player.AddGatherer(worker);
                    break;
                case RaceType.Zerg:
                    worker = factory.CreateDrone(player.Position,CommandsConstant.WorkerWithNoName);
                    worker.Work(ResourceType.Minerals);
                    player.AddGatherer(worker);
                    break;
            }
        }

        private void Update(IPlayer player, IPlayer opositePlayer)
        {
            foreach (var unit in player.Gatherer)
            {
                if (unit.CollectResources(ResourceType.Minerals))
                {
                    this.playerOne.GetMineral(MineralPerCycle);
                }

                if (unit.CollectResources(ResourceType.Gas))
                {
                    this.playerOne.GetGas(GasPerCycle);
                }
            }

            foreach (var fighter in player.Fighter)
            {
                var opsitePlayerUnitOnSamePossition = opositePlayer.GameObjects.Where(x => fighter.Position == x.Position);
                fighter.FindObjectToAttack(opsitePlayerUnitOnSamePossition);
            }
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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

            }
        }

        private void ProceedCollectCommand(string[] command, IPlayer player)
        {
            var worker = player.Gatherer.FirstOrDefault(f => f.Name == command[2]);
            ResourceType resource;
            if (command[3] == ResourceType.Minerals.ToString())
            {
                resource = ResourceType.Minerals;
            }
            else
            {
                resource = ResourceType.Gas;
            }
            worker.Work(resource);

        }

        private void ProceedGoToCommand(string[] command, IPlayer player)
        {
            var unit = player.GameObjects.FirstOrDefault(u => (u is IMovable) && u.Name == command[2]);
            if (unit != null)
            {
                (unit as IMovable).GoTo(Position.Parse(command[3]));
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
                result = (Gatherer)method.Invoke(factory, new object[] { player.Position, command[4] });
            }
            catch (Exception)
            {

                throw new Exception(CommandsConstant.InvalidCommand);
            }

            if (result != null && player.RaceType == result.Race)
            {
                if (player.Gas < result.GasCost)
                {
                    throw new ArgumentException(CommandsConstant.NoGas);
                }
                if (player.Mineral < result.MineralCost)
                {
                    throw new Exception(CommandsConstant.NoMinerals);
                }
                player.GetGas(result.GasCost);
                player.GetMineral(result.MineralCost);
                player.AddGameObject(result);
            }


            switch (command[2])
            {
                case CommandsConstant.Fighter:
                    {
                        player.AddFighter((result as IFighter));
                    }
                    break;
                case CommandsConstant.Worker:
                    {
                        var worker = result as IGatherer;
                        worker.CollectResources(ResourceType.Minerals);
                        player.AddGatherer((worker));

                    }
                    break;
            }
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
            var unit = player.Fighter.FirstOrDefault(f => f.Name == command[2]);
            var unitToAttack = opositePlayer.Fighter.FirstOrDefault(f => f.Name == command[3]);
            if (unit == null && unitToAttack == null)
            {
                throw new Exception(CommandsConstant.InvalidCommand);
            }
            unit.ResponseToAttackCommand(unitToAttack);
        }
    }
}