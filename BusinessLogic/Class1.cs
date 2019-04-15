using System;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }
    }

    namespace Validation
    {
        /// <summary>
        /// A static class with validation helper
        /// methods
        /// </summary>
        public static class Validator
        {
            /// <summary>
            /// Validates for a legal social security number.
            /// Dashes are optional and it's looking for
            /// ###-###-####
            /// </summary>
            /// <param name="input">The SSN to validate. Whitespace is trimmed.</param>
            /// <returns></returns>
            public static bool IsSsn(string input)
            {
                input = input.Trim();

                //123-12-1234
                string pattern = @"\d{3}-?\d{2}-?\d{4}";
                Regex regex = new Regex(pattern);

                return regex.IsMatch(input);

            }
        }
    }
}
