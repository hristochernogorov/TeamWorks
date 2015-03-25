namespace StarCraft.GameObject
{
    using StarCraft.Interfaces;

    public abstract class Unit : MovingObject
    {
        public Unit(Position position, string owner, int health, int mineralCost, int gasCost, int sloat)
           : base(position, owner, health, mineralCost, gasCost, sloat)
       {
       }
    }
}
