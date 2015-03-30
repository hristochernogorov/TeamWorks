namespace StarCraft.GameObject.Units.Races.Protoss.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Colossus : Unit, IFighter
    {
        public Colossus(Position position, string owner, int mineralCost, int gasCost, int sloat)
            : base(position, owner, mineralCost, gasCost, sloat)
        {
            this.Health = 200;
        }

        public int AttackDmg
        {
            get { return 15; }
        }

        public override RaceType Race
        {
            get { return RaceType.Protoss; }
        }

        public void Attack(IGameObject obj)
        {
            obj.Health -= this.AttackDmg;
        }

        public void FindObjectToAttack(System.Collections.Generic.IEnumerable<IGameObject> opsitePlayerUnitOnSamePossition)
        {
            throw new NotImplementedException();
        }
    }
}
