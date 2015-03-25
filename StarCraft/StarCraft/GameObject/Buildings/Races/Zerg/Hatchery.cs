namespace StarCraft.GameObject.Buildings.Races.Zerg
{
    using StarCraft.Interfaces;

    public class Hatchery : Building, IRace
    {
        public Hatchery(Position position, string owner, int health)
           : base(position, owner, health)
       {

       }

        public RaceType Race
        {
            get { return RaceType.Zerg; }
        }
    }
}
