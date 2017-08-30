using NUnit.Framework;
using StringCalculatorKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata.Tests
{
    [TestFixture]
    public class StringCalcuatorKataTests
    {
        [Test]
        public void Add_GivenEmptyString_ShouldReturnZero()
        {
            //Arrange
            var input = "";
            var expected = 0;
            var sut = new StringCalculator();
            //Act
            var result = sut.Add(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenStringOne_ShouldReturnOne()
        {
            //Arrange
            var input = "1";
            var expected = 1;
            var sut = new StringCalculator();
            //Act
            var result = sut.Add(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenStringTwo_ShouldReturnTwo()
        {
            //Arrange
            var input = "2";
            var expected = 2;
            var sut = new StringCalculator();
            //Act
            var result = sut.Add(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenStringThree_ShouldReturnThree()
        {
            //Arrange
            var input = "3";
            var expected = 3;
            var sut = new StringCalculator();
            //Act
            var result = sut.Add(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenStringTwoNumbersSeparetedByComma_ShouldReturnSum()
        {
            //Arrange
            var input = "1,2";
            var expected = 3;
            var sut = new StringCalculator();
            //Act
            var result = sut.Add(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenStringThreeNumbersSeparetedByComma_ShouldReturnSum()
        {
            //Arrange
            var input = "1,2,3";
            var expected = 6;
            var sut = new StringCalculator();
            //Act
            var result = sut.Add(input);
            //Assert
            Assert.AreEqual(expected, result);
        }


        [Test]
        public void Add_GivenStringThreeNumbersSeparetedByCommaAndlines_ShouldReturnSum()
        {
            //Arrange
            var input = "1\n2,3";
            var expected = 6;
            var sut = new StringCalculator();
            //Act
            var result = sut.Add(input);
            //Assert
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void Add_GivenStringChangingDelimeter()
        {
            //Arrange
            var input = "//;\n1;2";
            var expected = 3;
            var sut = new StringCalculator();
            //Act
            var result = sut.Add(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenNegativeNumbersInStringShouldThrowNegativesNotAllowedException()
        {
            //Arrange
            var input = "-2,3";
            var sut = new StringCalculator();
            //Assert
            Assert.Throws<NegativesNotAllowedException>(() => sut.Add(input));
        }
    }  
}