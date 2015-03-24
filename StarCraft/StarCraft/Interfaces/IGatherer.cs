namespace StarCraft.Interfaces
{
    using StarCraft.GameObject;

    public interface IGatherer : IMovable
    {
        bool CollectResources(ResourceType resource);
        void Work(ResourceType resource);
    }
}
