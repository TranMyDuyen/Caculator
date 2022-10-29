using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using caculator;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation cal;
        [TestInitialize]
        public void Setup()
        {
            cal = new Calculation(10, 5);
        }
        [TestMethod]
        public void Test_Cong()
        {
            Assert.AreEqual(cal.Execute("+"), 15);
        }
        [TestMethod]
        public void Test_Tru()
        {
            Assert.AreEqual(cal.Execute("-"), 5);
        }
        [TestMethod]
        public void Test_Nhan()
        {
            Assert.AreEqual(cal.Execute("*"), 50);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_Chia()
        {
            Calculation c = new Calculation(10, 0);
            c.Execute("/");
        }
        [TestMethod]
        public void Text_LamTron()
        {

            Assert.AreEqual(cal.Execute("/"), 2);
        }

        //lk testdata vs project
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"D:\1. Mon\kt\BTH\MT\Calculator\CalculatorTester\Data\TextData.csv", "TextData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            String operation = TestContext.DataRow[2].ToString();
            operation = operation.Remove(0, 1);
            int expected = int.Parse(TestContext.DataRow[3].ToString());
            Calculation c = new Calculation(a, b);
            int actual = c.Execute(operation);
            Assert.AreEqual(expected, actual);
        }
    }
}
