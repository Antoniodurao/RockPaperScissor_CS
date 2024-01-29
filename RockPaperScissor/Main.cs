using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RockPaperScissor.Enum;

namespace RockPaperScissor
{
    internal class rps
    {
        static void Main(string[] args)
        {
            Rules rules = new Rules();
            Enum p1 = new Enum();
            Enum p2 = new Enum();    
            while (true)
            {
                Console.WriteLine("Player 1 chose your hand: Rock || Paper || Scissor ");
                p1.Name = Console.ReadLine();
                while (p1.Name != "Scissor" && p1.Name != "Rock" && p1.Name != "Paper")
                {
                    Console.WriteLine("Please chose a normal option ");
                    p1.Name = Console.ReadLine();
                }

                Console.WriteLine("Player 2 chose your hand: Rock || Paper || Scissor ");
                p2.Name = Console.ReadLine();
                while (p2.Name != "Scissor" && p2.Name != "Rock" && p2.Name != "Paper")
                {
                    Console.WriteLine("Please chose a normal option  ");
                    p2.Name = Console.ReadLine();
                }
                    

                rules.setHand(p1, p2);
            
                Console.WriteLine(rules.getResult());
                Console.WriteLine("-----------------------------------------------------");
            }
            
            

        }
    }
}
