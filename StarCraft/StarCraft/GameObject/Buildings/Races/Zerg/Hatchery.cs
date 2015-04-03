namespace StarCraft.GameObject.Buildings.Races.Zerg
{
    using StarCraft.Interfaces;

    public class Hatchery : Building
    {
        public Hatchery(Position position, string name)
            : base(position, name, 100, 20, 1250, RaceType.Zerg)
        {

        }
    }
}
