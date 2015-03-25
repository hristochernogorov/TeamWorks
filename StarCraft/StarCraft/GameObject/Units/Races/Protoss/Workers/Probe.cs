namespace StarCraft.GameObject.Units.Races.Protoss.Workers
{
    using StarCraft.Interfaces;
    using System;

    public class Probe : Unit, IGatherer, IRace
    {
        public Probe(Position position, string owner, int health)
           : base(position, owner, health)
        {

        }
        public bool CollectResources(ResourceType resource)
        {
            throw new NotImplementedException();
        }

        public void Work(ResourceType resource)
        {
            throw new NotImplementedException();
        }

        public RaceType Race
        {
            get { return RaceType.Protoss; }
        }
    }
}
