using TrelloAutotest.Selectors;

namespace TrelloAutotests.Pages
{
    class TrelloLoginPage : BasePage
    {
        public void Login(User user)
        {
            driver.FindElement(LoginConst.User).SendKeys(user.Username);
            driver.FindElement(LoginConst.Login).Click();
            driver.FindElement(LoginConst.Password).SendKeys(user.Password);
            driver.FindElement(LoginConst.LoginButton).Click();
        }
    }
}
