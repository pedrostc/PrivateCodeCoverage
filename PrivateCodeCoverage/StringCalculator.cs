using System.Linq;

namespace PrivateCodeCoverage
{
    public class StringCalculator
    {
        private const string DEFAULT_SEPARATOR = ",";

        public int Add(string input)
        {
            var calcString = new CalculatorString(input);

            return calcString
                .GetElements()
                .Aggregate(0, (accumulator, item) => accumulator + item);
        }

        internal class CalculatorString
        {
            private readonly string _inputString = "0";
            public CalculatorString(string input)
            {
                if(!string.IsNullOrWhiteSpace(input))
                {
                    _inputString = input;
                }
            }

            private string getSeparator()
            {
                return hasCustomSeparator() ?
                    _inputString.Split('\n')[0].Replace("//", string.Empty) :
                    DEFAULT_SEPARATOR;
            }
            private string getNumbersString()
            {
                return hasCustomSeparator() ?
                     _inputString.Split('\n')[1] :
                     _inputString;
            }

            private bool hasCustomSeparator()
            {
                return _inputString.StartsWith("//");
            }

            public int[] GetElements()
            {
                string separator = getSeparator();
                string numbers = getNumbersString();

                return numbers
                    .Replace("\n", separator)
                    .Split(separator)
                    .Select(item => int.Parse(item))
                    .ToArray();
            }
        }
    }
}
