using NUnit.Framework;
using TrelloAutotest;
using TrelloAutotests.Pages;

namespace TrelloAutotests.Tests
{
    public class BaseTest
    {        
        public TrelloWelcomePage TrelloWelcomePage;
        private TrelloLoginPage _trelloLoginPage;
 
        [SetUp]
        public void SetUp()
        {
            Driver.StartBrowser();

            TrelloWelcomePage = new TrelloWelcomePage();
            TrelloWelcomePage.LoginButton.Click();

            _trelloLoginPage = new TrelloLoginPage();
            _trelloLoginPage.Login(Users.CorrectTestUser);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitBrowser();
        }
    }
}
