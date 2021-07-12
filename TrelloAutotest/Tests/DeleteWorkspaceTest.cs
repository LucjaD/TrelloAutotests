using NUnit.Framework;
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
            BaseRestClient.ClientConnection(ConfigHelper.InitConfiguration()["ApiUrl"]);

            Api.CreateWorkspace(_workSpaceToDelete);
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
