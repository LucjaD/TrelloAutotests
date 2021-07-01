using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TrelloAutotests
{
    public static class Driver
    {
        private static IWebDriver _driver;

        public static IWebDriver DriverInstance  => _driver; 

        public static void StartBrowser() => _driver = new FirefoxDriver();

        public static void OpenPage(string url) => _driver.Url = url;

        public static void QuitBrowser() => _driver.Quit();
    }
}
