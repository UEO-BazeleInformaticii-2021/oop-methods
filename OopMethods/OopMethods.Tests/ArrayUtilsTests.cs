using NUnit.Framework;

namespace OopMethods.Tests
{
    public class ArrayUtilsTests
    {
        
        [Test]
        public void IndexOf_WhenGivenAValidElementWithinArray_ReturnsIndexCorrectly()
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };

            int actualIndex = ArrayUtils.IndexOf(array, 3);

            Assert.AreEqual(2, actualIndex);
        }

        [TestCase(new[] { 1, 2, 3 }, 1, 0)]
        [TestCase(new[] { 1, 2, 3 }, 2, 1)]
        [TestCase(new[] { 1, 2, 3 }, 3, 2)]
        [TestCase(new[] { 1, 2, 3 }, 4, -1)]
        public void IndexOf_ReturnsIndexCorrectly(
            int[] array,
            int element,
            int expectedIndex)
        {
            int actualIndex = ArrayUtils.IndexOf(array, element);

            Assert.AreEqual(expectedIndex, actualIndex);
        }
    }
}