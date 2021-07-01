using OpenQA.Selenium;

namespace TrelloAutotest.Selectors
{
    public static class MainSelectors
    {
        public static By AddBoardPanel = By.ClassName("mod-add");

        public static By AddBoardButton = By.XPath("//span[contains(text(),'Utwórz tablicę')]");

        public static By CreateWorkSpaceControl = By.XPath("//span[contains(text(),'Utwórz przestrzeń roboczą')]");

        public static By BoardTitle(string boardName) => By.XPath($"//div[@title = '{boardName}']");

        public static By SearchIcon = By.XPath("//span[@aria-label = 'SearchIcon']");
        public static By SearchInput = By.CssSelector("input[data-test-id='header-search-input']");
        public static By SearchResult = By.CssSelector("[data-test-id = 'header-search-popover']");
        public static By SpecificSearchResult = By.CssSelector("[data-test-id = 'header-search-popover'] a[title]");

        public static By CreateTabButton = By.XPath("//button[@aria-label = 'Utwórz tablicę lub Przestrzeń roboczą']");
    }
}
