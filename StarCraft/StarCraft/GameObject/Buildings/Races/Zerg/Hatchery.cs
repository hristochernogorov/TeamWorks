namespace StarCraft.GameObject.Buildings.Races.Zerg
{
    using StarCraft.Interfaces;

    public class Hatchery : Building
    {
        private const int ZergHatcheryMineralCost = 100;
        private const int ZergHatcheryGasCost = 20;
        private const int ZergHatcheryHealth = 1250;

        public Hatchery(Position position, string name)
            : base(position, name, ZergHatcheryMineralCost, ZergHatcheryGasCost, ZergHatcheryHealth, RaceType.Zerg)
        {

        }
    }
}
