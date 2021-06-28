namespace TrelloAutotest.Selectors
{
    public static class MainConst
    {
        public const string AddBoardPanel = "mod-add";

        public const string AddBoardButton = "//span[contains(text(),'Utwórz tablicę')]";

        public const string CreateWorkSpace = "//span[contains(text(),'Utwórz przestrzeń roboczą')]";

        public static string OpenBoard(string boardName) => $"//div[@title = '{boardName}']";

        public const string SearchIcon = "//span[@aria-label = 'SearchIcon']";
        public const string SearchInput = "input[data-test-id='header-search-input']";
        public const string SearchResult = "[data-test-id = 'header-search-popover']";

        public const string CreateTab = "//button[@aria-label = 'Utwórz tablicę lub Przestrzeń roboczą']";
    }
}
