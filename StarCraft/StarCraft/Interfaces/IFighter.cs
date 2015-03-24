namespace StarCraft.Interfaces
{
    using System.Collections.Generic;

    public interface IFighter : IGameObject, IMovable
    {
        void Attack(IGameObject obj);

        void FindObjectToAttack(IEnumerable<IGameObject> opsitePlayerUnitOnSamePossition);
    }
}
