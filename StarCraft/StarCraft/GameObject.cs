namespace StarCraft
{
    using System;

    public abstract class GameObject
    {
        public int Health { get; set; }

        public RaceType Race { get; private set; }

        public Point Position { get; protected set; }

        public GameObject(int health, Point position, RaceType race)
        {

        }
    }
}
