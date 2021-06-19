using NUnit.Framework;
using TrelloAutotests.Pages;

namespace TrelloAutotests.Tests
{
    public class BaseTest
    {
        private TrelloWelcomePage _trelloPage;

        [SetUp]
        public void SetUp()
        {
            _trelloPage = new TrelloWelcomePage();
            Driver.StartBrowser();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseBrowser();
        }
    }
}
