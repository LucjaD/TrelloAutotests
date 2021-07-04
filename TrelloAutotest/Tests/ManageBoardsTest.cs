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

            trelloMainPage.
                CreateNewBoardByPanel().
                CreateBoard(_boardName).
                IsUrlCorrect(_boardName).
                IsBoardCreated(true).
                IsBoardMenuAvilable(true);
        }

        [Test]
        public void CreateNewBoardByMenu()
        {
            var trelloMainPage = new TrelloMainPage();

            trelloMainPage.
               OpenCreateTab().
               CreateNewBoardByMenu().
               CreateBoard(_boardName).
               IsUrlCorrect(_boardName).
               IsBoardCreated(true).
               IsBoardMenuAvilable(true);
        }

        [Test]
        public void DeleteBoard()
        {
            TrelloMainPage.
                CreateNewBoardByPanel().
                CreateBoard("Tablica do usunięcia").
                DeleteBoard().
                ConfirmDelete().
                IsBoardDeleted().
                IsBoardCreated(false).
                IsBoardMenuAvilable(false);
        }
    }
}
