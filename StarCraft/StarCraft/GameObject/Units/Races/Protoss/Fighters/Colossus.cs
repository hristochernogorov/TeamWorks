namespace StarCraft.GameObject.Units.Races.Protoss.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Colossus : Unit, IRace, IFighter
    {
        public Colossus(Position position, string owner, int health, int mineralCost, int gasCost, int sloat)
            : base(position, owner, health, mineralCost, gasCost, sloat)
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
