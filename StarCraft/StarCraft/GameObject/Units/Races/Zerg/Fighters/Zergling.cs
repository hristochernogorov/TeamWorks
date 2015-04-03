namespace StarCraft.GameObject.Units.Races.Zerg.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Zergling : Unit
    {
        public Zergling(Position position, string name)
            : base(position, name, 40, 0, 2, 35, 40, RaceType.Zerg)
        {
        }
    }
}
