using System;

namespace DiceRollingLab
{
    class Program
    {
        public static int Rolling(int sides)
        {
            Random ran = new Random();
            int dice = ran.Next(1, sides + 1);
            return dice;
        }
       
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////
        

        public static string GameCall(int dice1, int dice2)
        {
            int total = dice1 + dice2;
            if (total == 2)
            {
                return "\nSnake Eyes & Craps";
            }
            if (total == 3)
            {
                return "\nAce Deuce & Craps";
            }
            if (total == 12)
            {
                return "\nBox Cars & Craps";
            }
            if (total == 7 || total == 11)
            {
                return "\nWinner!";
            }

               return $"{dice1}, {dice2}";
        }
        
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Grand Circus Casino!");


            bool roll = true;
            while (roll)
            {
                Console.Write("\nHow many sides should the die have? ");
                int sides = Int32.Parse(Console.ReadLine());
                int dice1 = Rolling(sides);
                int dice2 = Rolling(sides);
                int total = dice1 + dice2;

                Console.WriteLine("\nRoll 1: ");
                Console.WriteLine($"\nYou rolled a {dice1} and a {dice2}. The total is {total}");
                Console.WriteLine(GameCall(dice1, dice2));

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////

                Console.Write("\nWould you like to roll again? (y/n) ");
                string UserYN = Console.ReadLine();
                if(UserYN != "n" && UserYN != "y")
                {
                    Console.Write("\nInvalid inout");
                    roll = false;
                   
                }

                else if  (UserYN == "y")
                {
                    Console.WriteLine();
                    roll = true;
                    continue;
                    
                }
                else if (UserYN == "n")
                {
                    roll = false;
                }
                break;


            }

            
            

        }
    }
}
