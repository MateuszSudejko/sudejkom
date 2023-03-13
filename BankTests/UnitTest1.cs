using Microsoft.VisualStudio.TestTools.UnitTesting;
using stringcalculator;

namespace calcTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string test1 = "";
            StringCalculator calc = new StringCalculator();

            // Act
            double res1 = calc.Calculate(test1);

            // Assert
            Assert.AreEqual(res1, 0, 0.001, "Incorrect output");
        }
        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            string test1 = "100";
            StringCalculator calc = new StringCalculator();

            // Act
            double res1 = calc.Calculate(test1);

            // Assert
            Assert.AreEqual(res1, 100, 0.001, "Incorrect output");
        }
        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            string test1 = "100,200";
            StringCalculator calc = new StringCalculator();

            // Act
            double res1 = calc.Calculate(test1);

            // Assert
            Assert.AreEqual(res1, 300, 0.001, "Incorrect output");
        }
        [TestMethod]
        public void TestMethod4()
        {
            // Arrange
            string test1 = "100\n200";
            StringCalculator calc = new StringCalculator();

            // Act
            double res1 = calc.Calculate(test1);

            // Assert
            Assert.AreEqual(res1, 300, 0.001, "Incorrect output");
        }

        [TestMethod]
        public void TestMethod5()
        {
            // Arrange
            string test1 = "100\n200,300";
            StringCalculator calc = new StringCalculator();

            // Act
            double res1 = calc.Calculate(test1);

            // Assert
            Assert.AreEqual(res1, 600, 0.001, "Incorrect output");
        }
        [TestMethod]
        public void TestMethod6()
        {
            // Arrange
            string test1 = "-100";
            StringCalculator calc = new StringCalculator();

            // Act
            double res1 = calc.Calculate(test1);

            // Assert
            Assert.AreEqual(res1, -1, 0.001, "Incorrect output");
        }
    }
}
