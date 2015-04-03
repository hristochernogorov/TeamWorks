namespace StarCraft.Engine
{
    using GameObject.Units.Races.Protoss.Workers;
    using GameObject.Units.Races.Terran.Workers;
    using GameObject.Units.Races.Zerg.Workers;
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

        public IFighter CreateFighterUnit(Position position, string namer)
        {
            throw new System.NotImplementedException();
        }
    }
}

