using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace MultiThreading
{
    class Program
    {
        //single thread

        //static void Main(string[] args)
        //{
        //    Thread th = Thread.CurrentThread;
        //    th.Name = "MainThread";
        //    WriteLine("This is {0}", th.Name);
        //    ReadKey();
        //}


        //multiple threads

        //public static void CallToChildThread()
        //{
        //    WriteLine("Child thread starts");
        //}

        //static void Main(string[] args)
        //{
        //    ThreadStart childref = new ThreadStart(CallToChildThread);
        //    WriteLine("In Main: Creating the Child thread");
        //    Thread childThread = new Thread(childref);
        //    childThread.Start();
        //    ReadKey();
        //}



        //Sleep

        //public static void CallToChildThread()
        //{
        //    Console.WriteLine("Child thread starts");

        //    // the thread is paused for 5000 milliseconds
        //    int sleepfor = 5000;

        //    Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);
        //    Thread.Sleep(sleepfor);
        //    Console.WriteLine("Child thread resumes");
        //}

        //static void Main(string[] args)
        //{
        //    ThreadStart childref = new ThreadStart(CallToChildThread);
        //    Console.WriteLine("In Main: Creating the Child thread");
        //    Thread childThread = new Thread(childref);
        //    childThread.Start();
        //    Console.ReadKey();
        //}




        //Multi-threading
        static void Main(string[] args)
        {
            Program p = new Program();
            // construct two threads for our demonstration;
            Thread thread1 = new Thread(new ThreadStart(p.DisplayThread1));
            Thread thread2 = new Thread(new ThreadStart(p.DisplayThread2));

            // start them
            thread1.Start();
            thread2.Start();
        }


        // shared memory variable between the two threads
        // used to indicate which thread we are in
        private string _threadOutput = "";

        /// <summary>
        /// Thread 1: Loop continuously,
        /// Thread 1: Displays that we are in thread 1
        /// </summary>
        void DisplayThread1()
        {
            while (true)
            {
                //comment this to see unexpected out in console
                lock (this)
                {
                    Console.WriteLine("Display Thread 1");

                    // Assign the shared memory to a message about thread #1
                    _threadOutput = "Hello Thread1";


                    Thread.Sleep(1000);  // simulate a lot of processing 

                    // tell the user what thread we are in thread #1, and display shared memory
                    Console.WriteLine("Thread 1 Output --> {0}", _threadOutput);
                }
            }
        }



        /// <summary>
        /// Thread 2: Loop continuously,
        /// Thread 2: Displays that we are in thread 2
        /// </summary>
        void DisplayThread2()
        {
            while (true)
            {
                //comment this to see unexpected out in console
                lock (this)
                {
                    Console.WriteLine("Display Thread 2");


                    // Assign the shared memory to a message about thread #2
                    _threadOutput = "Hello Thread2";


                    Thread.Sleep(1000);  // simulate a lot of processing

                    // tell the user we are in thread #2
                    Console.WriteLine("Thread 2 Output --> {0}", _threadOutput);
                }
            }
        }

    }
}
