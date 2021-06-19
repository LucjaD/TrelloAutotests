using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace TrelloAutotests.Pages
{
    public class BasePage
    {
        protected WebDriverWait Wait;
        public BasePage()
        {
            PageFactory.InitElements(Driver.DriverInstance, this);

            Wait = new WebDriverWait(Driver.DriverInstance, TimeSpan.FromSeconds(10));
        }
    }
}
