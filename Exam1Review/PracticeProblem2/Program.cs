using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> Menu = new Dictionary<string, double>();
            Menu.Add("ESPRESSO", 2.15);
            Menu.Add("CAPPUCCINO", 4.20);
            Menu.Add("LATTE", 5.00);
            Menu.Add("AMERICANO", 3.55);
            Menu.Add("DRIP", 1.25);

            Dictionary<string, double> Extras = new Dictionary<string, double>();
            Extras.Add("SHOT OF VANILLA", 0.75);
            Extras.Add("SHOT OF EXPRESSO", 0.80);

            string message = Console.ReadLine().ToLower();

            if (message == "hello")
            {
                Console.WriteLine("Welcome to Kevin's Coffee Shop!");
                Console.WriteLine("Here is our menu!");

                foreach (var item in Menu)
                {
                    Console.WriteLine($"{item.Key}: {item.Value.ToString("C2")}");
                }

                string answer = "yes";

                while (answer == "yes" || answer == "y")
                {
                    Console.WriteLine("What would you like to order?");
                    string coffee = Console.ReadLine().ToUpper();

                    LineItem line = new LineItem();

                    foreach (var extra in Extras)
                    {
                        Console.WriteLine($"{extra.Key}: {extra.Value.ToString("C2")}");
                    }

                    Console.WriteLine("Would you like to add an extra shot?");
                    string shotanswer = Console.ReadLine().ToLower();

                    if (shotanswer == "yes" || shotanswer == "y")
                    {
                        Console.WriteLine("What kind of shot? (vanilla, espresso)");
                        string shottype = Console.ReadLine().ToLower();
                        line.Item = $"{coffee} with a shot of {shottype}";
                        line.Price = Menu[coffee] + Extras[shottype];
                    }
                    else
                    {
                        line.Item = $"{coffee}";
                        line.Price = Menu[coffee];
                    }

                    Console.WriteLine("Would you like to make another order?");
                    answer = Console.ReadLine().ToLower();
                }

                foreach(var lineitemprice in LineItem)
                {

                }

            }
            else
            {
                Console.WriteLine("You must say hello to order ;)");
            }

            Console.ReadKey();
        }
    }
}
