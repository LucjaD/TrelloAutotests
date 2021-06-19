using OpenQA.Selenium;
using System.Linq;
using TrelloAutotests;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    public class TrelloBoardPage : BasePage
    {

        public void CreateNewList()
        {
            Driver.DriverInstance.FindElement(By.XPath("//span[contains(text(),'Dodaj listę')]")).Click();
        }

        public bool IsUrlCorrect(string BoardName)
        {
            Wait.Until(d => Driver.DriverInstance.FindElements(By.Id("board")).Any());

            string SplitName = "";
            if (BoardName.Contains(' '))
            {
                SplitName = BoardName.ToLower().Replace(' ', '-');
                SplitName = SplitName.TrimEnd('-');
            }
            else
            {
                SplitName = BoardName.ToLower();
            }

            var url = TrimUrl(Driver.DriverInstance.Url);

            return url == (SplitName);
        }

        public string TrimUrl(string Url)
        {
            var SplitUrl = Url.Split('/');
            return SplitUrl[SplitUrl.Length - 1];
        }

        public void DeleteBoard()
        {
            OpenBoardMenu();

            Wait.Until(d => Driver.DriverInstance.FindElements(By.ClassName("is-show-menu")).Any());

            Driver.DriverInstance.FindElement(By.ClassName("js-open-card-filter")).Click();
            //Driver.DriverInstance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //Driver.DriverInstance.FindElement(By.XPath("//a[contains(text(),' Zamknij tablicę...')]")).Click();
        }

        public void OpenBoardMenu()
        {
            Driver.DriverInstance.FindElement(By.XPath("//span[contains(text(),'Pokaż menu')]")).Click();
        }

        public bool IsLoginCorrect()
        {
            Wait.Until(d => Driver.DriverInstance.FindElements(By.ClassName("boards-page-section-header-name")).Any());

            return Driver.DriverInstance.FindElement(By.ClassName("boards-page-section-header-name")).Displayed; ;
        }
    }
}
