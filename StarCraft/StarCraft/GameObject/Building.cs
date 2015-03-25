namespace StarCraft.GameObject
{
   public abstract class Building : GameObject
    {
       public Building(Position position, string owner, int health, int mineralCost, int gasCost, int sloat)
           : base(position, owner, health, mineralCost, gasCost, sloat)
       {
       }
    }
}
