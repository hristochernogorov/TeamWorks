namespace StarCraft.GameObject.Units.Races.Zerg.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Guardian : Unit
    {
        public Guardian(Position position, string name)
            : base(position, name, 40, 0, 2, 100, 20, RaceType.Zerg)
        {
        }

       
    }
}
