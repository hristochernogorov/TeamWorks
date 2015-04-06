namespace StarCraft.GameObject.Units.Races.Zerg.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Zergling : Unit
    {
        private const int ZergZerglingAttackDemage = 40;
        private const int ZergZerglingMineralCost = 40;
        private const int ZergZerglingGasCost = 0;
        private const int ZergZerglingHealth = 35;
        private const int ZergZerglingSloat = 2;

        public Zergling(Position position, string name)
            : base(position, name, ZergZerglingMineralCost, ZergZerglingGasCost, ZergZerglingSloat, ZergZerglingHealth, ZergZerglingAttackDemage, RaceType.Zerg)
        {
        }
    }
}
