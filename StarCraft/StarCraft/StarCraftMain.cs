namespace StarCraft
{
    using System;
    using System.Collections.Generic;
    using StarCraft.Engine;
    using StarCraft.GameObject;

    public class StarCraftMain
    {
        public static void Main()
        {
            var printStartMenu = new StartMenu();
            
            var keyboard = new UserInterfacecs();

            StarCraftEngine engine = new StarCraftEngine(new Player("a", RaceType.Protoss, Position.Parse("1,1")),
                                                         new Player("b", RaceType.Zerg, Position.Parse("2,2")),
                                                          keyboard);

            // Event. listen for enter kay press
            keyboard.OnActionPressed += (sender, eventInfo) =>
            {
                Console.Write("Enter command: ");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    engine.ParceCommand(input);
                }

                // Console.Clear();
            };

            engine.InitialiseGame();
            // Start engine
            engine.Run();
        }
    }
}
