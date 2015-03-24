namespace StarCraft.Interfaces
{
    using StarCraft.GameObject;

   public interface IMovable: IGameObject
    {
       void GoTo(Position newPosition);
    }
}
