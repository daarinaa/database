using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using cw_7_1;

namespace cw_7_1_tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ConvertToInt_ValidNumber_ReturnsCorrectValue()
        {
            string input = "35135";

            int result = Program.ConvertToInt(input);

            Assert.AreEqual(35135, result);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ConvertToInt_NonNumericInput_ThrowsFormatException()
        {
            string input = "vhg";

            Program.ConvertToInt(input);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void ConvertToInt_TooLargeNumber_ThrowsOverflowException()
        {
            string input = "500000000000";

            Program.ConvertToInt(input);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void ConvertToInt_TooSmallNumber_ThrowsOverflowException()
        {
            string input = "-500000000000";

            Program.ConvertToInt(input);
        }
    }
}
