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
        public const string WorkerWithNoName = "NoNamer";

        public const string NoMinerals = "You've not enough minerals.";
        public const string NoGas = "You require more Vespene Gas.";
        public const string InvalidCommand = "Invalid command";

        // CreateCommandSyntax = "player create <unit type> <unit name> <unit name> ";
        //player1 create worker probe gosho

        //  CreateCommandSyntax = "player <unit name> atack <unit name> ";
        // player1 pesho attack gosho

        // CreateCommandSyntax = "player <unit name> goto position(0 0) ";
        //player1 pesho goto (1 1)
    }
}
