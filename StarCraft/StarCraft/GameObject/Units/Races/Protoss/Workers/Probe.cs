namespace StarCraft.GameObject.Units.Races.Protoss.Workers
{
    using System;

    using StarCraft.Interfaces;

    public class Probe : Gatherer
    {
        public Probe(Position position, string name)
            : base(position, name, RaceType.Protoss)
        {
        }
    }
}
