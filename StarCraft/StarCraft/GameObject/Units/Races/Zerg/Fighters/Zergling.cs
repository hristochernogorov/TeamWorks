namespace StarCraft.GameObject.Units.Races.Zerg.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Zergling : Unit, IFighter
    {
        public Zergling(Position position, string owner, int mineralCost, int gasCost, int sloat)
           : base(position, owner, mineralCost, gasCost, sloat)
        {
            this.Health = 35;
        }

        public int AttackDmg
        {
            get { return 5; }
        }

        public override RaceType Race
        {
            get { return RaceType.Zerg; }
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
