using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Palindrome;


namespace Palindrome.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void Palindrome()
        {
            //Arrange 
            int n = 1551;
            String expected = "Palindrome";

            //Act 
            string actual = Class1.Palin(n);

            //Assert 
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void Not_a_Palindrome()

        {
            //Arrange 
            int n = 5558;
            String expected = "Not a Palindrome";

            //Act 
            string actual = Class1.Palin(n);

            //Assert 
            Assert.AreEqual(expected, actual);

        }
        
    }
}