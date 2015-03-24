namespace StarCraft.Interfaces
{
    using StarCraft.GameObject;

    public interface IGatherer : IGameObject, IMovable
    {
        bool CollectResources(ResourceType resource);
        void Work(ResourceType resource);
    }
}
