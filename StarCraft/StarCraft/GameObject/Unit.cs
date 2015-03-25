namespace StarCraft.GameObject
{
    using StarCraft.Interfaces;
   public abstract class Unit : MovingObject, IUnit
    {
       public Unit(Position position, string owner, int health)
           : base(position, owner, health)
       {

       }

       public RaceType Race
       {
           get { throw new System.NotImplementedException(); }
       }

       public UnitType Type
       {
           get { throw new System.NotImplementedException(); }
       }
    }
}
