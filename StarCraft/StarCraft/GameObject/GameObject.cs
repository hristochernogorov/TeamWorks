namespace StarCraft.GameObject
{
    using System;
    using StarCraft.Interfaces;

    public abstract class GameObject : IGameObject
    {
        private const int GeneralMineralCost = 0;
        private const int GeneralGasCost = 0;
        private const int GeneralSloteTakes = 0;
        private string owner;
        private int mineralCost;
        private int gasCost;
        private int sloteTakes;
        private int health;
        private Position position;


        public GameObject(Position position, string owner, int health)
        {
            this.Position = position;
            this.Owner = owner;
            this.Health = health;
            this.MineralCost = GameObject.GeneralMineralCost;
            this.GasCost = GameObject.GeneralGasCost;
            this.Sloat = GameObject.GeneralSloteTakes;
        }


        public int Health
        {
            get 
            {
                return this.health;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Game object health should be greater by zero");
                }
                this.health = value;
            }
        }

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
                if (value <= 0)
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

        public string Owner
        {
            //TODO: Validation
            get { return this.owner; }
            protected set { this.owner = value; }
        }

        public Position Position
        {
            //TODO: Validation
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
