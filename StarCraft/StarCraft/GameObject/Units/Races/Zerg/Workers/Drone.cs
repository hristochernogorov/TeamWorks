namespace StarCraft.GameObject.Units.Races.Zerg.Workers
{
    using System;

    using StarCraft.Interfaces;

    public class Drone : Unit, IGatherer
    {
        public Drone(Position position, string owner, int mineralCost, int gasCost, int sloat)
           : base(position, owner, mineralCost, gasCost, sloat)
        {
            this.Health = 40;
        }

        public override RaceType Race
        {
            get { return RaceType.Zerg; }
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
