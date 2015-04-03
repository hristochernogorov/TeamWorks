namespace StarCraft.GameObject.Buildings.Races.Protoss
{
    using StarCraft.Interfaces;

    public class Nexus : Building
    {
        public Nexus(Position position, string name)
            : base(position, name, 100, 100, 1000, RaceType.Protoss)
        {
        }

       
    }
}
