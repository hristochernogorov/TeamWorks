namespace StarCraft.GameObject.Buildings.Races.Terran
{
    using StarCraft.Interfaces;

    public class CommandCenter : Building
    {
        public CommandCenter(Position position, string name)
            : base(position, name, 100, 20, 1500, RaceType.Terran)
        {
        }


    }
}
