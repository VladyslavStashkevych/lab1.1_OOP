using lab1._1_OOP;
using System;
using System.IO;
using Xunit;

namespace lab1_1_Tests {
    public class Test {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(-1, 4)]
        [InlineData(4, 2.5)]
        [InlineData(2.5, 0)]
        public void Method_Power_ReturnsCorrectValue(double number, double power) {
            //Arrange
            double result = Math.Pow(number, power);

            //Act
            FloatPower temp = new FloatPower();
            temp.Init(number, power);
            double actual = temp.Power();

            //Assert
            Assert.Equal(result, actual);
        }
        [Theory]
        [InlineData(0, 1)]
        public void Method_Init_ReturnsMessageWithZero(double number, double power) {
            //Arrange
            bool result = false;
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            FloatPower temp = new FloatPower();
            bool actual = temp.Init(number, power);

            //Assert
            Assert.Equal(result, actual);
            Assert.Equal("Number should not be zero!\r\n", stringWriter.ToString());
        }
    }
}