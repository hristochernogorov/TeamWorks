﻿namespace StarCraft.GameObject.Units.Races.Protoss.Fighters
{
    using StarCraft.Interfaces;
    using System;
    
    public class Dragoon : Unit, IFighter
    {
        public Dragoon(Position position, string owner, int health)
           : base(position, owner, health)
        {

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