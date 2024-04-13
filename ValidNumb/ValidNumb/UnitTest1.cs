using Microsoft.VisualStudio.TestTools.UnitTesting;
using Number;
namespace ValidNumb
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int expected = 0;            
            Numb num = new Numb();
            int actual = 1;
            actual = num.rnd();
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual % 2);
        }
    }
}