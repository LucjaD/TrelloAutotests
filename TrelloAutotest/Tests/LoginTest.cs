using NUnit.Framework;
using TrelloAutotest.Pages;
using TrelloAutotests.Pages;
using TrelloAutotests.Tests;

namespace TrelloAutotest.Tests
{
    class LoginTest : BaseTest
    {
        [Test]
        public void CorrectLogin()
        {
            var LoginPage = new TrelloLoginPage();

            Assert.IsFalse(LoginPage.DoesUserExists());
            Assert.IsFalse(LoginPage.IsPasswordCorrect());
            Assert.IsTrue(new TrelloBoardPage().IsLoginCorrect());
        }
    }
}
