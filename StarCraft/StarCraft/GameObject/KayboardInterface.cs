namespace StarCraft.GameObject
{
    using StarCraft.Interfaces;

    using System;

    public class KayboardInterface : IUserInterfacecs
    {

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

        public event EventHandler OnActionPressed;
    }
}
