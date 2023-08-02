using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;
using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            // create a Calculator object
            var test = new UnitTests();
            //Start Step 3 here:

           
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                var actual = test.Add(num1, num2, num3);
            //Assert
                Assert.Equal(expected, actual);
        }

        private IEnumerable<object> Add(int num1, int num2, int num3)
        {
            throw new NotImplementedException();
        }

        [Theory]
        [InlineData(5,5,0)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var tester = new UnitTests();
            //Act
            var actual = tester.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2,4)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var tester= new UnitTests();
            //Act
            var actual = tester.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20,5,4)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var tester = new UnitTests();
            //Act
            var actual= tester.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
