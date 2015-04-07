namespace StarCraft.GameObject.Units.Races.Zerg.Fighters
{
    using StarCraft.Interfaces;

    public class Mutalisk : FlyingUnits
    {
        private const int ZergMutaliskAttackDemage = 9;
        private const int ZergMutaliskMineralCost = 100;
        private const int ZergMutaliskGasCost = 100;
        private const int ZergMutaliskHealth = 120;
        private const int ZergMutaliskSloat = 2;

        public Mutalisk(Position position, string name)
            : base(position, name, ZergMutaliskMineralCost, ZergMutaliskGasCost, ZergMutaliskSloat, ZergMutaliskHealth, ZergMutaliskAttackDemage, RaceType.Zerg, UnitType.Flying)
        {
        }

        
    }
}
