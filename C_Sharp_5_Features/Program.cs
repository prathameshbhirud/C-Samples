using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Numerics;
using System.Dynamic;

namespace C_Sharp_5_Features
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Parallel ForEach

            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Bilberry");
            fruits.Add("Blackberry");
            fruits.Add("Blackcurrant");
            fruits.Add("Blueberry");
            fruits.Add("Cherry");
            fruits.Add("Coconut");
            fruits.Add("Cranberry");
            fruits.Add("Date");
            fruits.Add("Fig");
            fruits.Add("Grape");
            fruits.Add("Guava");
            fruits.Add("Jack-fruit");
            fruits.Add("Kiwi fruit");
            fruits.Add("Lemon");
            fruits.Add("Lime");
            fruits.Add("Lychee");
            fruits.Add("Mango");
            fruits.Add("Melon");
            fruits.Add("Olive");
            fruits.Add("Orange");
            fruits.Add("Papaya");
            fruits.Add("Plum");
            fruits.Add("Pineapple");
            fruits.Add("Pomegranate");

            Console.WriteLine("Printing list using foreach loop\n");

            var stopWatch = Stopwatch.StartNew();
            foreach (string fruit in fruits)
            {
                Console.WriteLine("Fruit Name: {0}, Thread Id= {1}", fruit, Thread.CurrentThread.ManagedThreadId);
            }
            Console.WriteLine("foreach loop execution time = {0} seconds\n", stopWatch.Elapsed.TotalSeconds);
            Console.WriteLine("Printing list using Parallel.ForEach");


            stopWatch = Stopwatch.StartNew();
            Parallel.ForEach(fruits, fruit =>
            {
                Console.WriteLine("Fruit Name: {0}, Thread Id= {1}", fruit, Thread.CurrentThread.ManagedThreadId);

            }
            );
            Console.WriteLine("Parallel.ForEach() execution time = {0} seconds", stopWatch.Elapsed.TotalSeconds);
            Console.Read();




            //2. BigInteger
            BigInteger obj = new BigInteger(12345678912345678912);
            Console.WriteLine(obj);
            Console.Read();


            //3. Expando Object
            dynamic Person = new ExpandoObject();
            Person.ID = 1001;
            Person.Name = "Princy";
            Person.LastName = "Gupta";

            Console.WriteLine("ID is :" + Person.ID + " , Name is : " + Person.Name + " , and Last Name is : " + Person.LastName);
            Console.Read();



            //4. Named and Optional Parameters
            //Optional
            PrintName("abc", "def");
            Console.WriteLine();
            //Named
            PrintName(b:"def", a:"abc", c:"mno");
            Console.Read();



            //5. Tuple data structure
            Tuple<int, string, bool> tuple = new Tuple<int, string, bool>(1, "abc", true);//eithre this way
            var tupleobj = Tuple.Create(2, "def", false); //or this way to create tuple
            
            string name = tupleobj.Item2;
            int age = tupleobj.Item1;
            bool obj1 = tupleobj.Item3;
        }

        static void PrintName(string a, string b, string c = "xyz")
        {
            Console.WriteLine(a + b + c);
        }
    }
}
