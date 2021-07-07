using NUnit.Framework;
using TrelloAutotests.Pages;
using TrelloAutotests.Tests;

namespace TrelloAutotest.Tests
{
    class LoginTest : BaseTest
    {
        private TrelloLoginPage _trelloLoginPage;

        [SetUp]
        public override void SetUp()
        {
            StartBrowser();
            var trelloWelcomePage = new TrelloWelcomePage();
            trelloWelcomePage.LoginButton.Click();
            _trelloLoginPage = new TrelloLoginPage();
        }

        [Test]
        public void CorrectLogin()
        {
            _trelloLoginPage
                .EnterUserName(Users.CorrectTestUser)
                .VerifyUserExists()
                .Login(Users.CorrectTestUser)
                .VerifyPassword()
                .VerifyLogin();
        }
    }
}
