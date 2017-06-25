namespace StarCraft.GameObject
{
    using System;

    using StarCraft.Interfaces;

    public class UserInterfacecs : IUserInterfacecs
    {
        public event EventHandler OnActionPressed;

        public void ProcessInput()
        {
            if (Console.KeyAvailable)
            {
                var keyInfo = Console.ReadKey();
                if (keyInfo.Key.Equals(ConsoleKey.Enter))
                {
                    if (this.OnActionPressed != null)
                    {
                        this.OnActionPressed(this, new EventArgs());
                    }
                }
            }
        }

        public void VisualaseInformation(string info)
        {
            Console.WriteLine(info);
        }
    }
}
