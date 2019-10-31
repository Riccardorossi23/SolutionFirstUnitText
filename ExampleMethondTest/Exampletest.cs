using ExampleLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExampleMethondTest
{
    [TestClass]
    public class ExampleTest
    {
        [TestMethod]
        public void Calcolo1()
        {
            bool a = ExampleFirstMethond.Calcolo1();
            Assert.AreEqual(false, a);
        }
        public void Calcolo2()
        {
            bool b = ExampleFirstMethond.Calcolo2();
            Assert.AreEqual(true, b);
        }
    }
}
