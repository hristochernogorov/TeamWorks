namespace StarCraft.GameObject
{
    using StarCraft.Interfaces;

    public abstract class GameObject : IGameObject
    {
        private string owner;
        private int mineralCost;
        private int gasCost;
        private int sloteTakes;





        public int Health
        {
            get { throw new System.NotImplementedException(); }
        }

        public int MineralCost
        {
            get { throw new System.NotImplementedException(); }
        }

        public int GasCost
        {
            get { throw new System.NotImplementedException(); }
        }

        public int Sloat
        {
            get { throw new System.NotImplementedException(); }
        }

        public string Owner
        {
            get { throw new System.NotImplementedException(); }
        }

        public Position Position
        {
            get { throw new System.NotImplementedException(); }
        }

        public bool IsAlive()
        {
            throw new System.NotImplementedException();
        }

        public void DamageTaken(int damage)
        {
            throw new System.NotImplementedException();
        }
    }
}
