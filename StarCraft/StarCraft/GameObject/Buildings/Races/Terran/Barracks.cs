namespace StarCraft.GameObject.Buildings.Races.Terran
{
    using StarCraft.Interfaces;

    public class Barracks : Building, IRace
    {
        public Barracks(Position position, string owner, int health)
           : base(position, owner, health)
       {
       }

        public RaceType Race
        {
            get { return RaceType.Terran; }
        }
    }
}
