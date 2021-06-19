using NUnit.Framework;
using TrelloAutotests.Pages;

namespace TrelloAutotests.Tests
{
    public class BaseTest
    {
        private TrelloLoginPage _trelloLoginPage;
        public TrelloWelcomePage TrelloWelcomePage;
        private const string _userName = "dybek571@gmail.com";
        private const string _password = "szkola11";

        [SetUp]
        public void SetUp()
        {
            Driver.StartBrowser();
            TrelloWelcomePage = new TrelloWelcomePage();
            TrelloWelcomePage.LoginButton.Click();

            _trelloLoginPage = new TrelloLoginPage();
            _trelloLoginPage.Login(new User(_userName, _password));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseBrowser();
        }
    }
}
