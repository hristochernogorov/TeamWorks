
namespace StarCraft.Interfaces
{
    using StarCraft.GameObject;
    public interface IUnit
    {
        RaceType Race 
        { 
            get; 
        }
        UnitType Type
        { 
            get; 
        }
    }
}
