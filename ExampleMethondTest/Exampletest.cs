using ExampleLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExampleMethondTest
{
    [TestClass]
    public class ExampleTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool a = ExampleFirstMethond.Calcolo1();
            Assert.AreEqual(true, a);
        }
        public void TestMethod2()
        {
            bool b = ExampleFirstMethond.Calcolo2();
            Assert.AreEqual(true, b);
        }
    }
}
