namespace StarCraft.GameObject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using StarCraft.Interfaces;

    public abstract class Unit : GameObject, IMovable, IFighter
    {
        private int attackDmg;
        private UnitType unitType;

        public Unit(Position position, string name, int mineralCost, int gasCost, int sloat, int health, int attackDmg, RaceType race, UnitType unitType = UnitType.Pedestrian)
            : base(position, name, mineralCost, gasCost, sloat, health, race)
        {
            this.AttackDmg = attackDmg;
            this.UnitType = unitType;
        }

        public UnitType UnitType { get; private set; }

        public void GoTo(Position newPosition)
        {
            this.Position = newPosition;
        }

        public int AttackDmg
        {
            get
            {
                return this.attackDmg;

            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("{0} attack damage cannot be negative", this.GetType().Name);
                }
                this.attackDmg = value;
            }
        }

        public void Attack(IGameObject obj)
        {
            obj.DamageTaken(this.attackDmg);
        }

        public virtual void ResponseToAttackCommand(IGameObject obj)
        {
            if (obj is Building)
            {
                this.GoTo(obj.Position);
                this.Attack(obj);
            }
            else
            {
               var unit = obj as Unit;
                if (this.UnitType == unit.UnitType)
                {
                    this.GoTo(obj.Position);
                    this.Attack(obj);
                }
            }
        }

        public virtual IGameObject FindObjectToAttack(IEnumerable<IGameObject> opsitePlayerUnitOnSamePossition)
        {
            var objectToAtaack = opsitePlayerUnitOnSamePossition.FirstOrDefault(o => (o is Unit) && (o as Unit).unitType == this.unitType);
            if (objectToAtaack != null)
            {
                return objectToAtaack;
            }
            else
            {
                objectToAtaack = opsitePlayerUnitOnSamePossition.FirstOrDefault(o => o is Building);

                return objectToAtaack;

            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} Health: {2}; Attack Demage: {3}", this.GetType().Name, this.Name, this.Health, this.attackDmg);
        }
    }
}
