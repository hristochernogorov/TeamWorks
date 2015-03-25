﻿namespace StarCraft.GameObject.Units.Races.Terran.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Goliath : Unit, IRace, IFighter
    {
        public Goliath(Position position, string owner, int health)
           : base(position, owner, health)
        {
        }

        public RaceType Race
        {
            get { return RaceType.Terran; }
        }

        public void Attack(IGameObject obj)
        {
            throw new NotImplementedException();
        }

        public void FindObjectToAttack(System.Collections.Generic.IEnumerable<IGameObject> opsitePlayerUnitOnSamePossition)
        {
            throw new NotImplementedException();
        }
    }
}
