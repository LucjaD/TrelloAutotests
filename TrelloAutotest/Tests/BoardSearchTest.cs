using NUnit.Framework;
using TrelloAutotest.Pages;
using TrelloAutotests.Tests;

namespace TrelloAutotest.Tests
{
    class BoardSearchTest : BaseTest
    {
        private const string _newBoardName = "Nowa tablica";

        [Test]
        public void BoardSearch()
        {
            TrelloMainPage.
                Search(_newBoardName).
                SelectSearchResult(_newBoardName).
                IsUrlCorrect(_newBoardName).
                IsBoardCreated(true).
                IsBoardMenuAvilable(true);
        }
    }
}
