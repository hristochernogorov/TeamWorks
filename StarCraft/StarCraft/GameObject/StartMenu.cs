namespace StarCraft.GameObject
{
    using StarCraft.CustomAttributes;
    using StarCraft.Interfaces;
    using System;
    using System.Text;

    [Author("Ilian Bratanov")]
    public class StartMenu : IPrint
    {
        public StartMenu()
        {
            Print();
        }

        public void Print()
        {
            StringBuilder startMenu = new StringBuilder();
            startMenu.AppendLine("..........*******....*******......**.......*******..........");
            startMenu.AppendLine("..........*.....*....*..*..*.....*..*......*.....*..........");
            startMenu.AppendLine("..........*.............*.......*....*.....*.....*..........");
            startMenu.AppendLine("..........*.............*......*......*....*.....*..........");
            startMenu.AppendLine("..........*******.......*......********....*******..........");
            startMenu.AppendLine("................*.......*......*......*....*..*.............");
            startMenu.AppendLine("................*.......*......*......*....*...*............");
            startMenu.AppendLine("..........*.....*.......*......*......*....*....*...........");
            startMenu.AppendLine("..........*******......***.....*......*....*.....*..........");
            startMenu.AppendLine(new string('-', 60));
            startMenu.AppendLine(new string('-', 60));

            startMenu.AppendLine(".....*******....*******......**.......*******....*******....");
            startMenu.AppendLine(".....*.....*....*.....*.....*..*......*.....*....*..*..*....");
            startMenu.AppendLine(".....*..........*.....*....*....*.....*.............*.......");
            startMenu.AppendLine(".....*..........*.....*...*......*....*.............*.......");
            startMenu.AppendLine(".....*..........*******...********....*******.......*.......");
            startMenu.AppendLine(".....*..........*..*......*......*....*.............*.......");
            startMenu.AppendLine(".....*..........*...*.....*......*....*.............*.......");
            startMenu.AppendLine(".....*.....*....*....*....*......*....*.............*.......");
            startMenu.AppendLine(".....*******....*.....*...*......*...***...........***......");
            startMenu.AppendLine(new string('-', 60));
            startMenu.AppendLine(new string('-', 60));

            Console.WriteLine(startMenu.ToString());
        }
    }
}
