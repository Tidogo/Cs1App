// 1/23/2021           Timothy Goddard              Initial creation with full functionality
// 1/23/2021           Timothy Goddard              Comments added

using System;

namespace CarPool
{
    // this class contains all code for carpool project
    class Program
    {
        // this main method displays info about the carpool application to user,
        // recieves input from user and uses that input to calculate a daily drive
        // cost to user along with an advertisement for the benefits of carpooling
        static void Main(string[] args)
        {
            // carpooling resources: 
            // https://www.moneycrashers.com/carpooling-benefits/
            // https://blog.taxact.com/how-to-save-from-carpooling-benefits/
            // https://www.edmunds.com/driving-tips/commuter-carpools-save-time-money-and-stress.html
            // https://rideshare.org/question/how-much-will-i-save-by-carpooling/


            // display the purpose of the program
            Console.WriteLine("Hello user! This program's purpose is to calculate your daily " +
                "driving cost and show how much you could save by carpooling.");
            
            // these 10 lines of code get the required info from user to calculate daily driving cost
            // input is stored in double for calculation purposes
            Console.Write("How many miles do you drive per day? ");
            double milesPerDay = double.Parse(Console.ReadLine());
            Console.Write("How much do you pay per gallon of gas (in cents)? ");
            double gasCost = double.Parse(Console.ReadLine());
            Console.Write("What is your miles per gallon average? ");
            double milesPerGal = double.Parse(Console.ReadLine());
            Console.Write("What are your parking fees per day (in cents)? ");
            double parkFees = double.Parse(Console.ReadLine());
            Console.Write("What are your tolls per day (in cents)? ");
            double tolls = double.Parse(Console.ReadLine());

            // here the total daily driving cost is calculated using the user input
            double totalCost = tolls + parkFees + ((milesPerDay / milesPerGal) * gasCost);

            // next, the total cost is rounded to produce a whole number to display to user
            // the purpose of midpoint rounding is to accurately round the number for edge cases
            totalCost = Math.Round(totalCost, 0, MidpointRounding.AwayFromZero);

            // finally, display the total cost of daily driving to user and rep ridesharing
            Console.WriteLine("Your daily driving cost is " + totalCost + " cents.");
            Console.WriteLine("According to rideshare.org, just carpooling with" +
                " just one extra person over the course of a year could save you $1,500 in costs." +
                " Consider carpooling, it could save you thousands.");

        }
    }
}
