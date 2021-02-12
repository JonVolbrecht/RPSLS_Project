using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //Variables
        Player player1;
        Player player2;
        public List<string> possibleGestures = new List<string>();
        possibleGestures.Add("Rock");
        


        //Ctor


        //Methods
        public void DeclareWinner()
        {
            if (player1.score == 3)
            {
                Console.WriteLine("\n" + player1.name + " wins");
            }
            else if (player2.score == 3)
            {
                Console.WriteLine("\n" + player2.name + " wins");
            }
        }
}
