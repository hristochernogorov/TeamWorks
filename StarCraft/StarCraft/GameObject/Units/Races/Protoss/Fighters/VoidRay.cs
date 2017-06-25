namespace StarCraft.GameObject.Units.Races.Protoss.Fighters
{
    
    public class VoidRay : FlyingUnits
    {
        private const int ProtossVoidRayAttackDemage = 100;
        private const int ProtossVoidRayMineralCost = 250;
        private const int ProtossVoidRayGasCost = 100;
        private const int ProtossVoidRayHealth = 150;
        private const int ProtossVoidRaySloat = 3;

        public VoidRay(Position position, string name)
            : base(position, name, ProtossVoidRayMineralCost, ProtossVoidRayGasCost, ProtossVoidRaySloat, ProtossVoidRayHealth, ProtossVoidRayAttackDemage, RaceType.Protoss, UnitType.Flying)
        {
        }
    }
}
