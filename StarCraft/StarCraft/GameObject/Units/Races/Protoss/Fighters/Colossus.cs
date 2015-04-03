namespace StarCraft.GameObject.Units.Races.Protoss.Fighters
{
    using StarCraft.GameObject;

    public class Colossus : Unit
    {
        private const int AttackDemage = 15;

        public Colossus(Position position, string name)
            : base(position, name, 100, 20, 2, 200, Colossus.AttackDemage, RaceType.Protoss)
        {
        }
    }
}
