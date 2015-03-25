namespace StarCraft.GameObject.Buildings.Races.Zerg
{
    using StarCraft.Interfaces;

    public class SpawningPool : Building, IRace
    {
        public SpawningPool(Position position, string owner, int health)
            : base(position, owner, health)
        { 
        }

        public RaceType Race
        {
            get { return RaceType.Zerg; }
        }
    }
}
