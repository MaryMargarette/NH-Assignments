using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics.Tests
{
    [TestClass()]
    public class AlgebraTests
    {
        [TestMethod()]
        public void Factorial_zero_Test()
        {
            //Arrange
            int n = 0;
            int expected = 1;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Factorial_0_to_7_Test()
        {
            //Arrange
            int n = 6;
            int expected = 720;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Factorial_negative_Test()
        {
            //Arrange
            int n = -5;
            int expected =-9999 ;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Factorial_greater_than_seven_Test()
        {
            //Arrange
            int n = 9;
            int expected = -999;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}