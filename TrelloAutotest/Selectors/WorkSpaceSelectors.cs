using OpenQA.Selenium;

namespace TrelloAutotest.Selectors
{
    public static class WorkSpaceSelectors
    {
        public static By WorkSpaceNameInput = By.CssSelector("input[data-test-id='header-create-team-name-input']");
        public static By WorkSpaceTypeDropdown = By.XPath("//*[contains(text(),'Wybierz…')]");
        public static By WorkSpaceDescriptionInput = By.XPath("//textarea[contains(text(),'')]");
        public static By WorkSpaceContinueButton = By.XPath("//button[contains(text(),'Kontynuuj')]");
        public static By WorkSpaceLaterButton = By.XPath("//a[contains(text(),'Później')]");
        public static By WorkSpaceTypeDropdownElement(string element) => By.CssSelector($"div[data-test-id ='header-create-team-type-input-{element}']");

        public static By WorkSpaceTitle(string workSpaceName) => By.XPath($"//h1[contains(text(),'{workSpaceName}')]");

        public static By DeletedWorkSpace = By.CssSelector("[data-test-id *= 'home-team-tab-section-']");

        public static By HouseIcon = By.CssSelector("[aria-label='HouseIcon']");
        public static By WorkSpaceTab = By.CssSelector("[data-test-id *= 'home-team-tab-section-']");
        public static By WorkSpaceSettings = By.CssSelector("[data-test-id = 'home-team-settings-tab']");
        public static By WorkSpaceName = By.ClassName("tabbed-pane-header-details");
        public static By WorkSpaceDeleteButton = By.ClassName("quiet-button");
    }
}
