using NUnit.Framework;
using TrelloAutotest.Pages;
using TrelloAutotests.Tests;

namespace TrelloAutotest.Tests
{
    class BoardSearchTest : BaseTest
    {
        private const string _newBoardName = "Nowa tablica";

        [Test]
        public void BoardSearch()
        {
            var _trelloMainPage = new TrelloMainPage();           
            var boardPage = new TrelloBoardPage();

            _trelloMainPage.Search(_newBoardName);
            _trelloMainPage.SelectSearchResult(_newBoardName);

            Assert.IsTrue(boardPage.IsUrlCorrect(_newBoardName));
            Assert.IsTrue(boardPage.IsBoardCreated());
            Assert.IsTrue(boardPage.IsBoardMenuAvilable());
        }
    }
}
