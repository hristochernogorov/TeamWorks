namespace StarCraft.GameObject
{
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;

    public class FlyingUnits : Unit
    {
        public FlyingUnits(Position position, string name, int mineralCost, int gasCost, int sloat, int health, int attackDmg, RaceType race, UnitType unitType = UnitType.Pedestrian)
            : base(position, name, mineralCost, gasCost, sloat, health, attackDmg, race, UnitType.Flying)
        {

        }

        public override void ResponseToAttackCommand(IGameObject obj)
        {
            this.GoTo(obj.Position);
            this.Attack(obj);
        }

        public override IGameObject FindObjectToAttack(IEnumerable<IGameObject> opsitePlayerUnitOnSamePossition)
        {
            var objectToAtaack = opsitePlayerUnitOnSamePossition.FirstOrDefault(o => (o is Unit));
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


    }
}
