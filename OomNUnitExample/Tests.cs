using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OomNUnitExample
{
    [TestFixture]
    public class Tests
    {

        private static object[] testCases;

        public Tests()
        {
            testCases = new object[] { 1,2,3 };
        }

        [SetUp]
        public void Setup()
        {
            DbUtil.CreateDb("Test01");
        }

        [TearDown]
        public void TearDown()
        {
            DbUtil.DropDb("Test01");
        }

        [Test]
        [TestCaseSource(nameof(testCases))]
        public void theTest()
        {
            Console.WriteLine("I ran");
        }
        
    }
}
