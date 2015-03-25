namespace StarCraft.GameObject.Buildings.Races.Protoss
{
    using StarCraft.Interfaces;

    public class Gateway : Building, IRace
    {
        public Gateway(Position position, string owner, int health)
           : base(position, owner, health)
       {
       }

        public RaceType Race
        {
            get { return RaceType.Protoss; }
        }
    }
}
