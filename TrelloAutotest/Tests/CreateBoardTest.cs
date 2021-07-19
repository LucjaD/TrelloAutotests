using NUnit.Framework;
using TrelloApi;
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
            BaseRestClient.ClientConnection(ConfigHelper.InitConfiguration()["ApiUrl"]);
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
            Api.DeleteBoard(_boardName);
        }
    }
}
