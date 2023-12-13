using AnotherProject;
using Moq;
using NUnit.Framework;
using System.Runtime.CompilerServices;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestProject1
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        [TestCase(10, 30, 40)]
        [TestCase(100, 12, 112)]
        [TestCase(1, 1, 2)]
        public void CheckSum(int x1, int x2, int res)
        {
            //Arrage 
            var calculator = new Calculator();
            //Act 
            var result = calculator.Sum(x1, x2);
            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(res, result);
        }
        [Test]
        [TestCase(30, 20, 10)]
        [TestCase(100, 12, 88)]
        [TestCase(4, 2, 2)]
        public void CheckSubstract(int x1, int x2, int res)
        {
            //Arrage 
            var calculator = new Calculator();
            //Act 
            var result = calculator.Substract(x1, x2);
            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(res, result);
        }
        [Test]
        [TestCase(2, 30, 60)]
        [TestCase(100, 12, 1200)]
        [TestCase(4, 2, 8)]
        public void CheckMultiply(int x1, int x2, int res)
        {
            //Arrage 
            var calculator = new Calculator();
            //Act 
            var result = calculator.Multiply(x1, x2);
            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(res, result);
        }
        [Test]
        [TestCase(5, 10, false)]
        [TestCase(10, 8, true)]
        public void CheckCompareSimple(int x1, int x2, bool res)
        {
            //Arrage 
            var calculator = new Calculator();
            //Act 
            var result = calculator.CompareSimple(x1, x2);
            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(res, result);
        }
        [Test]
        [TestCase(3, 2, true)]
        [TestCase(1, 1, false)]
        public void CheckCompare(int i1, int i2, bool res)
        {
            //Arrage 
            var calculator = new Calculator();
            //Act 
            var result = calculator.Compare(i1, i2);
            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(res, result);
        }
        [Test]
        public void VerifyCallSumFractions()
        {
            //Arrage 
            var mockFraction = new Mock<Fractions>();
            var calculator = new Calculator(mockFraction.Object);
            //Act 
            calculator.SumFractions(1,2,3,4);
            //Assert
            mockFraction.Verify(x => x.SumFractions(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>()));
        }
        [Test]
        [TestCase(1,2,3,4,"10/12")]
        public void SumFractions(int x1, int x2, int y1, int y2, string res)
        {
            //Arrage 
            var calculator = new Calculator();
            //Act
            var result = calculator.SumFractions(x1,x2,y1,y2);
            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(res, result);
        }
        



    }
}