using OpenQA.Selenium;

namespace TrelloAutotest.Selectors
{
    public static class BaseSelectors
    {
        public static By DeleteButton = By.ClassName("js-delete");
        public static By ConfirmButton = By.ClassName("js-confirm");
        public static By DeletedButtonHeader = By.ClassName("js-react-root");
        public static By IncorrectLoginPanel = By.Id("login-error");
    }
}
