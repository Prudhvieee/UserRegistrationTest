using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationTest;

namespace UserRegistrationMSTest
{
    [TestClass]
    public class MSTest
    {
        UserRegistrationTest.UserValidator userValidator = new UserRegistrationTest.UserValidator();
        /// <summary>
        /// Givens the proper first name should return true.
        /// </summary>
        [TestMethod]
        public void GivenProperFirstName_ShouldReturnTrue()
        {
            //Arrange
            string firstName = "Chetan";

            //Act
            bool result = userValidator.ValidateFirstName(firstName);

            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Givens the improper first name should return false.
        /// </summary>
        [TestMethod]
        public void GivenImproperFirstName_ShouldReturnFalse()
        {
            try
            {
                //Arrange
                string firstName = "chetan";

                //Act
                bool result = userValidator.ValidateLastName(firstName);
            }
            catch (UserRegisterationCustomException exception)
            {
                Assert.AreEqual("Invalid First Name", exception.Message);
            }

        }

        /// <summary>
        /// <summary>
        /// Givens the proper last name should return true.
        /// </summary>
        [TestMethod]
        public void GivenProperLastName_ShouldReturnTrue()
        {
            //Arrange
            string lastName = "Kohli";

            //Act
            bool result = userValidator.ValidateLastName(lastName);

            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Givens the improper last name should return false.
        /// </summary>
        [TestMethod]
        public void GivenImproperLastName_ShouldReturnFalse()
        {
            try
            {
                //Arrange
                string lastName = "kohli";

                //Act
                bool result = userValidator.ValidateLastName(lastName);
            }

            catch (UserRegisterationCustomException exception)
            {
                Assert.AreEqual("Invalid Last Name", exception.Message);
            }

        }
        /// <summary>
        /// Givens the proper email should return true.
        /// </summary>
        [TestMethod]
        public void GivenProperEmail_ShouldReturnTrue()
        {
            //Arrange
            string email = "bmchetan2028@gmail.com";

            //Act
            bool result = userValidator.ValidateEmail(email);

            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Givens the improper email should return false.
        /// </summary>
        [TestMethod]
        public void GivenImproperEmail_ShouldReturnFalse()
        {
            try
            {
                //Arrange
                string email = ".bmchetan2028@gmail.com";

                //Act
                bool result = userValidator.ValidateEmail(email);
            }
            catch (UserRegisterationCustomException exception)
            {
                Assert.AreEqual("Invalid Email", exception.Message);
            }
        }
        /// <summary>
        /// Givens the proper password should return true.
        /// </summary>
        [TestMethod]
        public void GivenProperPassword_ShouldReturnTrue()
        {
            //Arrange
            string password = "Akbar@1bgm89";

            //Act
            bool result = userValidator.ValidatePassword(password);

            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Givens the improper password should return false.
        /// </summary>
        [TestMethod]
        public void GivenImproperPassword_ShouldReturnFalse()
        {
            try
            {
                //Arrange
                string password = "akbar@woqyeoi";

                //Act
                bool result = userValidator.ValidatePassword(password);
            }
            catch (UserRegisterationCustomException exception)
            {
                Assert.AreEqual("Invalid Password", exception.Message);
            }

        }
        /// <summary>
        /// Givens the proper mobile number should return true.
        /// </summary>
        [TestMethod]
        public void GivenProperMobileNumber_ShouldReturnTrue()
        {
            //Arrange
            string number = "91 8951604950";

            //Act
            bool result = userValidator.ValidateMobileNumber(number);

            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Givens the improper mobile number should return false.
        /// </summary>
        [TestMethod]
        public void GivenImproperMobileNumber_ShouldReturnFalse()
        {
            try
            {
                //Arrange
                string number = "91 895160495";

                //Act
                bool result = userValidator.ValidateMobileNumber(number);
            }
            catch (UserRegisterationCustomException exception)
            {
                Assert.AreEqual("Invalid Mobile Number", exception.Message);
            }
        }

        /// <summary>
        /// Givens the proper sample emails should return true.
        /// </summary>
        /// <param name="email">The email.</param>
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void GivenProperSampleEmails_ShouldReturnTrue(string email)
        {
            //Act
            bool result = userValidator.ValidateEmail(email);

            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Givens the proper sample emails should return true.
        /// </summary>
        /// <param name="email">The email.</param>
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void GivenProperSampleEmails_ShouldReturnTrue(string email)
        {
            //Act
            bool result = userValidator.ValidateEmail(email);

            //Assert
            Assert.IsTrue(result);
        }
    }
}
