namespace StarCraft.GameObject.Buildings.Races.Terran
{
    using StarCraft.Interfaces;

    public class CommandCenter : Building
    {
        private const int TerranCommandCenterMineralCost = 100;
        private const int TerranCommandCenterGasCost = 20;
        private const int TerranCommandCenterHealth = 1500;
        public CommandCenter(Position position, string name)
            : base(position, name, TerranCommandCenterMineralCost, TerranCommandCenterGasCost, TerranCommandCenterHealth, RaceType.Terran)
        {
        }


    }
}
