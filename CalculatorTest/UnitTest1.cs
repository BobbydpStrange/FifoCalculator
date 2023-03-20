using Calculator;
namespace CalculatorTest
{
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {
        }

        private Array[] array = new Array[10];
        [Test]
        public void canCreateArray()
        {
            bool empty = FiFoCalculator.isEmpty(array);
            Assert.IsTrue(empty);
            
        }
        [Test]
        public void canPush_isNotEmpty()
        {
            array = FiFoCalculator.push(0, array);
            bool empty = FiFoCalculator.isEmpty(array);
            Assert.IsFalse(empty);
        }
        [Test]
        public void canPull_isEmptyWithEmptyArray()
        {
            array = FiFoCalculator.pull(array);
            bool empty = FiFoCalculator.isEmpty(array);
            Assert.IsTrue(empty);
        }
        [Test]
        public void canPull_WithNotEmptyArray()
        {

            array = FiFoCalculator.push(1, array);
            int index = array.Length;
            array = FiFoCalculator.pull(array);
            bool empty = FiFoCalculator.isEmpty(array);
            Assert.IsTrue(empty);
        }
    }
}