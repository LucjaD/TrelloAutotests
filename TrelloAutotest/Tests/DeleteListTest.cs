using NUnit.Framework;
using TrelloAPI;
using TrelloAutotests.Tests;

namespace TrelloAutotest.Tests
{
    public class DeleteListTest : BaseTest
    {
        private const string _listToDelete = "Lista do usunięcia";
        private const string _boardName = "Tablica do listy";

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            BaseRestClient.ClientConnection(ConfigHelper.InitConfiguration()["ApiUrl"]);

            Api.CreateBoard(_boardName);
            Api.CreateList(_boardName,_listToDelete);
        }

        [Test]
        public void DeleteList()
        {
            TrelloMainPage
               .OpenBoard(_boardName)
               .DeleteList(_listToDelete)
               .VerifyListNotExists(_listToDelete);
        }

        [OneTimeTearDown]
        public void DeleteBoard()
        {
            Api.DeleteBoard(_boardName);
        }
    }
}
