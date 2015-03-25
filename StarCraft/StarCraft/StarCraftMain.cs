namespace StarCraft
{
    using System;

    using StarCraft.Engine;
    using StarCraft.GameObject;

    public class StarCraftMain
    {
        public static void Main()
        {
            var keyboard = new KayboardInterface();
            StarCraftEngine engine = new StarCraftEngine(new Player("a"), new Player("as"), keyboard);

            // Event. listen for enter kay press
            keyboard.OnActionPressed += (sender, eventInfo) =>
            {
                Console.Write("Enter command: ");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                     engine.ParceCommand(input);
                }
               
                Console.Clear();
            };

            // Start engine
            engine.Run();
        }
    }
}
