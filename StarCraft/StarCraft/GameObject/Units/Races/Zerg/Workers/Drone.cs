namespace StarCraft.GameObject.Units.Races.Zerg.Workers
{
    using StarCraft.Interfaces;
    using System;

    public class Drone : Unit, IGatherer, IRace
    {
        public Drone(Position position, string owner, int health)
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
            get { return RaceType.Zerg; }
        }
    }
}
