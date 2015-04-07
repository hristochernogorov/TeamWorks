
namespace StarCraft.Engine
{
    using StarCraft.GameObject;
    using StarCraft.GameObject.Buildings.Races.Protoss;
    using StarCraft.GameObject.Buildings.Races.Terran;
    using StarCraft.GameObject.Buildings.Races.Zerg;

    public class BuildingFactory
    {
        public Building CreateGateway(Position position, string name)
        {
            return new Gateway(position, name);
        }

        public Building CreateNexus(Position position, string name)
        {
            return new Nexus(position, name);
        }

        public Building CreateBarracks(Position position, string name)
        {
            return new Barracks(position, name);
        }

        public Building CreateCommandCenter(Position position, string name)
        {
            return new CommandCenter(position, name);
        }

        public Building CreateHatchery(Position position, string name)
        {
            return new Hatchery(position, name);
        }

        public Building CreateSpawningPool(Position position, string name)
        {
            return new SpawningPool(position, name);
        }
    }
}
