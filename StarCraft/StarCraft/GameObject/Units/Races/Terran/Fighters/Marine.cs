namespace StarCraft.GameObject.Units.Races.Terran.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Marine : Unit
    {
        private const int TerranMarineAttackDemage = 40;
        private const int TerranMarineMineralCost = 100;
        private const int TerranMarineGasCost = 0;
        private const int TerranMarineHealth = 45;
        private const int TerranMarineSloat = 2;

        public Marine(Position position, string name)
            : base(position, name, TerranMarineMineralCost, TerranMarineGasCost, TerranMarineSloat, TerranMarineHealth, TerranMarineAttackDemage, RaceType.Terran)
        {
        }
    }
}
