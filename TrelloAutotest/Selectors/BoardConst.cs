using OpenQA.Selenium;

namespace TrelloAutotest.Selectors
{
    public static class BoardConst 
    {
        public static By BoardHeader = By.ClassName("boards-page-section-header-name");
        public static By BoardMenu = By.ClassName("board-menu-navigation");
        public static By BoardMenuMore = By.ClassName("js-open-more");
        public static By BoardCloseBoard = By.ClassName("js-close-board");

        public static By BoardTitleInput = By.XPath("//input[@data-test-id='create-board-title-input']");
        public static By BoardCreateButton = By.XPath("//button[@data-test-id='create-board-submit-button']");

    }
}
