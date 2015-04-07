namespace StarCraft.Interfaces
{
    using System.Collections.Generic;
    using GameObject;

    public interface IPlayer
    {
        string Name { get; }
        RaceType RaceType { get; }
        int EmptySlots { get; }
        int FullSlots { get; }
        int Mineral { get; }
        int Gas { get; set; }
        Position Position { get; }

        ICollection<IGameObject> GameObjects { get; }

        void GetMineral(int mineral);
        void GetGas(int slot);
        void RemoveMineral(int mineral);
        void RemoveGas(int gas);
        void AddEmptySlots(int slot);
        void RemoveEmptySlots(int slot);
        void AddFullSlotsSlots(int slot);
        void RemoveFullSlotsSlots(int slot);
        void AddGameObject(IGameObject gameObject);
        void RemoveDestroyGameObject();
    }
}
