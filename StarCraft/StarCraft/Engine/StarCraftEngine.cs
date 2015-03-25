namespace StarCraft.Engine
{
    using System;
    using System.Linq;
    using System.Threading;

    using StarCraft.GameObject;
    using StarCraft.Interfaces;

    public class StarCraftEngine
    {
        private const int MineralPerCycle = 8;
        private const int GasPerCycle = 8;

        private IPlayer playerOne;
        private IPlayer playerTwo;
        private IUserInterfacecs userInterface;

        public StarCraftEngine(IPlayer playerOne, IPlayer playerTwo, IUserInterfacecs userInterface)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            this.userInterface = userInterface;
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
            switch (command[0])
            {
                case CommandsConstant.PlayerOne:
                    this.ProceedCommand(command, this.playerOne);
                    break;
                case CommandsConstant.PlayerTwo:
                    this.ProceedCommand(command, this.playerTwo);
                    break;
                default:
                    break;
            }
        }

        // TODO command
        private void ProceedCommand(string[] command, IPlayer player)
        {
            switch (command[1])
            {
                case CommandsConstant.Create:
                    this.ProceedCreateCommand(command, player);
                    break;
                case CommandsConstant.Attack:
                    this.ProceedCreateCommand(command, player);
                    break;
                default:
                    break;
            }
        }

        // TODO implement create command
        private void ProceedCreateCommand(string[] command, IPlayer player)
        {
            throw new NotImplementedException();
        }
    }
}