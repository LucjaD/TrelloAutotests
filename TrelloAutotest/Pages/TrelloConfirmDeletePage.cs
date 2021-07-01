using System.Linq;
using TrelloAutotest.Messages;
using TrelloAutotest.Selectors;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    public class TrelloConfirmDeletePage : BasePage
    {
        public void ConfirmDelete()
        {
            driver.FindElement(BaseSelectors.DeleteButton).Click();
            driver.FindElement(BaseSelectors.ConfirmButton).Click();
        }

        public bool IsBoardDeleted() => driver.FindElements(BaseSelectors.DeletedButtonHeader).Any(x => x.Text.Contains(MessageText.BoardNotFound));
    }
}
