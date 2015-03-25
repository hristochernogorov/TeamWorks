namespace StarCraft.GameObject.Units.Races.Terran.Fighters
{
    using StarCraft.Interfaces;
    using System;

    public class Goliath : Unit, IFighter
    {
        public Goliath(Position position, string owner, int health)
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
