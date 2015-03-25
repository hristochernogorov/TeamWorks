namespace StarCraft.GameObject.Buildings.Races.Terran
{
    using StarCraft.Interfaces;

    public class CommandCenter : Building, IRace
    {
        public CommandCenter(Position position, string owner, int health, int mineralCost, int gasCost, int sloat)
           : base(position, owner, health, mineralCost, gasCost, sloat)
       {
       }

        public RaceType Race
        {
            get { return RaceType.Terran; }
        }
    }
}
