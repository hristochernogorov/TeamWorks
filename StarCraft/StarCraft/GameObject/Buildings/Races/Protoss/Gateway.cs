namespace StarCraft.GameObject.Buildings.Races.Protoss
{
    using StarCraft.Interfaces;

    public class Gateway : Building
    {
        private const int ProtossGatewayMineralCost = 100;
        private const int ProtossGatewayGasCost = 20;
        private const int ProtossGatewaygHealth = 500;

        public Gateway(Position position, string name)
            : base(position, name, ProtossGatewayMineralCost, ProtossGatewayGasCost, ProtossGatewaygHealth, RaceType.Protoss)
        {
        }

        
    }
}
