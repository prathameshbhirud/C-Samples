using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarVsDynamicKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;

            dynamic b = 10;

            Console.WriteLine("Value of a is :" + a);
            Console.WriteLine("Value of b is :" + b);
            Console.ReadLine();
        }
    }
}
