namespace StarCraft.GameObject
{
    using Interfaces;

    public abstract class Gatherer : Unit, IGatherer
    {
        private ResourceType collectedResourceType;

        public Gatherer(Position position, string name, RaceType race)
            : base(position, name, 10, 0, 1, 40, 2, race)
        {
        }

        public bool CollectResources(ResourceType resource)
        {
            return this.CollectedResource == resource;
        }

        public void Work(ResourceType resource)
        {
            this.collectedResourceType = resource;
        }

        public ResourceType CollectedResource
        {
            get { return this.collectedResourceType; }
        }
    }
}
