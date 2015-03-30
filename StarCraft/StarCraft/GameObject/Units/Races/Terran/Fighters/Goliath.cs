namespace StarCraft.GameObject.Units.Races.Terran.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Goliath : Unit, IFighter
    {
        public Goliath(Position position, string owner, int mineralCost, int gasCost, int sloat)
           : base(position, owner, mineralCost, gasCost, sloat)
        {
            this.Health = 125;
        }

        public int AttackDmg
        {
            get { return 20; }
        }

        public override RaceType Race
        {
            get { return RaceType.Terran; }
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
