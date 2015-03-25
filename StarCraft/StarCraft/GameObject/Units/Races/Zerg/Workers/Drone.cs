﻿namespace StarCraft.GameObject.Units.Races.Zerg.Workers
{
    using System;

    using StarCraft.Interfaces;

    public class Drone : Unit, IRace, IGatherer
    {
        public Drone(Position position, string owner, int health, int mineralCost, int gasCost, int sloat)
           : base(position, owner, health, mineralCost, gasCost, sloat)
        {
        }

        public RaceType Race
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
