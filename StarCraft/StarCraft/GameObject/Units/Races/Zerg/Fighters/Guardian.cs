﻿namespace StarCraft.GameObject.Units.Races.Zerg.Fighters
{
    using StarCraft.Interfaces;
    using System;

    public class Guardian : Unit, IFighter
    {
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
