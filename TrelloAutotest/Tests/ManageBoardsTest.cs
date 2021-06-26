using NUnit.Framework;
using TrelloAutotest.Pages;
using TrelloAutotests.Tests;

namespace TrelloAutotest.Tests
{
    class ManageBoardsTest : BaseTest
    {
        private const string _boardName = "Nowa tablica";

        [Test]
        public void CreateNewBoard()
        {
            var trelloMainPage = new TrelloMainPage();
            var configureBoard = new TrelloCreateBoardPage();
            var boardPage = new TrelloBoardPage();

            trelloMainPage.CreateNewBoard();
            configureBoard.CreateBoard(_boardName);
            Assert.IsTrue(boardPage.IsUrlCorrect(_boardName));
        }

        [Test]
        public void CreateNewBoardButton()
        {
            var trelloMainPage = new TrelloMainPage();
            var configureBoard = new TrelloCreateBoardPage();
            var boardPage = new TrelloBoardPage();

            trelloMainPage.OpenCreateTab();
            trelloMainPage.CreateNewBoardButton();
            configureBoard.CreateBoard(_boardName);
            Assert.IsTrue(boardPage.IsUrlCorrect(_boardName));
        }

        [Test]
        public void DeleteBoard()
        {
            var trelloMainPage = new TrelloMainPage();
            var boardPage = new TrelloBoardPage();
            var configureBoard = new TrelloCreateBoardPage();
            var confirmDeleteBoard = new TrelloConfirmDeletePage();

            trelloMainPage.CreateNewBoard();
            configureBoard.CreateBoard("Tablica do usunięcia");
            boardPage.DeleteBoard();
            confirmDeleteBoard.ConfirmDelete();
            Assert.IsTrue(confirmDeleteBoard.IsBoardDeleted());
        }
    }
}
