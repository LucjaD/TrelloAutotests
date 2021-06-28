using NUnit.Framework;
using NUnit.Framework.Internal;
using TrelloAutotest.Pages;
using TrelloAutotests.Tests;

namespace TrelloAutotest.Tests
{
    class ManageWorkSpacesTest : BaseTest
    {
        [Test]
        public void CreateWorkSpace()
        {
            var trelloCreateWorkSpace = CreateWorkSpaceForTest("Nowa przestrzeń");
            Assert.IsTrue(trelloCreateWorkSpace.IsWorkSpaceCreated("Nowa przestrzeń"));
        }

        [Test]
        public void DeleteWorkSpace()
        {
            var trelloCreateWorkSpace = CreateWorkSpaceForTest("Przestrzeń do usunięcia");
            trelloCreateWorkSpace.DeleteWorkSpace("Przestrzeń do usunięcia");
            Assert.IsFalse(trelloCreateWorkSpace.IsWorkSpaceDeleted("Przestrzeń do usunięcia"));
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
