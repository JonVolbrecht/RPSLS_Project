using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        //Variables
        //public string name;
        //public int gesture;
        //public int score;

        //Ctor
        public Human(string name)
        {
            this.name = name;
        }

        //Methods
        public override void GetPlayerName()
        {
            name = Console.ReadLine();
        }

        public override void GetPlayerInput()
        {
            Console.WriteLine(" 1- Rock \n 2- Paper \n 3- Scissors \n 4- Lizard \n 5- Spock");

        }
    }
}
