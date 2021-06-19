using OpenQA.Selenium;

namespace TrelloAutotests.Pages
{
    class TrelloLoginPage : BasePage
    {
        public void Login(User user)
        {
            var driver = Driver.DriverInstance;
            driver.FindElement(By.Id("user")).SendKeys(user.Username);
            driver.FindElement(By.Id("login")).Click();
            driver.FindElement(By.Id("password")).SendKeys(user.Password);
            driver.FindElement(By.Id("login-submit")).Click();
        }
    }
}
