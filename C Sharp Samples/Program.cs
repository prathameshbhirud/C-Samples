using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectAndSelectMany
{
    class Program
    {
        static void Main(string[] args)
        {
            //select
            var result1 = from r in GetStudents()
                          select r;
            foreach (var r in
                result1.Select(Student => Student.Subject))
            {
                Console.WriteLine(r);
            }
            Console.Read();
            // Reteriving using SelectMany
            var result3 = from r in GetStudents()
                          select r;
            foreach (var r in
                result3.SelectMany(Student => Student.Subject))
            {
                Console.WriteLine(r);
            }
            Console.Read();
            Console.ReadLine();
        }

        static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>{
                                     new Student {
                                         Name = "Dhananjay",
                                         RollNumber ="1" ,
                                         Subject= new List<string>{"Math","Phy"}},
                                     new Student {
                                         Name = "Scott",
                                         RollNumber ="2" ,
                                         Subject= new List<string>{"Che","Phy"}},
                                     new Student {
                                         Name = "John",
                                         RollNumber ="3" ,
                                         Subject= new List<string>{"Hindi","Phy"}}};
            return students;
        }
    }

    

    class Student
    {
        public string Name { get; set; }
        public string RollNumber { get; set; }
        public List<string> Subject { get; set; }
    }
}
