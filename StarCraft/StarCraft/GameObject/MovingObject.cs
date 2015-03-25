namespace StarCraft.GameObject
{
    using StarCraft.Interfaces;

    public abstract class MovingObject : GameObject, IMovable
    {
     /*   public MovingObject(Position position, string owner)
            : base(position, owner)
        {

        }*/
        public void GoTo(Position newPosition)
        {
            this.Position = newPosition;
            throw new System.NotImplementedException();
        }
    }
}
