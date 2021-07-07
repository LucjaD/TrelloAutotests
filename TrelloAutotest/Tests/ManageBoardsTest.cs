using NUnit.Framework;
using TrelloAPI;
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
                .VerifyUrl(_boardName)
                .VerifyBoardViewButtonExists()
                .VerifyBoardMenuButtonExists();
        }

        [Test]
        public void CreateNewBoardByMenu()
        {
            TrelloMainPage
               .OpenCreateTab()
               .CreateNewBoardByMenu()
               .CreateBoard(_boardName)
               .VerifyUrl(_boardName)
               .VerifyBoardViewButtonExists()
               .VerifyBoardMenuButtonExists();
        }

        [Test]
        public void DeleteBoard()
        {
            TrelloMainPage
                .CreateNewBoardByPanel()
                .CreateBoard("Tablica do usunięcia")
                .DeleteBoard()
                .ConfirmDelete()
                .VerifyBoardDeleting()
                .VerifyBoardViewButtonNotExists()
                .VerifyBoardMenuButtonNotExists();
        }
    }
}
