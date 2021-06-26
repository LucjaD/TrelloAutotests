using NUnit.Framework;
using TrelloAutotest.Pages;
using TrelloAutotests.Tests;

namespace TrelloAutotest.Tests
{
    class LoginTest : BaseTest
    {
        [Test]
        public void CorrectLogin()
        {
            Assert.IsTrue(new TrelloBoardPage().IsLoginCorrect());
        }
    }
}
