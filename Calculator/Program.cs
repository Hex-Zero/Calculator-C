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

          
          string first = Console.ReadLine();
          string second = Console.ReadLine();

            Console.WriteLine(Program.Add(Int32.Parse(first), Int32.Parse(second)));

            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
             return x + y;
        }
    }
}
