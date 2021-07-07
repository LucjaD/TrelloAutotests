using NUnit.Framework;
using TrelloAPI;
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
              TrelloMainPage
                .OpenBoard(_boardName)
                .CreateList(_listName)
                .VerifyListExists(_listName);
        }

        [Test]
        public void DeleteList()
        {
            TrelloMainPage
               .OpenBoard(_boardName)
               .CreateList(_listToDelete)
               .DeleteList(_listToDelete)
               .VerifyListNotExists(_listToDelete);
        }
    }
}
