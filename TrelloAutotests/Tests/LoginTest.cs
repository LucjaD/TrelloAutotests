using NUnit.Framework;
using TrelloAutotests.Pages;

namespace TrelloAutotests.Tests
{
    class LoginTest : BaseTest
    {
        private TrelloWelcomePage _trelloWelcomePage;
        private TrelloLoginPage _trelloLoginPage;
        private const string _userName = "dybek571@gmail.com";
        private const string _password = "szkola11";

        [Test]
        public void CorrectLogin()
        {
            _trelloWelcomePage.LoginButton.Click();

            _trelloLoginPage.Login(new User( _userName, _password));
            
        }
    }
}
