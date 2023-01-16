using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class UC5_PlayerGetWinPosition
    {

        public static void PlayerGetWinPosition()
        {
            //variables
            int currentPosition = 0;
            int NUM_OF_THROW = 0;


            while (currentPosition < 100)
            {

                Random random = new Random();
                int rollDice = random.Next(1, 7);

                Random random1 = new Random();
                int option = random.Next(0, 3);

                switch (option)
                {
                    case 0:
                        break;
                    case 1:
                        if ((currentPosition + rollDice) <= 100)
                        {
                            currentPosition = currentPosition + rollDice;
                        }
                        break;
                    case 2:
                        if ((currentPosition - rollDice) < 0)
                        {
                            currentPosition = 0;
                        }
                        else
                        {
                            currentPosition = currentPosition - rollDice;
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine(currentPosition);
            }
            Console.WriteLine("you are a winnner");
        }
    }
}
