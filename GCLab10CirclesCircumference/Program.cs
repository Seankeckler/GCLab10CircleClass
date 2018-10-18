using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab10CirclesCircumference
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Circle> circles = new List<Circle>();
            bool run = true;
            while (run == true) 
            {
                Console.WriteLine("Welcome to the Circle Tester");
                Console.Write("Enter your circle's radius: ");
                double radius;
                double.TryParse(Console.ReadLine(), out radius);
                if (radius > 0)
                {
                    Circle circle = new Circle(radius);
                    circles.Add(circle);
                    Console.WriteLine("The Circumference of your circle is: " + circle.CalculateFormattedCircumference());
                    Console.WriteLine("The Area of your circle is: " + circle.CalculateFormattedArea());
                    run = Continue();
                    if (run == false)
                    {
                        Console.WriteLine("Goodbye, you made {0} circles", circles.Count());
                    }
                }
                else
                {
                    Console.WriteLine("That is not a valid input.");
                }
                
            }
            Console.ReadKey();

        }
        public static bool Continue()
        {
            bool run;
            Console.WriteLine("Continue? y/n");
            string answer = Console.ReadLine();
            answer = answer.ToLower();
            if (answer == "y")
            {
                run = true;
            }
            else if (answer == "n")
            {
                run = false;
            }
            else
            {
                Console.WriteLine("Sorry, I didn't understand that. Try again.");
                run = Continue();
            }
            return run;
        }

    }
}

