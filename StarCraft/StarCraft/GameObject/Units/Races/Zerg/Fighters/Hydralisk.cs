namespace StarCraft.GameObject.Units.Races.Zerg.Fighters
{
    using System;

    using StarCraft.Interfaces;

    public class Hydralisk : Unit, IRace, IFighter
    {
        public Hydralisk(Position position, string owner, int health)
           : base(position, owner, health)
        {
        }

        public RaceType Race
        {
            get { return RaceType.Zerg; }
        }

        public void Attack(IGameObject obj)
        {
            throw new NotImplementedException();
        }

        public void FindObjectToAttack(System.Collections.Generic.IEnumerable<IGameObject> opsitePlayerUnitOnSamePossition)
        {
            throw new NotImplementedException();
        }
    }
}
