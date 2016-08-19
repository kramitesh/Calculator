using NUnit.Framework;
using MyCalculator ;
namespace Calculator.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        ICalculator calc;
        [TestFixtureSetUp]
        public void TestSetup()
        {
            //sut = new A();
            
        }
        
        [Test]
        public void ShouldAddTwoNumbers()
        {
           calc = new Add();
           double expectedResult = 14+15;
           double actualResult = calc.Calculate(new CalculatorContext(14, 15));

           Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void ShouldSubstractTwoNumbers()
        {
            calc = new Substract();
            double expectedResult = 30-8 ;
            double actualResult = calc.Calculate(new CalculatorContext(30, 8));

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }
        
        [Test]
        public void ShouldSquareTwoNumbers()
        {

            calc = new Square();
            double expectedResult = 36;
            double actualResult = calc.Calculate(new CalculatorContext(6, 0));

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

    }
}
