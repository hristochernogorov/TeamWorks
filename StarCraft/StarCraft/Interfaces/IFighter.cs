namespace StarCraft.Interfaces
{
    using System.Collections.Generic;

    public interface IFighter : IGameObject
    {
        int AttackDmg { get; }

        void ResponseToAttackCommand(IGameObject objectToAttack);

        void FindObjectToAttack(IEnumerable<IGameObject> opsitePlayerUnitOnSamePossition);
    }
}
