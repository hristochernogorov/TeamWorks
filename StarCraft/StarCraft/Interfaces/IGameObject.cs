namespace StarCraft.Interfaces
{
    using StarCraft.GameObject;

    public interface IGameObject
    {
        int Health { get; set; }
        int MineralCost { get; }
        int GasCost { get; }
        int Sloat { get; }
        RaceType Race { get; }
        string Name { get; }
        Position Position { get; }
        bool IsAlive();
        void DamageTaken(int damage);
    }
}
