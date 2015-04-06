namespace StarCraft.GameObject.Units.Races.Zerg.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Guardian : Unit
    {
        private const int ZergGuardianAttackDemage = 20;
        private const int ZergGuardianMineralCost = 40;
        private const int ZergGuardianGasCost = 0;
        private const int ZergGuardianHealth = 100;
        private const int ZergGuardianSloat = 2;

        public Guardian(Position position, string name)
            : base(position, name, ZergGuardianMineralCost, ZergGuardianGasCost, ZergGuardianSloat, ZergGuardianHealth, ZergGuardianAttackDemage, RaceType.Zerg)
        {
        }

       
    }
}
