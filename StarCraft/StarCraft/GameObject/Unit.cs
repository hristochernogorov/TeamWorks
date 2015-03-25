namespace StarCraft.GameObject
{
   public abstract class Unit : MovingObject
    {
       public Unit(Position position, string owner, int health)
           : base(position, owner, health)
       {

       }
    }
}
