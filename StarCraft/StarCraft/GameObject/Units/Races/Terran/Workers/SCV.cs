namespace StarCraft.GameObject.Units.Races.Terran.Workers
{
    using System;

    using StarCraft.Interfaces;

    public class SCV : Unit, IRace, IGatherer
    {
        public SCV(Position position, string owner, int health, int mineralCost, int gasCost, int sloat)
           : base(position, owner, health, mineralCost, gasCost, sloat)
        {
        }

        public RaceType Race
        {
            get { return RaceType.Terran; }
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
