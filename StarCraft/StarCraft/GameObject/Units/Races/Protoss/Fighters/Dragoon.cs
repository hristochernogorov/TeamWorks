namespace StarCraft.GameObject.Units.Races.Protoss.Fighters
{
    using StarCraft.GameObject;
    using StarCraft.Interfaces;
    using System;
    
    public class Dragoon : Unit, IFighter
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
