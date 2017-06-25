namespace StarCraft.GameObject
{
    using StarCraft.Interfaces;

    public abstract class Building : GameObject
    {
        public Building(Position position, string name, int mineralCost, int gasCost, int health, RaceType race)
            : base(position, name, mineralCost, gasCost, 0, health, race)
       {
       }

    }
}
