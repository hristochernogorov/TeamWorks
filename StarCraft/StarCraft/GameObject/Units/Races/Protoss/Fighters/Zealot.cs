namespace StarCraft.GameObject.Units.Races.Protoss.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Zealot : Unit, IFighter
    {
        private const int ProtossZealotAttackDemage = 40;
        private const int ProtossZealotMineralCost = 60;
        private const int ProtossZealotGasCost = 0;
        private const int ProtossZealotHealth = 100;
        private const int ProtossZealotSloat = 1;

        public Zealot(Position position, string name)
            : base(position, name, ProtossZealotMineralCost, ProtossZealotGasCost, ProtossZealotSloat, ProtossZealotHealth, ProtossZealotAttackDemage, RaceType.Protoss)
        {
        }

       
    }
}
