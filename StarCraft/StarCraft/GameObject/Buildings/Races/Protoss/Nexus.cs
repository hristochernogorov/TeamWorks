namespace StarCraft.GameObject.Buildings.Races.Protoss
{
    using StarCraft.Interfaces;

    public class Nexus : Building, IRace
    {
        public Nexus(Position position, string owner, int health)
           : base(position, owner, health)
       {

       }

        public RaceType Race
        {
            get { return RaceType.Protoss; }
        }
    }
}
