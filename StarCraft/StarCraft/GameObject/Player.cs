namespace StarCraft.GameObject
{
    using System.Collections.Generic;
    using System.Linq;
    using StarCraft.Interfaces;
    using StarCraft.Common;

    public class Player : IPlayer
    {
        private string name;
        private Position position;
        private int emptySlots;
        private int fullSlots;
        private int mineral;
        private int gas;
        private ICollection<IGameObject> gameObjects;

        public Player(string name, RaceType raceType, Position position)
        {
            this.Name = name;
            this.RaceType = raceType;
            this.Position = position;
            this.GameObjects = new List<IGameObject>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.CheckStringIsNullOrEmpty(value, "Player name cannot be null or empty");
                this.name = value;
            }
        }

        public RaceType RaceType { get; private set; }

        public Position Position
        {
            get
            {
                return this.position;
            }
            private set
            {
                Validator.CheckValueIsNegativ(value.X, "Player positin X cannot be negativ value");
                Validator.CheckValueIsNegativ(value.Y, "Player positin Y cannot be negativ value");
                this.position = value;
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
                Validator.CheckValueIsNegativ(value, "Player empty sloats cannot be negativ value");
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
                Validator.CheckValueIsNegativ(value, "Player full sloats cannot be negativ value");
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
                Validator.CheckValueIsNegativ(value, "Player mineral cannot be negativ value");
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
                Validator.CheckValueIsNegativ(value, "Player gas cannot be negativ value");
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
                Validator.CheckObjectIsNull(value);
                this.gameObjects = value;
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

        public void AddGameObject(IGameObject gameObject)
        {
            this.gameObjects.Add(gameObject);
        }

        public void RemoveDestroyGameObject()
        {
            this.gameObjects = this.GameObjects.Where(g => g.IsAlive()).ToList();
        }
    }
}
