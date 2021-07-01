using NUnit.Framework;
using TrelloAutotest;
using TrelloAutotests.Pages;

namespace TrelloAutotests.Tests
{
    public class BaseTest
    {        
        [SetUp]
        public void SetUp()
        {
            Driver.StartBrowser();

            var _trelloWelcomePage = new TrelloWelcomePage();
            _trelloWelcomePage.LoginButton.Click();

            var _trelloLoginPage = new TrelloLoginPage();
            _trelloLoginPage.Login(Users.CorrectTestUser);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitBrowser();
        }
    }
}
