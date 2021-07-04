using NUnit.Framework;
using TrelloAutotest.Pages;
using TrelloAutotests.Tests;

namespace TrelloAutotest.Tests
{
    class ManageListsTest : BaseTest
    {
        private const string _listName = "Lista";
        private const string _boardName = "Tablica do listy";
        private const string _listToDelete = "Lista do usunięcia";

        [Test]
        public void CreateList()
        {
              TrelloMainPage.
                OpenBoard(_boardName).
                CreateList(_listName).
                IsListCreated(_listName, true);
        }

        [Test]
        public void DeleteList()
        {
            TrelloMainPage.
               OpenBoard(_boardName).
               CreateList(_listToDelete).
               DeleteList(_listToDelete).
               IsListCreated(_listToDelete, false);
        }
    }
}
