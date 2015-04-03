namespace StarCraft.GameObject.Units.Races.Terran.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Goliath : Unit
    {
        public Goliath(Position position, string name)
            : base(position, name, 100, 20, 2, 125, 40, RaceType.Terran)
        {
        }
    }
}
