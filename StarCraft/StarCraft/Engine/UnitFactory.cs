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
    }
}

