namespace StarCraft.GameObject.Units.Races.Protoss.Workers
{
    using System;

    using StarCraft.Interfaces;

    public class Probe : Unit, IRace, IGatherer
    {
        public Probe(Position position, string owner, int health)
           : base(position, owner, health)
        {
        }

        public RaceType Race
        {
            get { return RaceType.Protoss; }
        }

        public bool CollectResources(ResourceType resource)
        {
            throw new NotImplementedException();
        }

        public void Work(ResourceType resource)
        {
            throw new NotImplementedException();
        }
    }
}
