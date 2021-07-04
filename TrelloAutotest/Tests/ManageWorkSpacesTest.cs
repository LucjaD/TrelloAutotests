﻿using NUnit.Framework;
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
            TrelloMainPage.
                 OpenCreateTab().
                 CreateWorkSpace().
                 CreateNewWorkSpace("operations", _newWorkSpace).
                 IsWorkSpaceCreated(_newWorkSpace);
        }

        [Test]
        public void DeleteWorkSpace()
        { 
            TrelloMainPage.
                 OpenCreateTab().
                 CreateWorkSpace().
                 CreateNewWorkSpace("operations", _workSpaceToDelete).
                 DeleteWorkSpace(_workSpaceToDelete).
                 IsWorkSpaceDeleted(_workSpaceToDelete);
        }
    }
}
