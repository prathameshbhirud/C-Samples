using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Text.RegularExpressions;

namespace DotNet4._5Features
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. async...await
            //Method();
            //Console.WriteLine("Main Thread");
            //Console.ReadLine();



            //2. Zip file
            //System.IO.Compression.GZipStream zipFile = new GZipStream();
            //zipFile.CreateFromDirectory(@"D:\data", @"D:\data.zip");


            //3. Regex TimeOut
            try
            {
                var regEx = new Regex(@"^(\d+)+$", RegexOptions.Singleline, TimeSpan.FromSeconds(10));
                var match = regEx.Match("123453109839109283090492309480329489812093809x");
            }
            catch (RegexMatchTimeoutException ex)
            {
                Console.WriteLine("Regex Timeout");
            }

            //4. Server GC thread enablement
            //  <configuration >
            //      <runtime>
            //          <gcServer enabled = "true" />
            //      </ runtime >
            //  </ configuration >
        }

        public static async void Method()
        {
            await Task.Run(new Action(LongTask));
            Console.WriteLine("New Thread");
        }

        public static void LongTask()
        {
            Thread.Sleep(10000);
        }
    }
}
