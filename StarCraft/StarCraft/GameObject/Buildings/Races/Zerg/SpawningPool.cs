namespace StarCraft.GameObject.Buildings.Races.Zerg
{
    using StarCraft.Interfaces;

    public class SpawningPool : Building, IRace
    {
        public SpawningPool(Position position, string owner, int health, int mineralCost, int gasCost, int sloat)
            : base(position, owner, health, mineralCost, gasCost, sloat)
        { 
        }

        public RaceType Race
        {
            get { return RaceType.Zerg; }
        }
    }
}
