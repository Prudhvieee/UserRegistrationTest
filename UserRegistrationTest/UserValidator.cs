using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace UserRegistrationTest
{
    public class UserValidator
    {
        //Constants
        public const string REGEX_NAME = "^[A-Z][a-zA-Z]{2,}";
        /// <summary>
        /// Validates the last name.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        /// <returns></returns>
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, REGEX_NAME);
        }
    }
}
