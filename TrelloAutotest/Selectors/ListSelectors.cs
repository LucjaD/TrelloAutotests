using OpenQA.Selenium;

namespace TrelloAutotest.Selectors
{
    public static class ListSelectors
    {
        public static By CreateListButton = By.XPath("//span[contains(text(), 'Dodaj ') and contains(text(), 'listę')]");
        public static By ListNameInput = By.XPath("//input[@placeholder = 'Wprowadź tytuł listy']");
        public static By AddListButton = By.ClassName("mod-list-add-button");

        public static By ListHeaderName = By.ClassName("list-header-name");

        public static By ListHeader = By.CssSelector(".list-header ");
        public static By ListActions = By.CssSelector("[aria-label='Akcje listy']");
        public static By ListArchive = By.XPath("//a[contains(text(),'Zarchiwizuj tę listę')]");

        public static By AddCardButton = By.ClassName("open-card-composer");
    }
}
