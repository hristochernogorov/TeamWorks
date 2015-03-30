namespace StarCraft.GameObject.Units.Races.Terran.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Hellbat : Unit, IFighter
    {
        public Hellbat(Position position, string owner, int mineralCost, int gasCost, int sloat)
           : base(position, owner, mineralCost, gasCost, sloat)
        {
            this.Health = 135;
        }

        public int AttackDmg
        {
            get { return 18; }
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
