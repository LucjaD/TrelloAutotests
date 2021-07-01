using NUnit.Framework;
using TrelloAutotest.Pages;
using TrelloAutotests.Tests;

namespace TrelloAutotest.Tests
{
    class ManageBoardsTest : BaseTest
    {
        private const string _boardName = "Nowa tablica";

        [Test]
        public void CreateNewBoardByPanel()
        {
            var trelloMainPage = new TrelloMainPage();
            var configureBoard = new TrelloCreateBoardPage();
            var boardPage = new TrelloBoardPage();

            trelloMainPage.CreateNewBoardByPanel();
            configureBoard.CreateBoard(_boardName);

            Assert.IsTrue(boardPage.IsUrlCorrect(_boardName));
            Assert.IsTrue(boardPage.IsBoardCreated());
            Assert.IsTrue(boardPage.IsBoardMenuAvilable());
        }

        [Test]
        public void CreateNewBoardByMenu()
        {
            var trelloMainPage = new TrelloMainPage();
            var configureBoard = new TrelloCreateBoardPage();
            var boardPage = new TrelloBoardPage();

            trelloMainPage.OpenCreateTab();
            trelloMainPage.CreateNewBoardByMenu();
            configureBoard.CreateBoard(_boardName);

            Assert.IsTrue(boardPage.IsUrlCorrect(_boardName));
            Assert.IsTrue(boardPage.IsBoardCreated());
            Assert.IsTrue(boardPage.IsBoardMenuAvilable());
        }

        [Test]
        public void DeleteBoard()
        {
            var trelloMainPage = new TrelloMainPage();
            var boardPage = new TrelloBoardPage();
            var configureBoard = new TrelloCreateBoardPage();
            var confirmDeleteBoard = new TrelloConfirmDeletePage();

            trelloMainPage.CreateNewBoardByPanel();
            configureBoard.CreateBoard("Tablica do usunięcia");
            boardPage.DeleteBoard();
            confirmDeleteBoard.ConfirmDelete();

            Assert.IsTrue(confirmDeleteBoard.IsBoardDeleted());
            Assert.IsFalse(boardPage.IsBoardCreated());
            Assert.IsFalse(boardPage.IsBoardMenuAvilable());
        }
    }
}
