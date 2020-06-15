using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            //test.Display(); -- error

            A a = new Test();
            a.Display();

            B b = new Test();
            b.Display();

            Console.ReadKey();
        }
    }

    #region using abtract classes --- Compilation error
    //abstract class A
    //{
    //    public abstract void Display();
    //}

    //abstract class B
    //{
    //    public abstract void Display();
    //}

    //class Test : A, B
    //{
    //    public override void Display()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    #endregion

    #region using Interfaces 

    interface A
    {
        void Display();
    }

    interface B
    {
        void Display();
    }

    class Test : A, B
    {
        void A.Display()
        {
            Console.WriteLine("inside A's display");
        }

        void B.Display()
        {
            Console.WriteLine("inside B's display");
        }
    }

    #endregion
}
