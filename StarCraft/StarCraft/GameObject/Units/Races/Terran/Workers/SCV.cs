namespace StarCraft.GameObject.Units.Races.Terran.Workers
{
    using System;

    using StarCraft.Interfaces;

    public class SCV : Gatherer
    {
        public SCV(Position position, string name)
            : base(position, name, RaceType.Terran)
        {
        }
    }
}
