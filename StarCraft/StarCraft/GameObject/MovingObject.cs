namespace StarCraft.GameObject
{
    using StarCraft.Interfaces;

    public abstract class MovingObject : GameObject, IMovable
    {

        public void GoTo(Position newPosition)
        {
            throw new System.NotImplementedException();
        }
    }
}
