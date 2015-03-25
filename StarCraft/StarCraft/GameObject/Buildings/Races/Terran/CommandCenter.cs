namespace StarCraft.GameObject.Buildings.Races.Terran
{
    using StarCraft.Interfaces;

    public class CommandCenter : Building, IRace
    {
        public CommandCenter(Position position, string owner, int health)
           : base(position, owner, health)
       {
       }

        public RaceType Race
        {
            get { return RaceType.Terran; }
        }
    }
}
