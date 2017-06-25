namespace StarCraft.GameObject.Buildings.Races.Protoss
{
    using StarCraft.Interfaces;

    public class Nexus : Building
    {
        private const int ProtossNexusMineralCost = 100;
        private const int ProtossNexusGasCost = 100;
        private const int ProtossNexusHealth = 1000;

        public Nexus(Position position, string name)
            : base(position, name, ProtossNexusMineralCost, ProtossNexusGasCost, ProtossNexusHealth, RaceType.Protoss)
        {
        }

       
    }
}
