// 1/23/2021           Timothy Goddard              Initial creation with full functionality
// 1/23/2021           Timothy Goddard              Comments added

using System;

namespace BodyMass
{
    // this class contains all the code for the bodymass project
    class Program
    {
        // this main method displays the purpose of the BMI console application to user,
        // calculates bmi from user input and display that back to user along with
        // a table of bmi ranges
        static void Main(string[] args)
        {
            // this block of code displays purpose of progam and describes how to use it
            Console.WriteLine("This program will calculate your BMI using weight in pounds and" +
                "height in inches");

            // the purpose of this block of code is to take user input for BMI calculation
            Console.Write("Please enter your weight in pounds: ");
            double userWeight = double.Parse(Console.ReadLine());
            Console.Write("Please enter your height in inches: ");
            double userHeight = double.Parse(Console.ReadLine());

            // here is where the BMI is calculated using imperial measurements
            double bMI = (userWeight * 703) / (userHeight * userHeight);

            // this block of code displays the bmi of the user and then a list
            // of bmi categories with their respective bmi ranges
            Console.WriteLine("Your BMI is: " + bMI);
            Console.WriteLine();
            Console.WriteLine("BMI VALUES");
            Console.WriteLine();
            Console.WriteLine("Underweight: less than 18.5");
            Console.WriteLine("Normal: between 18.5 and 24.9");
            Console.WriteLine("Overweight: between 25 and 29.9");
            Console.WriteLine("Obese: 30 or greater");


        }
    }
}
