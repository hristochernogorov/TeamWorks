namespace StarCraft.GameObject.Units.Races.Terran.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Goliath : Unit
    {
        private const int TerranGoliathAttackDemage = 40;
        private const int TerranGoliathMineralCost = 100;
        private const int TerranGoliathGasCost = 20;
        private const int TerranGoliathHealth = 125;
        private const int TerranGoliathSloat = 2;
        public Goliath(Position position, string name)
            : base(position, name, TerranGoliathMineralCost, TerranGoliathGasCost, TerranGoliathSloat, TerranGoliathHealth, TerranGoliathAttackDemage, RaceType.Terran)
        {
        }
    }
}
