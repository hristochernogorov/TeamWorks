namespace StarCraft.GameObject.Units.Races.Zerg.Fighters
{
    using StarCraft.Interfaces;
    using System;

    public class Zergling : Unit, IFighter
    {
        public Zergling(Position position, string owner, int health)
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
