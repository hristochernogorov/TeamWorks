namespace StarCraft.Interfaces
{
    using StarCraft.GameObject;

    public interface IGameObject
    {
        int Health { get; }
        int MineralCost { get; }
        int GasCost { get; }
        int Sloat { get; }
        string Owner { get; }
        Position Position { get; }

        bool IsAlive();
        void DamageTaken(int damage);

    }
}
