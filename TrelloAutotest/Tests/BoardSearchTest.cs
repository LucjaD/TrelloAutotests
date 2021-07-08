using NUnit.Framework;
using TrelloAPI;
using TrelloAutotest.Pages;
using TrelloAutotests.Tests;

namespace TrelloAutotest.Tests
{
    class BoardSearchTest : BaseTest
    {
        private const string _newBoardName = "Nowa tablica";

        [OneTimeSetUp]
        public void OneTimeSetUpSetUp()
        {
            BaseRestClient.ClientConnection("https://api.trello.com/1/");

            var POSTRequests = new POSTRequests();
            POSTRequests.CreateBoard(_newBoardName);
        }

        [Test]
        public void BoardSearch()
        {
            TrelloMainPage
                .Search(_newBoardName)
                .SelectSearchResult(_newBoardName)
                .VerifyUrl(_newBoardName)
                .VerifyBoardViewButtonExists()
                .VerifyBoardMenuButtonExists();
        }

        [OneTimeTearDown]
        public void DeleteCreatedBoards()
        {
            var DeleteBoardRequest = new DELETERequests();
            DeleteBoardRequest.DeleteBoard(_newBoardName);
        }
    }
}
