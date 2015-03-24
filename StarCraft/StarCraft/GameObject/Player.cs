namespace StarCraft.GameObject
{
    using StarCraft.Interfaces;

    using System.Collections.Generic;

    //TODO Secure programming
    public class Player : IPlayer
    {
        private string name;
        private int emptySlots;
        private int fullSlots;
        private int mineral;
        private int gas;
        private ICollection<IGameObject> gameObjects;
        private ICollection<IFighter> fighters;
        private ICollection<IGatherer> gatherers;

        public Player(string name)
        {
            this.gameObjects = new List<IGameObject>();
            this.fighters = new List<IFighter>();
            this.gatherers = new List<IGatherer>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public int EmptySlots
        {
            get
            {
                return this.emptySlots;
            }
            private set
            {
                this.emptySlots = value;
            }
        }

        public int FullSlots
        {
            get
            {
                return this.fullSlots;
            }
            private set
            {
                this.fullSlots = value;
            }
        }

        public int Mineral
        {
            get
            {
                return this.mineral;
            }
            private set
            {
                this.mineral = value;
            }
        }

        public int Gas
        {
            get
            {
                return this.gas;
            }
            set
            {
                this.gas = value;
            }
        }

        public ICollection<IGameObject> GameObjects
        {
            get
            {
                return new List<IGameObject>(this.gameObjects);
            }
            private set
            {
                this.gameObjects = value;
            }
        }

        public ICollection<IFighter> Fighter
        {
            get
            {
                return new List<IFighter>(this.fighters);
            }
            private set
            {
                this.fighters = value;
            }
        }

        public ICollection<IGatherer> Gatherer
        {
            get
            {
                return new List<IGatherer>(this.gatherers);
            }
            private set
            {
                this.gatherers = value;
            }
        }

        public void GetMineral(int mineral)
        {
            this.Mineral += mineral;
        }

        public void GetGas(int gas)
        {
            this.Gas += gas;
        }

        public void RemoveMineral(int mineral)
        {
            this.Mineral -= mineral;
        }

        public void RemoveGas(int gas)
        {
            this.Gas -= gas;
        }

        public void AddEmptySlots(int slots)
        {
            this.EmptySlots += slots;
        }

        public void RemoveEmptySlots(int slots)
        {
            this.EmptySlots -= slots;
        }

        public void AddFullSlotsSlots(int slots)
        {
            this.FullSlots += slots;
        }

        public void RemoveFullSlotsSlots(int slots)
        {
            this.FullSlots -= slots;
        }
    }
}
