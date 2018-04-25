using System;

namespace ConsoleApp7_gc
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string input;
            decimal area, Perimeter, x, y;


            //bool user = true;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to Grand circus\' Detail Genrator ");
            Console.Beep(120, 5000);
            //process

            while (true)
            {
                Console.ResetColor();
                Console.Write("Enter Length ");
                x = decimal.Parse(Console.ReadLine());

                Console.Write("Enter Width  ");
                y = decimal.Parse(Console.ReadLine());

                //process
                area = x * y;
                Perimeter = 2 * (x + y);

                //output
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter:" + Perimeter);



                Console.WriteLine("whould you like to continue (y/n)");
                input = Console.ReadLine();

                if (input.ToLower() == "n")
                {
                    Console.WriteLine("See you later cuz you typn {0} ", input);
                    break;
                }

            }

        }
    }
}
