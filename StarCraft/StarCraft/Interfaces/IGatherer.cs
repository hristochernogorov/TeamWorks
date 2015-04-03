namespace StarCraft.Interfaces
{
    using StarCraft.GameObject;

    public interface IGatherer : IMovable
    {
        ResourceType CollectedResource { get; }

        bool CollectResources(ResourceType resource);

        void Work(ResourceType resource);
    }
}
