using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in the first number.");
            string first = Console.ReadLine();
            Console.WriteLine("Type in the the operand (Available operations: + - * /).");
            string operation = Console.ReadLine();
            Console.WriteLine("Type in the Second number.");
            string second = Console.ReadLine();

            Console.WriteLine(Program.Calculation(Int32.Parse(first), Int32.Parse(second), operation));

            Console.WriteLine("Type yes/y if you would like to Start again, else just press enter to exit.");
            string endCall = Console.ReadLine();
            if (endCall == "yes" || endCall == "y")
            {
                startAgain();
            }
        }
        static string Calculation(int x, int y, string o)
        {
            if(o == "+"){
                return (x + y).ToString();
            }
            else if (o == "-")
            {
                return (x - y).ToString();
            }
            else if (o == "/")
            {
                return (x / y).ToString();
            }
            else if (o == "*")
            {
                return (x * y).ToString();
            }
            else {
                return "Not a valid operation.";
            }
        }
        static void startAgain()
        {
            Main(null);
        }
    }
}
