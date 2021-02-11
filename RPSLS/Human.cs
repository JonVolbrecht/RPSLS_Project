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
    }
}
