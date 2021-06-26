using OpenQA.Selenium;
using System.Linq;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    public class TrelloBoardPage : BasePage
    {
        public TrelloBoardPage() => Wait.Until(d => driver.FindElements(By.ClassName("boards-page-section-header-name")).Any());

        public void CreateNewList() => driver.FindElement(By.XPath("//span[contains(text(),'Dodaj listę')]")).Click();
        
        public string TrimUrl(string Url) => Url.Split('/').Last();

        public void OpenBoardMenu() => driver.FindElements(By.TagName("a")).First(x => x.Text.Contains("Pokaż menu")).Click();
        
        public bool IsLoginCorrect() => driver.FindElements(By.ClassName("boards-page-section-header-name")).Any(); ;

        public bool IsUrlCorrect(string BoardName)
        {
            Wait.Until(d => driver.FindElements(By.Id("board")).Any());


            var SplitName = BoardName.Contains(' ') ? BoardName.ToLower().Replace(' ', '-').TrimEnd('-') : BoardName.ToLower();
            var url = TrimUrl(driver.Url);

            return url == (SplitName);
        }

        public void DeleteBoard()
        {
            OpenBoardMenu();

            var tak = driver.FindElement(By.ClassName("board-menu-navigation"));
            tak.FindElement(By.ClassName("js-open-more")).Click();
            driver.FindElement(By.ClassName("js-close-board")).Click();
            driver.FindElement(By.ClassName("js-confirm")).Click();
        }
    }
}
