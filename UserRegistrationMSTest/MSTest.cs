using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            string firstName = "Prudhvi";

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
            //Arrange
            string firstName = "prudhvi";

            //Act
            bool result = userValidator.ValidateLastName(firstName);

            //Assert
            Assert.IsFalse(result);

        }

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
            //Arrange
            string lastName = "kohli";

            //Act
            bool result = userValidator.ValidateLastName(lastName);

            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Givens the proper email should return true.
        /// </summary>
        [TestMethod]
        public void GivenProperEmail_ShouldReturnTrue()
        {
            //Arrange
            string email = "bprudhvi2028@gmail.com";

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
            //Arrange
            string email = ".bprudhvi2028@gmail.com";

            //Act
            bool result = userValidator.ValidateEmail(email);

            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Givens the proper password should return true.
        /// </summary>
        [TestMethod]
        public void GivenProperPassword_ShouldReturnTrue()
        {
            //Arrange
            string password = "Prudhvi@1bgm89";

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
            //Arrange
            string password = "prudhvi@woqyeoi";

            //Act
            bool result = userValidator.ValidatePassword(password);

            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Givens the proper mobile number should return true.
        /// </summary>
        [TestMethod]
        public void GivenProperMobileNumber_ShouldReturnTrue()
        {
            //Arrange
            string number = "91 7306376547";

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
            //Arrange
            string number = "91 895160495";

            //Act
            bool result = userValidator.ValidateMobileNumber(number);

            //Assert
            Assert.IsFalse(result);
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
