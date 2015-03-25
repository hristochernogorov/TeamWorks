namespace StarCraft.GameObject
{
    using StarCraft.Interfaces;

    public abstract class MovingObject : GameObject, IMovable
    {
        public MovingObject(Position position, string owner, int health)
            : base(position, owner, health)
        {
        }

        public void GoTo(Position newPosition)
        {
            this.Position = newPosition;
        }
    }
}
