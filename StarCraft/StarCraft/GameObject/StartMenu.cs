using StarCraft.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft.GameObject
{
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
            Console.WriteLine(startMenu.ToString());
        }
    }
}
