namespace StarCraft.GameObject.Units.Races.Zerg.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Hydralisk : Unit
    {
        public Hydralisk(Position position, string name)
            : base(position, name, 20, 20, 1, 80, 12, RaceType.Zerg)
        {
        }

        
    }
}
