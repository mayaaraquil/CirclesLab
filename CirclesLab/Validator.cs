using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclesLab
{
    public class Validator
    {
        public static double GetValidRadiusInput()
        {
            double radius;
            while (true)
            {
                Console.WriteLine("Enter a radius: ");
                if (double.TryParse(Console.ReadLine(), out radius) && radius > 0)
                {
                    return radius;
                }
                Console.WriteLine("Oops, Invalid input. Please enter a positive number.");
            }
        }

        public static bool GetYesNoInput(string message)
        {
            while (true)
            {
                Console.WriteLine(message + "(yes/no)");
                string input = Console.ReadLine();
                if (input == "yes" || input == "no")
                {
                    return input == "yes";
                }
                Console.WriteLine("WRONG. Please enter 'yes' or 'no'. ");
            }
        }
    }
}
