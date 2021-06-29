using System.Linq;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    using BaseSelectors = Selectors.BaseConst;

    public class TrelloConfirmDeletePage : BasePage
    {
        public void ConfirmDelete()
        {
            driver.FindElement(BaseSelectors.DeleteButton).Click();
            driver.FindElement(BaseSelectors.ConfirmButton).Click();
        }

        public bool IsBoardDeleted() => driver.FindElements(BaseSelectors.DeletedButtonHeader).Any(x => x.Text.Contains("Tablicy nie znaleziono."));
    }
}
