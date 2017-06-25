namespace StarCraft.GameObject.Units.Races.Protoss.Fighters
{
    using StarCraft.GameObject;

    public class Colossus : Unit
    {
        private const int ProtossColossusAttackDemage = 15;
        private const int ProtossColossusMineralCost = 100;
        private const int ProtossColossusGasCost = 20;
        private const int ProtossColossusHealth = 750;
        private const int ProtossColossusSloat = 2;

        public Colossus(Position position, string name)
            : base(position, name, ProtossColossusMineralCost, ProtossColossusGasCost, ProtossColossusSloat, ProtossColossusHealth, ProtossColossusAttackDemage, RaceType.Protoss)
        {
        }
    }
}
