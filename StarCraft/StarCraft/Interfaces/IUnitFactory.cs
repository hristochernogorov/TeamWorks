﻿
namespace StarCraft.Interfaces
{
    using StarCraft.GameObject;
    using StarCraft.CustomAttributes;
    [Author("Todor Dimitrov")]
   public interface IUnitFactory
    {
        IGatherer CreateProbe(Position position, string name);
        IGatherer CreateScv(Position position, string name);
        IGatherer CreateDrone(Position position, string name);
        IFighter CreateColossus(Position position, string name);
        IFighter CreateDragoon(Position position, string name);
        IFighter CreateZealot(Position position, string name);
        IFighter CreateFirebat(Position position, string name);
        IFighter CreateGoliath(Position position, string name);
        IFighter CreateMarine(Position position, string name);
        IFighter CreateGuardian(Position position, string name);
        IFighter CreateHydralisk(Position position, string name);
        IFighter CreateZergling(Position position, string name);

        IGameObject CreateGateway(Position position, string name);
        IGameObject CreateNexus(Position position, string name);
        IGameObject CreateBarracks(Position position, string name);
        IGameObject CreateCommandCenter(Position position, string name);
        IGameObject CreateHatchery(Position position, string name);
        IGameObject CreateSpawningPool(Position position, string name);
    }
}
