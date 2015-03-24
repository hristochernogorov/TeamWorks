namespace StarCraft.Units.Races.Zerg
{
    using StarCraft.GameObject;
    using StarCraft.Interfaces;
    using System;

    public class Hydralisk : Unit, IFighter
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
