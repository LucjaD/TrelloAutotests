using OpenQA.Selenium;
using System.Linq;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    using BaseSelectors = Selectors.BaseConst;

    public class TrelloConfirmDeletePage : BasePage
    {
        public void ConfirmDelete()
        {
            driver.FindElement(By.ClassName("js-delete")).Click();
            driver.FindElement(By.ClassName(BaseSelectors.ConfirmButton)).Click();
        }

        public bool IsBoardDeleted() => driver.FindElements(By.ClassName("js-react-root")).Any(x => x.Text.Contains("Tablicy nie znaleziono."));
    }
}
