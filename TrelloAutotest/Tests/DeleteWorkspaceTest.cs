using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TrelloAPI;
using TrelloAutotests.Tests;

namespace TrelloAutotest.Tests
{
    public class DeleteWorkspaceTest : BaseTest
    {
        private const string _workSpaceToDelete = "Przestrzeń do usunięcia";

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            BaseRestClient.ClientConnection("https://api.trello.com/1/");

            var POSTRequests = new POSTRequests();
            POSTRequests.CreateWorkSpace(_workSpaceToDelete);
        }

        [Test]
        public void DeleteWorkSpace()
        {
            TrelloMainPage
                 .DeleteWorkSpace(_workSpaceToDelete)
                 .VerifyWorkSpaceWasDeleted(_workSpaceToDelete);
        }
    }
}
