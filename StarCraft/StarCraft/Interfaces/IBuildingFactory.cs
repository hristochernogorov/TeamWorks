
namespace StarCraft.Interfaces
{
    using StarCraft.GameObject;
    interface IBuildingFactory
    {
        Building CreateGateway(Position position, string name);
        Building CreateNexus(Position position, string name);
        Building CreateBarracks(Position position, string name);
        Building CreateCommandCenter(Position position, string name);
        Building CreateHatchery(Position position, string name);
        Building CreateSpawningPool(Position position, string name);
    }
}
