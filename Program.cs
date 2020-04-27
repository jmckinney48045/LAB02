using System;

namespace _06Lab
{
    class Program
    {
        public static bool Intercept { get; private set; }

        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("Welcome to the Grand Circus Casino! Let's play a dice game. Press <enter> if you would like to roll the dice.");
                while (Console.ReadKey(Intercept).Key != ConsoleKey.Enter) { }

                Console.WriteLine("How many sides should each die have?");
 
                int rollSides;
                bool inputNumber = int.TryParse(Console.ReadLine(), out rollSides);

                if (inputNumber)
                {
                    Random rnd = new Random();

                    int die1 = rnd.Next(1, rollSides);
                    int die2 = rnd.Next(1, rollSides);


                    Console.WriteLine("Die 1: " + die1);
                    Console.WriteLine("Die 2: " + die2);
                }
                else

                    Console.WriteLine("Not a numeric value. Please enter a number.");
                    Console.WriteLine("Would you like to roll again? (y/n)");
                    answer = Console.ReadLine().ToUpper();
            }
            while (answer == "Y");

                Console.WriteLine("Good Bye!");
        }

    }
    
}

