using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaxValue;


namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        Program three;
        [TestInitialize]
        public void SetUp()
        {
            three = new Program();
        }
        [TestMethod]
        public void TestingIntFirstValue()
        {
            float first = 17.5f, second = 12.0f, third = 11.5f;
            float expected = first;

            float actual = three.FindMaximumFloat(first, second, third);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestingIntSecondValue()
        {
            float first = 35.2f, second = 45.2f, third = 12.3f;
            float expected = second;

            float actual = three.FindMaximumFloat(first, second, third);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestingIntThirdValue()
        {
            float first = 30.2f, second = 36.7f, third = 55.3f;
            float expected = third;

            float actual = three.FindMaximumFloat(first, second, third);

            Assert.AreEqual(expected, actual);
        }
    }

}
