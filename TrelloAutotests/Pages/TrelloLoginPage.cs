using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TrelloAutotests.Pages
{
    class TrelloLoginPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "user")]
        public IWebElement UserName { get; set; }

        [FindsBy(How =How.Id, Using = "password")]
        public IWebElement Password { get; set; }

        public void Login(User user)
        {
            UserName.SendKeys(user.Username);
            Password.SendKeys(user.Password);
        }
    }
}
