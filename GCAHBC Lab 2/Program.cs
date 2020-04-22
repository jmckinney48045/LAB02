using System;

namespace GCAHBC_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string input;
            
            do
            {
                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
                
                Console.WriteLine("Enter Length: ");
                string length = Console.ReadLine();
                
                Console.WriteLine("Enter Width: ");
                string width = Console.ReadLine();

                decimal l1 = decimal.Parse(length);
                decimal w1 = decimal.Parse(width);


                Console.WriteLine(("Area: ") + (l1 * w1) + (" Sq. Ft."));
                Console.WriteLine(("Perimeter: ") + ((l1 * 2) + (w1 * 2) + (" Ft.")));

                Console.WriteLine("Continue ? (y / n)");
                input = Console.ReadLine().ToUpper();

            }
            while (input == "Y");

                Console.WriteLine("Goodbye!");

        }
    }
}
