using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Calculator

{
    class Program
    {

        static void Main(string[] args)
        {


            //void FizzBuzz(int end , int start)
            //{
            //    int i = start;
            //    string result = "";
            //    if(i <= end)
            //    {
            //        if (i % 3 == 0)
            //        {
            //            result += "Fizz";
            //        }
            //        if (i % 5 == 0)
            //        {
            //            result += "Bizz";
            //        }
            //        if(result == "")
            //        {
            //            result = i.ToString();
            //        }
            //        Console.WriteLine(result);
            //        i++;
            //        FizzBuzz(end, i);
            //    }
            //}

            //FizzBuzz(9161, 1);

            string result = "";
            for (int i = 1; i < 9161; i++)
            {
                if (i % 3 == 0)
                {
                    result += "Fizz";
                }
                if (i % 5 == 0)
                {
                    result += "Buzz";
                }
                if (i % 7 == 0)
                {
                    result += "Ruzz";
                }
                if (result == "")
                {
                    result = i.ToString();
                }
                Console.WriteLine(result);
                result = "";

            }
            Console.ReadLine();
        }


        //public enum ProductCodes
        //{
        //    Milk = 0,
        //    Juice = 1,
        //    Tea = 2
        //}
        //static void Main(string[] args)
        //{
        //    Console.WriteLine((ProductCodes)1);

        //    ProductCodes getParse;
        //    bool checkParse = Enum.TryParse("Tea", out getParse);
        //    Console.WriteLine((int)getParse);
        //    Console.ReadLine();

        //}



        //    static void Main(string[] args)
        //    {
        //        Console.WriteLine("Type in the first number.");
        //        string first = Console.ReadLine();
        //        Console.WriteLine("Type in the the operand (Available operations: + - * /).");
        //        string operation = Console.ReadLine();
        //        Console.WriteLine("Type in the Second number.");
        //        string second = Console.ReadLine();

        //        Console.WriteLine(Program.Calculation(Int32.Parse(first), Int32.Parse(second), operation));

        //        Console.WriteLine("Type yes/y if you would like to Start again, else just press enter to exit.");
        //        string endCall = Console.ReadLine();
        //        if (endCall == "yes" || endCall == "y")
        //        {
        //            startAgain();
        //        }
        //    }
        //    static string Calculation(int x, int y, string o)
        //    {
        //        if(o == "+"){
        //            return (x + y).ToString();
        //        }
        //        else if (o == "-")
        //        {
        //            return (x - y).ToString();
        //        }
        //        else if (o == "/")
        //        {
        //            return (x / y).ToString();
        //        }
        //        else if (o == "*")
        //        {
        //            return (x * y).ToString();
        //        }
        //        else {
        //            return "Not a valid operation.";
        //        }
        //    }
        //    static void startAgain()
        //    {
        //        Main(null);
        //    }
    }
}
