using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "yes";
            List<string> Results = new List<string>();


            while (answer == "yes" || answer == "y")
            {

                Console.WriteLine("What is your left input?");
                double left = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What is your right input?");
                double right = Convert.ToDouble(Console.ReadLine());

                Equation newEquation = new Equation(left, right);

                Console.WriteLine("What type of calculation would you like to run? (+, -, *, power)");
                string calc = Console.ReadLine().ToLower();

                if (calc == "+")
                {
                    Results.Add($"{newEquation.Left} {calc} {newEquation.Right} = {newEquation.Add()}");
                }
                else if (calc == "-")
                {
                    Results.Add($"{newEquation.Left} {calc} {newEquation.Right} = {newEquation.Subtract()}");
                }
                else if (calc == "*")
                {
                    Results.Add($"{newEquation.Left} {calc} {newEquation.Right} = {newEquation.Multiply()}");
                }
                else if (calc == "power")
                {
                    Console.WriteLine("Power to the Left or Right input? (left, right)");
                    string direction = Console.ReadLine().ToLower();

                    Console.WriteLine($"You want to calculate the {direction} input to what power?");
                    int power = Convert.ToInt32(Console.ReadLine());

                    if (direction == "left")
                    {
                        Results.Add($"{newEquation.Left} to the power of {power} is {newEquation.LeftToThePower(power)}");
                    }
                    else if (direction == "right")
                    {
                        Results.Add($"{newEquation.Right} to the power of {power} is {newEquation.RightToThePower(power)}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Please try again.");
                }

                Console.WriteLine("Would you like to run another equation?");
                answer = Console.ReadLine().ToLower();

            }

            foreach (var result in Results)
            {
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
