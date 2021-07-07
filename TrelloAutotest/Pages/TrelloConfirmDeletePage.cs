using NUnit.Framework;
using System.Linq;
using TrelloAutotest.Messages;
using TrelloAutotest.Selectors;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    public class TrelloConfirmDeletePage : BasePage
    {
        public TrelloConfirmDeletePage ConfirmDelete()
        {
            driver.FindElement(BaseSelectors.DeleteButton).Click();
            driver.FindElement(BaseSelectors.ConfirmButton).Click();

            return this;
        }

        public TrelloBoardPage VerifyBoardDeleting()
        {
            Assert.IsTrue(driver.FindElements(BaseSelectors.DeletedButtonHeader).Any(x => x.Text.Contains(MessageText.BoardNotFound)));
         
            return new TrelloBoardPage();
        }
    }
}

