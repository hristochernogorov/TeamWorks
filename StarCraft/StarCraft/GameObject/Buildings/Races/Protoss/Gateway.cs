namespace StarCraft.GameObject.Buildings.Races.Protoss
{
    using StarCraft.Interfaces;

    public class Gateway : Building
    {
        public Gateway(Position position, string name)
            : base(position, name, 100, 20, 500, RaceType.Protoss)
        {
        }

        
    }
}
