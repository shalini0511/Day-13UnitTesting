using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaxValue;
using System;


namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        []
        SortingClass<int> maxInt;
        SortingClass<float> maxFloat;

        SortingClass<string> maxString;
        [TestInitialize]
        public void SetUp()
        {
            string[] arrString = { "Apple", "Banana", "Peach" };
            maxString = new SortingClass<string>(arrString);
            int[] arrInt = { 12, 13, 15 };
            maxInt = new SortingClass<int>(arrInt);
            float[] arrFloat = { 1.2f, 3.4f, 6.5f };
            maxFloat = new SortingClass<float>(arrFloat);
        }
        [TestMethod]
        public void TestIntMethod()
        {

            int expected = 15;
            int actual = maxInt.MaxMethod();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestFloatMethod()
        {

            float expected = 6.5f;
            float actual = maxFloat.MaxMethod();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestStringMethod()
        {

            string expected = "Peach";
            string actual = maxString.MaxMethod();
            Assert.AreEqual(expected, actual);
        }
    }
}

