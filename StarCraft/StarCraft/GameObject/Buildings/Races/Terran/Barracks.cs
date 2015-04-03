namespace StarCraft.GameObject.Buildings.Races.Terran
{
    using StarCraft.Interfaces;

    public class Barracks : Building
    {
        public Barracks(Position position, string owner)
            : base(position, owner, 100, 20, 1000, RaceType.Terran)
        {
        }

    }
}
