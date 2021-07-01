using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TrelloAutotests.Pages
{
    public class TrelloWelcomePage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "[href *='/login']")]
        public IWebElement LoginButton { get; set; } 
        
        public TrelloWelcomePage() : base()
        {
            Driver.OpenPage("https://trello.com/pl");
        }
    }
}
