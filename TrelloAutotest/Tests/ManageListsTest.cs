using NUnit.Framework;
using TrelloAutotest.Pages;
using TrelloAutotests.Tests;

namespace TrelloAutotest.Tests
{
    class ManageListsTest : BaseTest
    {
        private TrelloMainPage _trelloMainPage;
        private TrelloListPage _trelloListPage;

        [Test]
        public void CreateList()
        {
            _trelloListPage = new TrelloListPage();
            _trelloMainPage = new TrelloMainPage();

            _trelloMainPage.OpenBoard("Tablica do listy");
            _trelloListPage.CreateList();

            Assert.IsTrue(_trelloListPage.IsListCreated());
        }

        [Test]
        public void DeleteList()
        {
            _trelloMainPage = new TrelloMainPage();
            _trelloListPage = new TrelloListPage();

            _trelloMainPage.OpenBoard("Tablica do listy");
            _trelloListPage.DeleteList();

          //Assert.IsFalse(_trelloListPage.IsListDeleted());
        }
    }
}
