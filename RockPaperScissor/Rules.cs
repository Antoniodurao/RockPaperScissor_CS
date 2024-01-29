using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class Rules
    {
        private string h1;
        private string h2;
        public void setHand (Enum h1, Enum h2)
        {
            this.h1 = h1.Name;   
            this.h2 = h2.Name;
        }

        public string getResult ()
        {
            Console.WriteLine("Player 1's hand is " + this.h1);
            Console.WriteLine("Player 2's hand is " + this.h2);

            if(h1 == null || h2 == null)
            {
                return "No Hand has been picked..";
            }

            if((h1 == "Paper" && h2 == "Rock") || (h1 == "Rock" && h2 == "Scissor") || (h1 == "Scissor" && h2 == "Paper"))
            {
                return "Player 1 Wins!";
            } else if ((h1 == h2))
            {
                return "It's a Draw";
            } else
            {
                return "Player 2 Wins!";
            }
        }
    }
}
