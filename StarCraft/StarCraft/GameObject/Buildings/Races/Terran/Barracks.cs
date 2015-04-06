namespace StarCraft.GameObject.Buildings.Races.Terran
{
    using StarCraft.Interfaces;

    public class Barracks : Building
    {
        private const int TerranBarracksMineralCost = 100;
        private const int TerranBarracksGasCost = 20;
        private const int TerranBarracksHealth = 1000;

        public Barracks(Position position, string owner)
            : base(position, owner, TerranBarracksMineralCost, TerranBarracksGasCost, TerranBarracksHealth, RaceType.Terran)
        {
        }

    }
}
