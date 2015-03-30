namespace StarCraft.GameObject
{
    using StarCraft.Interfaces;

    public abstract class Building : GameObject, IRace
    {
       public Building(Position position, string owner, int mineralCost, int gasCost, int sloat)
           : base(position, owner, mineralCost, gasCost, sloat)
       {
       }

       public abstract RaceType Race { get; }
    }
}
