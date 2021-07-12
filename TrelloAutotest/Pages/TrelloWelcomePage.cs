using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Configuration;
using TrelloAPI;
using TrelloAutotest;

namespace TrelloAutotests.Pages
{
    public class TrelloWelcomePage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "[href *='/login']")]
        public IWebElement LoginButton { get; set; } 
        
        public TrelloWelcomePage() : base()
        {
            Driver.OpenPage(ConfigHelper.InitConfiguration()["TestUrl"]);
        }
    }
}
