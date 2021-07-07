using NUnit.Framework;
using TrelloAPI;
using TrelloAutotest;
using TrelloAutotest.Pages;
using TrelloAutotests.Pages;

namespace TrelloAutotests.Tests
{
    public class BaseTest
    {
        protected TrelloMainPage TrelloMainPage;
        protected TrelloLoginPage TrelloLoginPage;

        [SetUp]
        public virtual void SetUp()
        {
            StartBrowser();
            var trelloWelcomePage = new TrelloWelcomePage();
            trelloWelcomePage.LoginButton.Click();

            TrelloLoginPage = new TrelloLoginPage();

            TrelloLoginPage.EnterUserName(Users.CorrectTestUser);
            TrelloMainPage = TrelloLoginPage.Login(Users.CorrectTestUser);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitBrowser();
        }
        
        public void StartBrowser()
        {
            Driver.StartBrowser();
        }
    }
}
