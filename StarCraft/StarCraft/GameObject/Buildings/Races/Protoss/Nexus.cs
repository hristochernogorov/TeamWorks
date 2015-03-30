namespace StarCraft.GameObject.Buildings.Races.Protoss
{
    using StarCraft.Interfaces;

    public class Nexus : Building
    {
        public Nexus(Position position, string owner, int mineralCost, int gasCost, int sloat)
           : base(position, owner, mineralCost, gasCost, sloat)
        {
           this.Health = 1000;
        }

        public override RaceType Race
        {
            get { return RaceType.Protoss; }
        }
    }
}
