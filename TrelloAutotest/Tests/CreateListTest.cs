using NUnit.Framework;
using TrelloAPI;
using TrelloAutotest.Pages;
using TrelloAutotests.Tests;

namespace TrelloAutotest.Tests
{
    public class CreateListTest : BaseTest
    {
        private const string _listName = "Lista";
        private const string _boardName = "Tablica do listy";

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            BaseRestClient.ClientConnection(ConfigHelper.InitConfiguration()["ApiUrl"]);

            Api.CreateBoard(_boardName);
        }

        [Test]
        public void CreateList()
        {
              TrelloMainPage
                .OpenBoard(_boardName)
                .CreateList(_listName)
                .VerifyListExists(_listName);
        }

        [OneTimeTearDown]
        public void DeleteBoard()
        {
            Api.DeleteBoard(_boardName);
        }
    }
}
