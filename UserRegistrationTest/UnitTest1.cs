using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProject;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool expected = true;
            var regexName = "^[A-Z][a-z]{2,18}$";
            var regexEmailID = "^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*[@][0-9a-zA-Z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
            var regexMobile = "^[1-9]{1}[0-9]{1,2}[ ]{1}[6-9]{1}[0-9]{9}$";
            var regexPassword = "(?=.*?[._+-@#&*$])(?=.*[A-Z])(?=.*[0-9])([0-9a-zA-z]{7,})";
            string firstName = "Virat";
            string lastName = "Kohli";
            string emailID = "virat.kholi@co.in";
            string mobileNum = "91 9876784520";
            string password = "ViratKohli@123";
            Validate validate = new Validate();
            Assert.AreEqual(expected, validate.checkIfValid(regexName, firstName));
            Assert.AreEqual(expected, validate.checkIfValid(regexName, lastName));
            Assert.AreEqual(expected, validate.checkIfValid(regexEmailID, emailID));
            Assert.AreEqual(expected, validate.checkIfValid(regexMobile, mobileNum));
            Assert.AreEqual(expected, validate.checkIfValid(regexPassword, password));
        }
    }
}
