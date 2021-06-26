using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace TrelloAutotests.Pages
{
    public class BasePage
    {
        protected WebDriverWait Wait;
        protected IWebDriver driver;

        public BasePage()
        {            
            driver = Driver.DriverInstance;
            PageFactory.InitElements(driver, this);
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
    }
}
