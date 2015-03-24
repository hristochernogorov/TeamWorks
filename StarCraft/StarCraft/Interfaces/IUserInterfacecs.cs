namespace StarCraft.Interfaces
{
    using System;

    public interface IUserInterfacecs
    {
        event EventHandler OnActionPressed;

        void ProcessInput();
    }
}
