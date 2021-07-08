using NUnit.Framework;
using TrelloAPI;
using TrelloAutotest.Pages;
using TrelloAutotests.Tests;

namespace TrelloAutotest.Tests
{
    class CreateBoardTest : BaseTest
    {
        private const string _boardName = "Nowa tablica";

        [OneTimeSetUp]
        public void OneTimeSetUpSetUp()
        {
            BaseRestClient.ClientConnection("https://api.trello.com/1/");
        }

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

        [OneTimeTearDown]
        public void DeleteCreatedBoards()
        {
            var deleteBoardRequest = new DELETERequests();
            deleteBoardRequest.DeleteBoard(_boardName);
        }
    }
}
