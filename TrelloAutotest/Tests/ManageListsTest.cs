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
            var _trelloMainPage = new TrelloMainPage();
            var _trelloListPage = new TrelloListPage();

            _trelloMainPage.OpenBoard(_boardName);
            _trelloListPage.CreateList(_listName);

            Assert.IsTrue(_trelloListPage.IsListCreated(_listName));
            Assert.IsTrue(_trelloListPage.IsAddingCardPossible());
        }

        [Test]
        public void DeleteList()
        {
            var _trelloMainPage = new TrelloMainPage();
            var _trelloListPage = new TrelloListPage();

            _trelloMainPage.OpenBoard(_boardName);
            _trelloListPage.CreateList(_listToDelete);
            _trelloListPage.DeleteList(_listToDelete);

            Assert.IsFalse(_trelloListPage.IsListCreated(_listToDelete));
            Assert.IsFalse(_trelloListPage.IsAddingCardPossible());
        }
    }
}
