// 1/23/2021           Timothy Goddard              Initial creation with full functionality
// 1/23/2021           Timothy Goddard              Comments added


using System;

namespace OddOrEven
{
    // this class contains all code for oddoreven project
    class Program
    {
        // this main method displays info about oddoreven application, takes input
        // from user, and tells user if that input was even or odd.
        static void Main(string[] args)
        {
            // display to user what the console app will do and prompt the user
            // to enter an integer
            Console.WriteLine("Hello! This program will show whether or not an " +
                "integer value you enter is even or odd");
            Console.Write("Enter an integer value: ");

            // read user integer input
            int userInt = int.Parse(Console.ReadLine());

            // use modulus operator to figure out if int is even or odd
            // if remainder of modulus operation is 0, int is even.
            if (userInt % 2 == 0)
            {
                Console.WriteLine("Your integer was even!");
            }
            else
            {
                Console.WriteLine("Your integer was odd!");
            }
        }
    }
}
