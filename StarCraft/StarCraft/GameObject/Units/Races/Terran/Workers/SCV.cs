namespace StarCraft.GameObject.Units.Races.Terran.Workers
{
    using System;

    using StarCraft.Interfaces;

    public class SCV : Unit, IGatherer
    {
        public SCV(Position position, string owner, int mineralCost, int gasCost, int sloat)
           : base(position, owner, mineralCost, gasCost, sloat)
        {
            this.Health = 45;
        }

        public override RaceType Race
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
