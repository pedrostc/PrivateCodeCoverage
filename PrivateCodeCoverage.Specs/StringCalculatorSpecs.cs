using Xunit;

namespace PrivateCodeCoverage.Specs
{
    public class StringCalculatorSpecs
    {
        [Fact]
        public void Add_EmptyString_Return0()
        {
            StringCalculator calculator = new StringCalculator();
            int actual = calculator.Add("");

            Assert.Equal(0, actual);
        }

        [Fact]
        public void Add_StringWithSingleNumber_ReturnsParsedNumber()
        {
            StringCalculator calculator = new StringCalculator();
            int actual = calculator.Add("42");

            Assert.Equal(42, actual);
        }

        [Fact]
        public void Add_TwoCommaSeparatedNumbers_ReturnsTheSum()
        {
            StringCalculator calculator = new StringCalculator();
            int actual = calculator.Add("42,1");

            Assert.Equal(43, actual);
        }

        [Fact]
        public void Add_AnyNumberOfCommaSeparatedNumbers_ReturnsTheSum()
        {
            StringCalculator calculator = new StringCalculator();
            int actual = calculator.Add("42,5,2,3");

            Assert.Equal(52, actual);
        }

        [Fact]
        public void Add_AnyNumberOfCommaOrNewLineSeparatedNumbers_ReturnsTheSum()
        {
            StringCalculator calculator = new StringCalculator();
            int actual = calculator.Add("42\n5,2\n3");

            Assert.Equal(52, actual);
        }

        [Fact]
        public void Add_NNumbersUsingCustomSeparator_ReturnsTheSum()
        {
            //Custom Separator - //[separator]\n[numbers] - //;\n1;2;3
            StringCalculator calculator = new StringCalculator();
            int actual = calculator.Add("//;\n42;5;2;3");

            Assert.Equal(52, actual);
        }
    }
}
