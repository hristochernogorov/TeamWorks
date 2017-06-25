namespace StarCraft.GameObject.Units.Races.Terran.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Firebat : Unit
    {
        private const int TerranFirebatAttackDemage = 40;
        private const int TerranFirebatMineralCost = 40;
        private const int TerranFirebatGasCost = 0;
        private const int TerranFirebatHealth = 135;
        private const int TerranFirebatSloat = 2;

        public Firebat(Position position, string name)
            : base(position, name, TerranFirebatMineralCost, TerranFirebatGasCost, TerranFirebatSloat, TerranFirebatHealth, TerranFirebatAttackDemage, RaceType.Terran)
        {
        }
    }
}
