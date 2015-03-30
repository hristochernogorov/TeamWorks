namespace StarCraft.GameObject
{
    using StarCraft.Interfaces;

    public abstract class Unit : GameObject, IMovable, IRace
    {
        public Unit(Position position, string owner, int mineralCost, int gasCost, int sloat)
           : base(position, owner, mineralCost, gasCost, sloat)
        {
        }

        public abstract RaceType Race { get; }

        public void GoTo(Position newPosition)
        {
            throw new System.NotImplementedException();
        }
    }
}
