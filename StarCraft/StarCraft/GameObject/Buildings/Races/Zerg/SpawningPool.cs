namespace StarCraft.GameObject.Buildings.Races.Zerg
{
    using StarCraft.Interfaces;

    public class SpawningPool : Building
    {
        public SpawningPool(Position position, string name, int mineralCost, int gasCost, int sloat)
            : base(position, name, mineralCost, gasCost, 750, RaceType.Zerg)
        {
        }
    }
}
