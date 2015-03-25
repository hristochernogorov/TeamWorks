namespace StarCraft.GameObject.Units.Races.Terran.Workers
{
    using StarCraft.Interfaces;
    using System;

    public class SCV : Unit, IGatherer, IRace
    {
        public SCV(Position position, string owner, int health)
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
            get { return RaceType.Terran; }
        }
    }
}
