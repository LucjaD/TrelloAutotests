using NUnit.Framework;
using System.Linq;
using TrelloAutotest.Messages;
using TrelloAutotest.Pages;
using TrelloAutotest.Selectors;

namespace TrelloAutotests.Pages
{
    public class TrelloLoginPage : BasePage
    {
        public TrelloMainPage Login(User user)
        {
            driver.FindElement(LoginSelectors.Login).Click();
            driver.FindElement(LoginSelectors.Password).SendKeys(user.Password);
            driver.FindElement(LoginSelectors.LoginButton).Click();

            return new TrelloMainPage();
        }

        public TrelloLoginPage EnterUserName(User user)
        {
            driver.FindElement(LoginSelectors.User).SendKeys(user.Username);
            return this;
        }

        public TrelloLoginPage ValidateUserExists()
        {
            Assert.IsFalse(driver.FindElements(LoginSelectors.ErrorPanel).Any(x => x.Text.Contains(MessageText.AccountDoesNotExists)));
            return this;
        }
    }
}
