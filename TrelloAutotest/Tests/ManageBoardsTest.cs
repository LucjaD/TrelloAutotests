using NUnit.Framework;
using TrelloAutotest.Pages;
using TrelloAutotests.Tests;

namespace TrelloAutotest.Tests
{
    class ManageBoardsTest : BaseTest
    {
        private TrelloMainPage _trelloMainPage;
        private TrelloCreateBoardPage _configureBoard;
        private TrelloBoardPage _boardPage;
        private const string _boardName = "Nowa tablica ";

        [Test]
        public void CreateNewBoard()
        {
            _trelloMainPage = new TrelloMainPage();
            _configureBoard = new TrelloCreateBoardPage();
            _boardPage = new TrelloBoardPage();

            _trelloMainPage.CreateNewBoard();
            _configureBoard.CreateBoard(_boardName);
          
            Assert.IsTrue(_boardPage.IsUrlCorrect(_boardName));
        }

        [Test]
        public void DeleteBoard()
        {
            _trelloMainPage = new TrelloMainPage();
            _boardPage = new TrelloBoardPage();

            _trelloMainPage.OpenBoard("Tablica do usunięcia");
            _boardPage.DeleteBoard();
        }
    }
}
