using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantReadOnlyStatic
{
    class Program
    {
        //read-only
        readonly int i;
        static void Main(string[] args)
        {
            //constant
            const int a = 10;

            Console.WriteLine(a);
            
            //part of Readonly
            Program p = new Program(20);
            Console.ReadKey();



            //static
            Variable var = new Variable();
            var.test();
            Variable var1 = new Variable();
            var1.test();
        }

        public static void disp(int a)
        {
            Console.WriteLine(a);
        }

        public Program()
        {
            i = 11;
            Console.WriteLine(i);
        }

        public Program(int b)
        {
            i = b;
            Console.WriteLine(i);
        }
    }

    public class Variable
    {
        public static int i = 5;
        public void test()
        {
            i = i + 5;
            Console.WriteLine(i);
        }
    }
}
