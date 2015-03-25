namespace StarCraft.GameObject.Buildings.Races.Protoss
{
    using StarCraft.Interfaces;

    public class Nexus : Building, IRace
    {
        public Nexus(Position position, string owner, int health, int mineralCost, int gasCost, int sloat)
           : base(position, owner, health, mineralCost, gasCost, sloat)
       {
       }

        public RaceType Race
        {
            get { return RaceType.Protoss; }
        }
    }
}
