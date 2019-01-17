using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {  
            bool facts = true;
            while (facts == true)
            {
            try
            {
                Console.WriteLine("Learn your cubes and squares!");
                Console.WriteLine(" ");

                Console.WriteLine("Enter an integer:");
                string num = (Console.ReadLine());

                Console.WriteLine("Number         Squared           Cubed");
                Console.WriteLine("========       ========         =======");

                for (int multiples = 1; int.Parse(num) >= multiples; multiples++)
                {
                    Console.WriteLine($"{multiples}              {multiples * multiples}                {multiples * multiples * multiples}");
                }
                    facts = Continue();
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid integer. Please try again!");
                }
            }
        }
        public static bool Continue()
        {
            Console.WriteLine("Did you want to continue? (y/n)");
            string repeat = Console.ReadLine().ToLower();
            bool again;

            if (repeat == "y")
            {
                again = true;
            }
            else if (repeat == "n")
            {
                Console.WriteLine("Goodbye!");
                again = false;
            }
            else
            {
                Console.WriteLine("Invalid input! Please try again");
                again = Continue();
            }
            return again;
        }
    }
}
