using NUnit.Framework;
using NUnit.Framework.Internal;
using TrelloAutotest.Pages;
using TrelloAutotests.Tests;

namespace TrelloAutotest.Tests
{
    class ManageWorkSpacesTest : BaseTest
    {
        private const string _newWorkSpace = "Nowa przestrzeń";
        private const string _workSpaceToDelete = "Przestrzeń do usunięcia";

        [Test]
        public void CreateWorkSpace()
        {
            var trelloCreateWorkSpace = CreateWorkSpaceForTest(_newWorkSpace);
           
            Assert.IsTrue(trelloCreateWorkSpace.IsWorkSpaceCreated(_newWorkSpace));
        }

        [Test]
        public void DeleteWorkSpace()
        {
            var trelloCreateWorkSpace = CreateWorkSpaceForTest(_workSpaceToDelete);
            trelloCreateWorkSpace.DeleteWorkSpace(_workSpaceToDelete);
           
            Assert.IsFalse(trelloCreateWorkSpace.IsWorkSpaceDeleted(_workSpaceToDelete));
        }

        public TrelloCreateWorkSpacePage CreateWorkSpaceForTest(string _workSpaceName)
        {
            var trelloMainPage = new TrelloMainPage();

            trelloMainPage.OpenCreateTab();
            trelloMainPage.CreateWorkSpace();

            var trelloCreateWorkSpace = new TrelloCreateWorkSpacePage();

            trelloCreateWorkSpace.CreateNewWorkSpace("operations", _workSpaceName);
            return trelloCreateWorkSpace;
        }
    }
}
