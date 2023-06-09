using Microsoft.VisualStudio.TestTools.UnitTesting;
using EasySolutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySolutions.Tests
{
    [TestClass()]
    public class RomanToIntegerTests
    {
        /// <summary>
        /// Testing for "III"
        /// Expected result: int = 3
        /// </summary>
        [TestMethod()]
        public void RomanToIntTest1()
        {
            // Arrange
            string romanNumerals = "III";
            int expected = 3;

            // Act
            int actual = RomanToInteger.RomanToInt(romanNumerals);

            // Asset

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Testing for "MCMXCIV"
        /// Expected result: int = 1994
        /// </summary>
        [TestMethod()]
        public void RomanToIntTest2()
        {
            // Arrange
            string romanNumerals = "MCMXCIV";
            int expected = 1994;

            // Act
            int actual = RomanToInteger.RomanToInt(romanNumerals);

            // Asset

            Assert.AreEqual(expected, actual);
        }
    }
}