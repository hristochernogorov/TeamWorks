namespace StarCraft.GameObject.Units.Races.Protoss.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Dragoon : Unit, IRace, IFighter
    {
        public Dragoon(Position position, string owner, int health)
           : base(position, owner, health)
        {
        }

        public RaceType Race
        {
            get { return RaceType.Protoss; }
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
