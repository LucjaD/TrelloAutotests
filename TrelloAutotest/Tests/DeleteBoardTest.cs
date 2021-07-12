using NUnit.Framework;
using TrelloAPI;
using TrelloAutotests.Tests;

namespace TrelloAutotest.Tests
{
    public class DeleteBoardTest : BaseTest
    {
        private const string _boardName = "Tablica do usunięcia";

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            BaseRestClient.ClientConnection(ConfigHelper.InitConfiguration()["ApiUrl"]);

            Api.CreateBoard(_boardName);
        }

        [Test]
        public void DeleteBoard()
        {
            TrelloMainPage
                .OpenBoard(_boardName)
                .DeleteBoard()
                .ConfirmDelete()
                .VerifyBoardWasDeleted()
                .VerifyBoardViewButtonNotExists()
                .VerifyBoardMenuButtonNotExists();
        }
    }
}
