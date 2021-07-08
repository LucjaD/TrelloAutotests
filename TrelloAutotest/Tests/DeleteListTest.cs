using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
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
            BaseRestClient.ClientConnection("https://api.trello.com/1/");

            var POSTRequests = new POSTRequests();
            POSTRequests.CreateBoard(_boardName);
            POSTRequests.CreateList(_boardName, _listToDelete);
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
            var DeleteBoardRequest = new DELETERequests();
            DeleteBoardRequest.DeleteBoard(_boardName);
        }
    }
}
