namespace StarCraft.Interfaces
{
    using System.Collections.Generic;

    public interface IFighter : IGameObject
    {
        int AttackDmg { get; }

        void Attack(IGameObject obj);

        void ResponseToAttackCommand(IGameObject objectToAttack);

        IGameObject FindObjectToAttack(IEnumerable<IGameObject> opsitePlayerUnitOnSamePossition);
    }
}
