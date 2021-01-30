using Microsoft.VisualStudio.TestTools.UnitTesting;
using SilverFoxAuth.Models;

namespace SilverFoxTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidateUserName()
        {
            string badLengthUserName = "hellow";
            string badCharUserName = "hellooooow!";
            string goodUserName = "mckinnin";
            UserModel userModel = new UserModel();

            userModel.ValidateUsername(badLengthUserName);
            Assert.IsFalse(userModel.isValidUsername);
            userModel.ValidateUsername(badCharUserName);
            Assert.IsFalse(userModel.isValidUsername);
            userModel.ValidateUsername(goodUserName);
            Assert.IsTrue(userModel.isValidUsername);
        }

        [TestMethod]
        public void ValidatePassword()
        {
            string passwordThatIsToShort = "hellow";
            string goodPassword = "mckinninLloyd12";
            UserModel userModel = new UserModel();

            userModel.ValidatePassword(passwordThatIsToShort);
            Assert.IsFalse(userModel.isValidPassword);
            userModel.ValidatePassword(goodPassword);
            Assert.IsTrue(userModel.isValidPassword);
        }

        [TestMethod]
        public void CheckReadOnceLogicOnPassword()
        {
            UserModel userModel = new UserModel();
            string goodPassword = "mckinninLloyd12";
            userModel.ValidatePassword(goodPassword);
            Assert.IsFalse(userModel.readFlag);
            userModel.getPassword();
            string nullString = userModel.getPassword();
            Assert.IsNull(nullString);
            Assert.IsTrue(userModel.readFlag);
        }
    }
}
