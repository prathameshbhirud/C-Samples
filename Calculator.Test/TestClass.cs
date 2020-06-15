using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Calculator.Test
{
    [TestFixture]
    public class TestClass
    {
        //Unit test of primitive data types
        [TestCase]
        public void AddTest()
        {
            MathsHelper helper = new MathsHelper();
            int result = helper.Add(10, 20);
            Assert.AreEqual(30, result);
        }

        [TestCase]
        public void SubtractTest()
        {
            MathsHelper helper = new MathsHelper();
            int result = helper.Subtract(20, 10);
            Assert.AreEqual(10, result);
        }


        //Unit test of complex objects
        [TestCase]
        public void CompareObjects()
        {
            var js = new JavaScriptSerializer();
            
            Student s1 = new Student { StudId = 1, StudNme = "ABC" };
            Student s2 = new Student { StudId = 1, StudNme = "ABC" };

            //Assert.AreEqual(s1, s2);
            Assert.AreEqual(js.Serialize(s1), js.Serialize(s2));
        }
        
    }

    class Student
    {
        public int StudId { get; set; }
        public string StudNme { get; set; }
    }
}
