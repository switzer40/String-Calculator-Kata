using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Calculator
{
    [TestFixture]
    public class CalculatorAddShould
    {
        [Test]
        public void ReturnZeroGivenEmptyInput()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int result = calculator.Add("");

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
