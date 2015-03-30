namespace StarCraft.GameObject.Buildings.Races.Zerg
{
    using StarCraft.Interfaces;

    public class SpawningPool : Building
    {
        public SpawningPool(Position position, string owner, int mineralCost, int gasCost, int sloat)
            : base(position, owner, mineralCost, gasCost, sloat)
        {
            this.Health = 750;
        }

        public override RaceType Race
        {
            get { return RaceType.Zerg; }
        }
    }
}
