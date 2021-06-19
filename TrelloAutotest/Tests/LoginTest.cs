using NUnit.Framework;
using TrelloAutotest.Pages;

namespace TrelloAutotests.Tests
{
    class LoginTest : BaseTest
    {
        private TrelloBoardPage _trelloBoardPage;
        [Test]
        public void CorrectLogin()
        {
            _trelloBoardPage = new TrelloBoardPage();
            Assert.IsTrue(_trelloBoardPage.IsLoginCorrect());
        }
    }
}
