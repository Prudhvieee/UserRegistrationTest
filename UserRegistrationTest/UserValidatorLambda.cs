using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationTest
{
    public class UserValidatorLambda
    {
        //Constants
        public const string REGEX_NAME = "^[A-Z][a-zA-Z]{2,}$";
        public const string REGEX_EMAIL = "^[a-z]{3,}[-.+]?[0-9]*[@][a-z0-9]*[.][a-z]*[,]?[.]?[a-z]*$";
        public const string REGEX_MOBILE_NUMBER = "^[0-9]{2}[ ][0-9]{10}$";
        public const string REGEX_PASSWORD = @"^(?=.*[!@#$%^&*]){1}(?=.*\d)(?=.*[A-Z]).{8,}$";

        /// <summary>
        /// Validates the first name.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <returns></returns>
        public bool ValidateFirstName(string firstName) => (Regex.IsMatch(firstName, REGEX_NAME));

        /// <summary>
        /// Validates the last name.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        /// <returns></returns>
        public bool ValidateLastName(string lastName) => (Regex.IsMatch(lastName, REGEX_NAME));

        /// <summary>
        /// Validates the email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public bool ValidateEmail(string email) => (Regex.IsMatch(email, REGEX_EMAIL));

        /// <summary>
        /// Validates the mobile number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        public bool ValidateMobileNumber(string number) => (Regex.IsMatch(number, REGEX_MOBILE_NUMBER));

        /// <summary>
        /// Validates the password.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool ValidatePassword(string password) => (Regex.IsMatch(password, REGEX_PASSWORD));
    }
}
