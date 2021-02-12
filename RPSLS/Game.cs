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
        public List<string> possibleGestures = new List<string>
        { "Rock", "Paper", "Scissors", "Lizard", "Spock"};

        //Ctor

        //Methods

        public void DisplayGestures()
        {
            Console.WriteLine("\nPossible Gestures:");
            possibleGestures.ForEach(Console.WriteLine);
        }

        public void DisplayRules()
        {
            Console.WriteLine("Rules: \n Rock crushes Scissors \n Paper covers Rock  \n Scissors cuts Paper \n Rock crushes Lizard \n Lizard poisons Spock \n Spock smashes Scissors \n Scissors decapitates Lizard \n Lizard eats Paper \n Paper disproves Spock \n Spock vaporizes Rock");
        }

        public void GetNumberOfPlayers()
        {
            Console.WriteLine("\nHow many players? Enter '1' or '2'");

            switch (Console.ReadLine())
            {
                case "1":
                    Player 1
            }
        }

    }
}
