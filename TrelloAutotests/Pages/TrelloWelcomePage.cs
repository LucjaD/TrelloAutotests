using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TrelloAutotests.Pages
{
    class TrelloWelcomePage : BasePage
    {
        public TrelloWelcomePage() : base()
        {
            Driver.OpenPage("https://trello.com/pl");
        }

        [FindsBy(How = How.CssSelector, Using = "[href *='/login']")]
        public IWebElement LoginButton { get; set; }
    }
}
