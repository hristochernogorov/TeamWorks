namespace StarCraft.GameObject.Units.Races.Protoss.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Dragoon : Unit, IFighter
    {
        public Dragoon(Position position, string name)
            : base(position, name, 100, 20, 4, 800, 200, RaceType.Protoss)
        {
        }
    }
}
