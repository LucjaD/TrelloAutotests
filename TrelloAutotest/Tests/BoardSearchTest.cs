using NUnit.Framework;
using TrelloAutotest.Pages;
using TrelloAutotests.Tests;

namespace TrelloAutotest.Tests
{
    class BoardSearchTest : BaseTest
    {
        private TrelloMainPage _trelloMainPage;

        [Test]
        public void BoardSearch()
        {
            _trelloMainPage = new TrelloMainPage();           
            var boardPage = new TrelloBoardPage();

            _trelloMainPage.Search("Nowa tablica");
            Assert.IsTrue(boardPage.IsUrlCorrect("Nowa tablica"));
        }
    }
}
