using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    #region Virtual - Override
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        A obj = new B();
    //        obj.Show();
    //        Console.ReadLine();

    //        A obj2 = new A();
    //        obj2.Show();
    //        Console.ReadLine();

    //        B obj3 = new B();
    //        obj3.Show();
    //        Console.ReadLine();
    //    }
    //}
    //class A
    //{
    //    public virtual void Show()
    //    {
    //        Console.WriteLine("A.Show()");
    //    }
    //}
    //class B : A
    //{
    //    public override void Show()
    //    {
    //        Console.WriteLine("B.Show()");
    //    }
    //}

    //O/p -> B.Show()     A.Show()   B.Show()

    #endregion

    #region Virtual - New keyword in derived class

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        A obj = new B();
    //        obj.Show();
    //        Console.ReadLine();

    //        A obj2 = new A();
    //        obj2.Show();
    //        Console.ReadLine();

    //        B obj3 = new B();
    //        obj3.Show();
    //        Console.ReadLine();
    //    }
    //}
    //class A
    //{
    //    public virtual void Show()
    //    {
    //        Console.WriteLine("A.Show()");
    //    }
    //}
    //class B : A
    //{
    //    public new void Show()
    //    {
    //        Console.WriteLine("B.Show()");
    //    }
    //}

    //O/p -> A.Show()   A.Show()   B.Show()

    #endregion

    #region Method Hiding

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        A obj = new B();
    //        obj.Show();
    //        Console.ReadLine();

    //        A obj2 = new A();
    //        obj2.Show();
    //        Console.ReadLine();

    //        B obj3 = new B();
    //        obj3.Show();
    //        Console.ReadLine();
    //    }
    //}
    //class A
    //{
    //    public virtual void Show()
    //    {
    //        Console.WriteLine("A.Show()");
    //    }
    //}
    //class B : A
    //{
    //    public void Show()
    //    {
    //        Console.WriteLine("B.Show()");
    //    }
    //}

    //O/p -> A.Show()     A.Show()   B.Show()
    #endregion

    #region Multilevel Inheritance

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        C c = new C();
    //        A a = new A();
    //        a = c;
    //        a.Show();
    //        c.Show();
    //        Console.ReadLine();
    //    }
    //}
    //class A
    //{
    //    public virtual void Show()
    //    {
    //        Console.WriteLine("A.Show()");
    //    }
    //}
    //class B : A
    //{
    //    public new void Show()
    //    {
    //        Console.WriteLine("B.Show()");
    //    }
    //}
    //class C : B
    //{
    //    public new void Show()
    //    {
    //        Console.WriteLine("C.Show()");
    //    }
    //}

    #endregion

    #region Virtual - Override - New

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        C c = new C();
    //        A a = new A();
    //        a = c;
    //        a.Show();
    //        c.Show();
    //        Console.ReadLine();
    //    }
    //}
    //class A
    //{
    //    public virtual void Show()
    //    {
    //        Console.WriteLine("A.Show()");
    //    }
    //}

    //class B : A
    //{
    //    public override void Show()
    //    {
    //        Console.WriteLine("B.Show()");
    //    }
    //}
    //class C : B
    //{
    //    public new void Show()
    //    {
    //        Console.WriteLine("C.Show()");
    //    }
    //}

    #endregion

    #region Multiple Override - Virtual - Override - Override

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        C c = new C();
    //        A a = new A();
    //        a = c;
    //        a.Show();
    //        c.Show();
    //        Console.ReadLine();
    //    }
    //}
    //class A
    //{
    //    public virtual void Show()
    //    {
    //        Console.WriteLine("A.Show()");
    //    }

    //}
    //class B : A
    //{
    //    public override void Show()
    //    {
    //        Console.WriteLine("B.Show()");
    //    }
    //}
    //class C : B
    //{
    //    public override void Show()
    //    {
    //        Console.WriteLine("C.Show()");
    //    }
    //}

    #endregion

    #region Derived - Base relationship in constructors

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        B b = new B(10);
    //        Console.ReadLine();
    //    }
    //}
    //class A
    //{
    //    int i;
    //    public A(int j)
    //    {
    //        i = j;
    //        Console.WriteLine("Base");
    //    }
    //}
    //class B : A
    //{
    //    public B(int j)
    //        : base(j)
    //    {
    //        Console.WriteLine("Derived");
    //    }
    //}


    #endregion

    #region sample test

    //class A
    //{
    //    public virtual void method()
    //    {
    //        Console.WriteLine("A");
    //    }
    //}
    //class B : A
    //{
    //    public override void method()
    //    {
    //        Console.WriteLine("B");
    //    }
    //}
    //class C : B
    //{
    //    public new void method()
    //    {
    //        Console.WriteLine("C");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        A objA = new A();
    //        objA.method();

    //        B objB = new B();
    //        objB.method();

    //        C objC = new C();
    //        objC.method();


    //        //complex calls
    //        objA = new C();
    //        objA.method();

    //        //objB = new B();
    //        //objB.method();

    //        //objC = new C();
    //        //objC.method();

    //        Console.ReadLine();
    //    }
    //}


    #endregion
}
