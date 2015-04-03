namespace StarCraft.GameObject.Units.Races.Terran.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Marine : Unit
    {
        public Marine(Position position, string name)
            : base(position, name, 100, 0, 2, 45, 40, RaceType.Terran)
        {
        }
    }
}
