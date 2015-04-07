namespace StarCraft.Engine
{
    using StarCraft.GameObject.Units.Races.Protoss.Workers;
    using StarCraft.GameObject.Units.Races.Terran.Workers;
    using StarCraft.GameObject.Units.Races.Zerg.Workers;
    using StarCraft.GameObject.Units.Races.Protoss.Fighters;
    using StarCraft.GameObject.Units.Races.Terran.Fighters;
    using StarCraft.GameObject.Units.Races.Zerg.Fighters;

    using StarCraft.GameObject;
    using StarCraft.Interfaces;
    using StarCraft.CustomAttributes;
    using StarCraft.GameObject.Buildings.Races.Protoss;
    using StarCraft.GameObject.Buildings.Races.Terran;
    using StarCraft.GameObject.Buildings.Races.Zerg;

    [Author("Todor Dimitrov")]
    public class UnitFactory : IUnitFactory
    {
        public IGatherer CreateProbe(Position position, string name)
        {
            return new Probe(position, name);
        }
        public IGatherer CreateScv(Position position, string name)
        {
            return new SCV(position, name);
        }
        public IGatherer CreateDrone(Position position, string name)
        {
            return new Drone(position, name);
        }

        public IFighter CreateColossus(Position position, string name)
        {
            return new Colossus(position, name);
        }

        public IFighter CreateDragoon(Position position, string name)
        {
            return new Dragoon(position, name);
        }

        public IFighter CreateZealot(Position position, string name)
        {
            return new Zealot(position, name);
        }

        public IFighter CreateFirebat(Position position, string name)
        {
            return new Firebat(position, name);
        }

        public IFighter CreateGoliath(Position position, string name)
        {
            return new Goliath(position, name);
        }
        public IFighter CreateMarine(Position position, string name)
        {
            return new Marine(position, name);
        }
        public IFighter CreateGuardian(Position position, string name)
        {
            return new Guardian(position, name);
        }
        public IFighter CreateHydralisk(Position position, string name)
        {
            return new Hydralisk(position, name);
        }

        public IFighter CreateZergling(Position position, string name)
        {
            return new Zergling(position, name);
        }


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

