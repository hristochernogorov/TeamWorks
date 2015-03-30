namespace StarCraft.GameObject.Buildings.Races.Terran
{
    using StarCraft.Interfaces;

    public class Barracks : Building
    {
        public Barracks(Position position, string owner, int mineralCost, int gasCost, int sloat)
           : base(position, owner, mineralCost, gasCost, sloat)
       {
           this.Health = 1000;
       }

        public override RaceType Race
        {
            get { return RaceType.Terran; }
        }
    }
}
