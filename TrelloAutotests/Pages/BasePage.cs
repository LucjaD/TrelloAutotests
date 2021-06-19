using SeleniumExtras.PageObjects;

namespace TrelloAutotests.Pages
{
    public class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(Driver.DriverInstance, this);
        }
    }
}
