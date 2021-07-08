using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
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
            BaseRestClient.ClientConnection("https://api.trello.com/1/");

            var POSTRequests = new POSTRequests();
            POSTRequests.CreateBoard(_boardName);
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
