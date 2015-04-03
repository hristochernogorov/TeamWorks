namespace StarCraft.GameObject.Units.Races.Zerg.Workers
{
    using System;

    using StarCraft.Interfaces;

    public class Drone : Gatherer
    {
        public Drone(Position position, string owner)
            : base(position, owner, RaceType.Zerg)
        {
          
        }
    }
}
