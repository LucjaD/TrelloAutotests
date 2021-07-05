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
            TrelloMainPage
                .CreateNewBoardByPanel()
                .CreateBoard(_boardName)
                .ValidateUrl(_boardName)
                .ValidateBoardCreating(true)
                .ValidateBoardMenu(true);
        }

        [Test]
        public void CreateNewBoardByMenu()
        {
            TrelloMainPage
               .OpenCreateTab()
               .CreateNewBoardByMenu()
               .CreateBoard(_boardName)
               .ValidateUrl(_boardName)
               .ValidateBoardCreating(true)
               .ValidateBoardMenu(true);
        }

        [Test]
        public void DeleteBoard()
        {
            TrelloMainPage
                .CreateNewBoardByPanel()
                .CreateBoard("Tablica do usunięcia")
                .DeleteBoard()
                .ConfirmDelete()
                .ValidateBoardDeleting()
                .ValidateBoardCreating(false)
                .ValidateBoardMenu(false);
        }
    }
}
