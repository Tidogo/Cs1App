// 1/23/2021           Timothy Goddard              Initial creation with full functionality
// 1/23/2021           Timothy Goddard              Comments added

using System;

namespace DigitParser
{
    // this class contains all code for digitparser project
    class Program
    {
        // this main method displays info about the digitparser application to user, takes
        // input from user, spaces out that input, and then displays that new input back to
        // user
        static void Main(string[] args)
        {
            // this block of code describes the program and instructs the user
            // what they should input into the console. Stores user input.
            Console.WriteLine("Hello, User! This program will take a number");
            Console.WriteLine("consisting of 5 digits and display them spaced out");
            Console.Write("Please enter a number 5 digits in length: ");
            string userNum = Console.ReadLine();

            // spacedNums will store a properly spaced version of the user input
            string spacedNums = string.Empty;

            // the purpose of this for loop is to go through the string entered by user
            // and recreate it as a new, properly spaced string
            for (int i = 0; i < userNum.Length; i++)
            {
                // this 'if' is to check if the last index is reached. If so,
                // then do not put any spaces after.
                if (i == userNum.Length - 1)
                {
                    spacedNums = spacedNums + userNum[i];
                }

                // if 'else' is reached, the final index has not been reached
                // this means spaces must be added after the number
                else
                {
                    spacedNums = spacedNums + userNum[i] + "   ";
                }
            }
            Console.WriteLine("Your spaced numbers: " + spacedNums);

        }
    }
}
