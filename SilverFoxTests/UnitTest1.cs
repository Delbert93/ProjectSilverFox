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
            
            Assert.IsFalse(userModel.ValidateUsername(badLengthUserName));
            Assert.IsFalse(userModel.ValidateUsername(badCharUserName));
            Assert.IsTrue(userModel.ValidateUsername(goodUserName));
        }

        [TestMethod]
        public void ValidatePassword()
        {
            string badLengthPassword = "hellow";
            string goodPassword = "mckinninLloyd12";
            UserModel userModel = new UserModel();

            Assert.IsFalse(userModel.ValidatePassword(badLengthPassword));
            Assert.IsTrue(userModel.ValidatePassword(goodPassword));
        }
    }
}
