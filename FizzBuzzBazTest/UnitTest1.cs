using System;
using Xunit;
using FizzBuzzBazz;

namespace FizzBuzzBazTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        [InlineData(8, "8")]
        public void FizzBuzzBazNums(int num, string expected)
        {
            // arrange
            // act
            string actual = FizzBuzzBaz.Output(num);
            // assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        [InlineData(31, "Fizz")]
        [InlineData(129, "Fizz")]
        public void FizzBuzzBaz_Fizz(int num, string expected)
        {
            // arrange
            // act
            string actual = FizzBuzzBaz.Output(num);
            // assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        [InlineData(20, "Buzz")]
        [InlineData(25, "Buzz")]
        public void FizzBuzzBaz_Buzz(int num, string expected)
        {
            // arrange
            // act
            string actual = FizzBuzzBaz.Output(num);
            // assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(45, "FizzBuzz")]
        public void FizzBuzzBaz_FizzBuzz(int num, string expected)
        {
            // arrange
            // act
            string actual = FizzBuzzBaz.Output(num);
            // assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(7, "Baz")]
        [InlineData(14, "Baz")]
        [InlineData(28, "Baz")]
        public void FizzBuzzBaz_Baz(int num, string expected)
        {
            // arrange
            // act
            string actual = FizzBuzzBaz.Output(num);
            // assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(21, "FizzBaz")]
        public void FizzBuzzBaz_FizzBaz(int num, string expected)
        {
            // arrange
            // act
            string actual = FizzBuzzBaz.Output(num);
            // assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(70, "BuzzBaz")]
        public void FizzBuzzBaz_BuzzBaz(int num, string expected)
        {
            // arrange
            // act
            string actual = FizzBuzzBaz.Output(num);
            // assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(35, "FizzBuzzBaz")]
        [InlineData(105, "FizzBuzzBaz")]
        public void FizzBuzzBaz_FizzBuzzBaz(int num, string expected)
        {
            // arrange
            // act
            string actual = FizzBuzzBaz.Output(num);
            // assert
            Assert.Equal(expected, actual);
        }

    }
}
