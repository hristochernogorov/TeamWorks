namespace StarCraft.GameObject
{
    using StarCraft.Interfaces;

    public abstract class Unit : MovingObject
    {
       public Unit(Position position, string owner, int health)
           : base(position, owner, health)
       {
       }
    }
}
