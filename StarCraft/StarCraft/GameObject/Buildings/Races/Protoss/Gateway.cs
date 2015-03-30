namespace StarCraft.GameObject.Buildings.Races.Protoss
{
    using StarCraft.Interfaces;

    public class Gateway : Building
    {
        public Gateway(Position position, string owner, int mineralCost, int gasCost, int sloat)
           : base(position, owner, mineralCost, gasCost, sloat)
        {
           this.Health = 500;
        }

        public override RaceType Race
        {
            get { return RaceType.Protoss; }
        }
    }
}
