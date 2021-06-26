using NUnit.Framework;
using TrelloAutotest.Pages;
using TrelloAutotests.Tests;

namespace TrelloAutotest.Tests
{
    class ManageListsTest : BaseTest
    {
        private TrelloMainPage _trelloMainPage;
        private TrelloListPage _trelloListPage;
        private const string _listName = "Lista";

        [Test]
        public void CreateList()
        {
            _trelloMainPage = new TrelloMainPage();
            _trelloListPage = new TrelloListPage();

            _trelloMainPage.OpenBoard("Tablica do listy");
            _trelloListPage.CreateList(_listName);

            Assert.IsTrue(_trelloListPage.IsListCreated());
        }

        [Test]
        public void DeleteList()
        {
            _trelloMainPage = new TrelloMainPage();
            _trelloListPage = new TrelloListPage();

            _trelloMainPage.OpenBoard("Tablica do listy");
            _trelloListPage.CreateList("Lista do usunięcia");
            _trelloListPage.DeleteList();

            Assert.IsFalse(_trelloListPage.IsListDeleted("Lista do usunięcia"));
        }
    }
}
