using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static usage
using static System.Console;

namespace NameOfSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //using nameof keyword
            WriteLine(nameof(Student));
            WriteLine(nameof(Student.Roll));
            WriteLine(nameof(Student.Name));
            WriteLine(nameof(Student.Address));


            //using Null-conditional operator
            Student s1 = new Student { Name = "ABC", Roll=1, Address = new Address { AreaName = "DEF", City = "Mumbai", StreetName= "XYZ" } };
            string xyz = s1?.Name;
            s1 = null;
            string abc = s1?.Name;


            //string interpolation
            int cats = 100;
            int dogs = 2;

            // Create a string with string interpolation syntax.
            string animals = $"cats = {cats} and dogs = {dogs}";
            // Call Console.WriteLine.
            WriteLine(animals);


            // A string interpolation can call a method.
            string result = $"The paw count is {Paws(5)}";
            WriteLine(result);


            ReadLine();
        }

        static int Paws(int cats)
        {
            // Four paws per cat.
            return cats * 4;
        }
        
    }
    class Student
    {
        public int Roll { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
    }

    class Address
    {
        public string StreetName { get; set; }
        public string AreaName { get; set; }
        public string City { get; set; }
    }
}
