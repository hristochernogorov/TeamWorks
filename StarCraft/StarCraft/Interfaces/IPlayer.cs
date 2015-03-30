namespace StarCraft.Interfaces
{
    using System.Collections.Generic;

    public interface IPlayer
    {
        string Name { get; }
        int EmptySlots { get; }
        int FullSlots { get; }
        int Mineral { get; }
        int Gas { get; set; }

        ICollection<IGameObject> GameObjects { get; }
        ICollection<IFighter> Fighter { get; }
        ICollection<IGatherer> Gatherer { get; }

        void GetMineral(int mineral);
        void GetGas(int slot);
        void RemoveMineral(int mineral);
        void RemoveGas(int gas);
        void AddEmptySlots(int slot);
        void RemoveEmptySlots(int slot);
        void AddFullSlotsSlots(int slot);
        void RemoveFullSlotsSlots(int slot);
    }
}
