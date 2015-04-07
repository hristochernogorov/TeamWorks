namespace StarCraft.GameObject.Units.Races.Terran.Fighters
{
    using StarCraft.Interfaces;

    public class Battlecruiser : FlyingUnits
    {
        private const int TerranBattlecruiserAttackDemage = 20;
        private const int TerranBattlecruiserMineralCost = 400;
        private const int TerranBattlecruiserGasCost = 300;
        private const int TerranBattlecruiserHealth = 550;
        private const int TerranBattlecruiserSloat = 6;

        public Battlecruiser(Position position, string name)
            : base(position, name, TerranBattlecruiserMineralCost, TerranBattlecruiserGasCost, TerranBattlecruiserSloat, TerranBattlecruiserHealth, TerranBattlecruiserAttackDemage, RaceType.Terran, UnitType.Flying)
        {
        }
    }
}
