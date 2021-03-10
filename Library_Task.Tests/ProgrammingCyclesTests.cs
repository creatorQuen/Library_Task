using NUnit.Framework;

namespace Library_Task.Tests
{
    public class ProgrammingCyclesTests
    {
        [TestCase(1, 1, 1)]
        [TestCase(0, 0, 1)]
        [TestCase(2, 3, 8)]
        [TestCase(-1, 3, -1)]
        [TestCase(-3, 3, -27)]
        [TestCase(3, -3, 0.037)]
        public void RaisePowerTests(int a, int b, double expected)
        {
            double actual = ProgrammingCycles.RaisePower(a, b);

            Assert.AreEqual(expected, actual, 0.001);
        }


        [TestCase(1000, new int[1] { 0 })]
        [TestCase(0, new int[1] { 0 })]
        [TestCase(-22, new int[1] { 0 })]
        [TestCase(250, new int[] { 250, 500, 750,1000 })]
        [TestCase(40, new int[] { 40, 80, 120, 160, 200, 240, 280, 320, 360, 400, 440, 480, 520, 560, 600, 640, 680, 720, 760, 800, 840, 880, 920, 960, 1000 })]
        public void GetNumberOfDivisionTests(int a, int[] expected)
        {
            int[] actual = ProgrammingCycles.GetNumberOfDivision(a);

            Assert.AreEqual(expected, actual);
        }


    }
}
