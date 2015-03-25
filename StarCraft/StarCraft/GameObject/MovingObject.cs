namespace StarCraft.GameObject
{
    using StarCraft.Interfaces;

    public abstract class MovingObject : GameObject, IMovable
    {
        public MovingObject(Position position, string owner, int health, int mineralCost, int gasCost, int sloat)
            : base(position, owner, health, mineralCost, gasCost, sloat)
        {
        }

        public void GoTo(Position newPosition)
        {
            this.Position = newPosition;
        }
    }
}
