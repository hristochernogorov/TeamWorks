namespace StarCraft.Engine
{
    public class CommandsConstant
    {
        public const string PlayerOne = "player1";
        public const string PlayerTwo = "player2";
        public const string Create = "create";
        public const string Attack = "attack";
        public const string GoTo = "goto";
        public const string Collect = "collect";

        public const string Minerals = "minerals";
        public const string Gas = "gas";

        public const string Building = "building";
        public const string Fighter = "fighter";
        public const string Worker = "worker";
        public const string WorkerWithNoName = "InitialWorker";

        public const string NoMinerals = "You've not enough minerals.";
        public const string NoGas = "You require more Vespene Gas.";
        public const string InvalidCommand = "Invalid command";

        public const string IsDeadkMessage = "{0} {1} is destroy!";
        public const string GoToPositionkMessage = "{0} is on position {1}!";
        public const string AttackMessage = "{0} make {1} damege to {2}!";

        // CreateCommandSyntax = "player create <unit type> <unit name> <unit name> ";
        //player1 create worker probe gosho
        //player2 create fighter guardian mitko
        //player1 gosho atтack mitko

        //  CreateCommandSyntax = "player <unit name> attack <unit name> ";
        // player1 pesho attack gosho

        // CreateCommandSyntax = "player <unit name> goto position(0 0) ";
        //player1 pesho goto (1 1)
    }
}
