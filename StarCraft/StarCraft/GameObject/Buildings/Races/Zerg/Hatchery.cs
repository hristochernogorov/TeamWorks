namespace StarCraft.GameObject.Buildings.Races.Zerg
{
    using StarCraft.Interfaces;

    public class Hatchery : Building
    {
        public Hatchery(Position position, string owner, int mineralCost, int gasCost, int sloat)
           : base(position, owner, mineralCost, gasCost, sloat)
        {
           this.Health = 1250;
        }

        public override RaceType Race
        {
            get { return RaceType.Zerg; }
        }
    }
}
