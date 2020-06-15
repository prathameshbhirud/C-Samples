using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByValueAndCallByRef
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating the object of employee class first and implementing the call by value concept.
            String m = "sunil";
            employee emp = new employee();
            emp.display(200, m);
            Console.WriteLine("value in variable m is" + " " + m);
            Console.ReadLine();

            //creating the object of employee class first and implementing the call by Reference concept 
            string msg = "Hello";
            student st = new student();
            st.show(ref msg);
            Console.WriteLine("value in msg is" + " " + msg);//value at address msg will  be print,because here address is copy not value thatswhy at same address value will be print 
            Console.ReadLine();
        }
    }

    public class employee
    {
        public void display(int a, String b)
        {
            Console.WriteLine("Integer value is" + " " + a);
            Console.WriteLine(" String value is" + " " + b);
            Console.ReadLine();
        }

    }
    public class student
    {
        public void show(ref String str)
        {
            Console.WriteLine("Enter the value");
            string s = Console.ReadLine();
            str = str + s;
            Console.WriteLine("value in str variable is" + " " + str);
            Console.ReadLine();
        }

        public void show(String str)
        {
            Console.WriteLine("Enter the value");
            string s = Console.ReadLine();
            str = str + s;
            Console.WriteLine("value in str variable is" + " " + str);
            Console.ReadLine();
        }

    }
}
