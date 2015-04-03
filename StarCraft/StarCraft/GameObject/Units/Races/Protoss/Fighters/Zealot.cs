namespace StarCraft.GameObject.Units.Races.Protoss.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Zealot : Unit, IFighter
    {
        public Zealot(Position position, string name)
            : base(position, name, 60, 0, 1, 100, 40, RaceType.Protoss)
        {
        }

       
    }
}
