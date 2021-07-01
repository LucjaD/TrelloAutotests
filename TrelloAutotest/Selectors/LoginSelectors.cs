using OpenQA.Selenium;

namespace TrelloAutotest.Selectors
{
    public static class LoginSelectors
    {
        public static By User = By.Id("user");
        public static By Login = By.Id("login");
        public static By Password = By.Id("password");
        public static By LoginButton = By.Id("login-submit");
        public static By ErrorPanel = By.Id("error");
    }
}
