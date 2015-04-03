namespace StarCraft.GameObject
{
    using System;
    using StarCraft.CustomAttributes;
    using StarCraft.Interfaces;

    [Author("Todor Dimitrov")]
    public abstract class GameObject : IGameObject
    {
        private string name;
        private int mineralCost;
        private int gasCost;
        private int sloteTakes;
        private Position position;

        public GameObject(Position position, string name, int mineralCost, int gasCost, int sloat, int health, RaceType race)
        {
            this.Position = position;
            this.Name = name;
            this.Health = health;
            this.MineralCost = mineralCost;
            this.GasCost = gasCost;
            this.Sloat = sloat;
            this.Race = race;
        }

        public int Health { get;  set; }

        public RaceType Race { get; private set; }

        public int MineralCost
        {
            get
            {
                return this.mineralCost;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Game object mineral cost should be greater by zero");
                }

                this.mineralCost = value;
            }
        }

        public int GasCost
        {
            get
            {
                return this.gasCost;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Game object gas cost should be greater by zero");
                }

                this.gasCost = value;
            }
        }

        public int Sloat
        {
            get
            {
                return this.sloteTakes;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Game object slote should be greater by zero");
                }

                this.sloteTakes = value;
            }
        }

        public string Name
        {
            // TODO: Validation
            get { return this.name; }
            protected set { this.name = value; }
        }

        public Position Position
        {
            // TODO: Validation
            get { return this.position; }
            protected set { this.position = value; }
        }

        public bool IsAlive()
        {
            return this.Health > 0;
        }

        public void DamageTaken(int damage)
        {
            this.Health -= damage;
        }



    }
}
