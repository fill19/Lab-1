using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Lab_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 0;
            double res = Lab_1.Program.fs(x);
            Assert.AreEqual(10, res);
        }
    }
}
