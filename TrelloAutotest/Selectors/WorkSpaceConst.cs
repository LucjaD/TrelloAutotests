namespace TrelloAutotest.Selectors
{
    public static class WorkSpaceConst
    {
        public const string WorkSpaceNameInput = "input[data-test-id='header-create-team-name-input']";
        public const string WorkSpaceTypeDropdown = "//*[contains(text(),'Wybierz…')]";
        public const string WorkSpaceDescriptionInput = "//textarea[contains(text(),'')]";
        public const string WorkSpaceContinueButton = "//button[contains(text(),'Kontynuuj')]";
        public const string WorkSpaceLaterButton = "//a[contains(text(),'Później')]";
        public static string WorkSpaceTypeSelect(string element) => $"div[data-test-id ='header-create-team-type-input-{element}']";

        public static string WorkSpaceCreated(string workSpaceName) => $"//h1[contains(text(),'{workSpaceName}')]";

        public const string WorkSpaceDeleted = "[data-test-id *= 'home-team-tab-section-']";

        public const string HouseIcon = "[aria-label='HouseIcon']";
        public const string WorkSpaceTab = "[data-test-id *= 'home-team-tab-section-']";
        public const string WorkSpaceSettings = "[data-test-id = 'home-team-settings-tab']";
        public const string WorkSpaceName = "tabbed-pane-header-details";
        public const string WorkSpaceDeleteButton = "quiet-button";
    }
}
