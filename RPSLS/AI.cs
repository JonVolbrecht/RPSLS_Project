using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AI : Player
    {
        //Variables
        //public string name;
        //public int gesture;
        //public int score;
        Random randomGesture = new Random();

        //Ctor
        public AI(string name)
        {
            this.name = "HAL";
            Console.WriteLine(name);
        }

        //Methods
        public override void GetPlayerInput()
        {
            int number = randomGesture.Next(1, 5);

            switch (number)
            {
                case 1:
                    Console.WriteLine(name + " chose Rock");
                    gesture = 1;
                    break;

                case 2:
                    Console.WriteLine(name + " chose Paper");
                    gesture = 2;
                    break;

                case 3:
                    Console.WriteLine(name + " chose scissors");
                    gesture = 3;
                    break;

                case 4:
                    Console.WriteLine(name + " chose Lizard");
                    gesture = 4;
                    break;

                case 5:
                    Console.WriteLine(name + " chose Spock");
                    gesture = 5;
                    break;




            }




        }
    }
}
