using NUnit.Framework;
using NUnit.Framework.Internal;
using TrelloAutotest.Pages;
using TrelloAutotests.Tests;
using TrelloAPI;


namespace TrelloAutotest.Tests
{
    class CreateWorkspaceTest : BaseTest
    {
        private const string _newWorkSpace = "Nowa przestrzeń";

        [OneTimeSetUp]
        public void OneTimeSetUpSetUp()
        {
            BaseRestClient.ClientConnection("https://api.trello.com/1/");
        }

        [Test]
        public void CreateWorkSpace()
        {
            TrelloMainPage
                 .OpenCreateTab()
                 .CreateWorkSpace()
                 .CreateNewWorkSpace("operations", _newWorkSpace)
                 .VerifyWorkspaceWasCreated(_newWorkSpace);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            var deleteWorkspaceRequest = new DELETERequests();
            deleteWorkspaceRequest.DeleteWorkspace(_newWorkSpace);
        }
    }
}
