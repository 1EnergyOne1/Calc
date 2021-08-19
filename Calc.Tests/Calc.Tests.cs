using NUnit.Framework;
using Calc;


namespace Calc.Tests
{
    
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var MainWindow = new MainWindow();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}