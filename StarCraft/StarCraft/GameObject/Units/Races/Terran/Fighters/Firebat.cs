namespace StarCraft.GameObject.Units.Races.Terran.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Firebat : Unit
    {
        public Firebat(Position position, string name)
            : base(position, name, 40, 0, 2, 135, 40, RaceType.Terran)
        {
        }
    }
}
