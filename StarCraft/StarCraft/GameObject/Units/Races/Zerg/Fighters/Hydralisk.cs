namespace StarCraft.GameObject.Units.Races.Zerg.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Hydralisk : Unit
    {
        private const int ZergHydraliskAttackDemage = 12;
        private const int ZergHydraliskMineralCost = 20;
        private const int ZergHydraliskGasCost = 20;
        private const int ZergHydraliskHealth = 80;
        private const int ZergHydraliskSloat = 1;
        public Hydralisk(Position position, string name)
            : base(position, name, ZergHydraliskMineralCost, ZergHydraliskGasCost, ZergHydraliskSloat, ZergHydraliskHealth, ZergHydraliskAttackDemage, RaceType.Zerg)
        {
        }

        
    }
}
