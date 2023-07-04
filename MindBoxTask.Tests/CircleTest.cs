using MindBoxTask.Lib;

namespace MindBoxTask.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Square_8_Return_201_062()
        {
            Circle circle = new Circle(8);

            double expected = 201.062;

            double result = circle.CalcArea();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Square_2_Return_12_566()
        {
            Circle circle = new Circle(2);

            double expected = 12.566;

            double result = circle.CalcArea();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Square_6_Return_113_097()
        {
            Circle circle = new Circle(6);

            double expected = 113.097;

            double result = circle.CalcArea();

            Assert.AreEqual(expected, result);
        }
    }
}