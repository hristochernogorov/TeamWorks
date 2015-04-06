namespace StarCraft.GameObject.Buildings.Races.Zerg
{
    using StarCraft.Interfaces;

    public class SpawningPool : Building
    {
        private const int ZergSpawningPoolMineralCost = 100;
        private const int ZergSpawningPoolGasCost = 20;
        private const int ZergSpawningPoolyHealth = 750;

        public SpawningPool(Position position, string name, int sloat)
            : base(position, name, ZergSpawningPoolMineralCost, ZergSpawningPoolGasCost, ZergSpawningPoolyHealth, RaceType.Zerg)
        {
        }
    }
}
