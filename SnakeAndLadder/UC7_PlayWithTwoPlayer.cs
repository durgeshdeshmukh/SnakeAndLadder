using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class UC7_PlayWithTwoPlayer
    {
        public static void PLayWithTwoPlayer()
        {
            //variables
            int currentPosition1 = 0;
            int NUM_OF_THROW1 = 0;
            int currentPosition2 = 0;
            int NUM_OF_THROW2 = 0;


            while (currentPosition1 < 100 && currentPosition2 < 100)
            {
                //player1

                Random random1 = new Random();
                int rollDice1 = random1.Next(1, 7);

                Random random11 = new Random();
                int option1 = random1.Next(0, 3);

                switch (option1)
                {
                    case 0:
                        NUM_OF_THROW1++;
                        break;
                    case 1:
                        if ((currentPosition1 + rollDice1) <= 100)
                        {
                            currentPosition1 = currentPosition1 + rollDice1;
                        }
                        break;
                    case 2:
                        NUM_OF_THROW1++;
                        if ((currentPosition1 - rollDice1) < 0)
                        {
                            currentPosition1 = 0;
                        }
                        else
                        {
                            currentPosition1 = currentPosition1 - rollDice1;
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("player1 "+currentPosition1 + " No. of throw " + NUM_OF_THROW1);
           

                //player2

                Random random2 = new Random();
                int rollDice2 = random2.Next(1, 7);

                Random random21 = new Random();
                int option2 = random2.Next(0, 3);

                switch (option2)
                {
                    case 0:
                        NUM_OF_THROW2++;
                        break;
                    case 1:
                        if ((currentPosition2 + rollDice2) <= 100)
                        {
                            currentPosition2 = currentPosition2 + rollDice2;
                        }
                        break;
                    case 2:
                        NUM_OF_THROW2++;
                        if ((currentPosition2 - rollDice2) < 0)
                        {
                            currentPosition2 = 0;
                        }
                        else
                        {
                            currentPosition2 = currentPosition2 - rollDice2;
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("player2 "+currentPosition2 + " No of throw " + NUM_OF_THROW2);
            }
            if (currentPosition1 == 100)
            {
                Console.WriteLine("Player1 is winner");
            } 
            else 
            {
                Console.WriteLine("Player2 is winner");
            }
        }   
           
        
    }
}


