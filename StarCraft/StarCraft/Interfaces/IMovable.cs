namespace StarCraft.Interfaces
{
    using StarCraft.GameObject;

    public interface IMovable : IGameObject
    {
        UnitType UnitType { get; }

        void GoTo(Position newPosition);
    }
}
