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
        public const string REGEX_EMAIL = "^[a-z]{3,}[.][a-z]*[@][a-z]{2}[.][a-z]{2}[.][a-z]*$";
        public const string REGEX_MOBILE_NUMBER = "^[0-9]{2}[ ][0-9]{10}$";
        public const string REGEX_PASSWORD = @"^(?=.*[!@#$%^&*]){1}(?=.*\d)(?=.*[A-Z]).{8,}$";
        /// <summary>
        /// Validates the first name.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <returns></returns>
        public bool ValidateFirstName(string firstName)
        {
            try
            {
                if (Regex.IsMatch(firstName, REGEX_NAME))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new UserRegisterationCustomException(UserRegisterationCustomException.ExceptionType.INVALID_FIRSTNAME, "Invalid First Name");
            }
        }
        
        /// <summary>
        /// Validates the last name.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        /// <returns></returns>
        public bool ValidateLastName(string lastName)
        {
            try
            {
                if (Regex.IsMatch(lastName, REGEX_NAME))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new UserRegisterationCustomException(UserRegisterationCustomException.ExceptionType.INVALID_LASTNAME, "Invalid Last Name");
            }
        }

        /// <summary>
        /// Validates the email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public bool ValidateEmail(string email)
        {
            try
            {
                if (Regex.IsMatch(email, REGEX_EMAIL))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new UserRegisterationCustomException(UserRegisterationCustomException.ExceptionType.INVALID_EMAIL, "Invalid Email");
            }
        }

        /// <summary>
        /// Validates the mobile number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        public bool ValidateMobileNumber(string number)
        {
            try
            {
                if (Regex.IsMatch(number, REGEX_MOBILE_NUMBER))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new UserRegisterationCustomException(UserRegisterationCustomException.ExceptionType.INVALID_MOBILENUMBER, "Invalid Mobile Number");
            }
        }

        /// <summary>
        /// Validates the password.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool ValidatePassword(string password)
        {
            try
            {
                if (Regex.IsMatch(password, REGEX_PASSWORD))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new UserRegisterationCustomException(UserRegisterationCustomException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
            }
        }
    }
}