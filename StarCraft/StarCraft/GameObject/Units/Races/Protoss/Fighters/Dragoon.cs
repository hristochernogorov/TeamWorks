namespace StarCraft.GameObject.Units.Races.Protoss.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Dragoon : Unit, IFighter
    {
        private const int ProtossDragoonAttackDemage = 20;
        private const int ProtossDragoonMineralCost = 100;
        private const int ProtossDragoonGasCost = 20;
        private const int ProtossDragoonHealth = 800;
        private const int ProtossDragoonSloat = 4;

        public Dragoon(Position position, string name)
            : base(position, name, ProtossDragoonMineralCost, ProtossDragoonGasCost, ProtossDragoonSloat, ProtossDragoonHealth, ProtossDragoonAttackDemage, RaceType.Protoss)
        {
        }
    }
}
