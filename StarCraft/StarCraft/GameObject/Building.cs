namespace StarCraft.GameObject
{
   public abstract class Building : GameObject
    {
       public Building(Position position, string owner, int health)
           : base(position, owner, health)
       {
       }
    }
}
