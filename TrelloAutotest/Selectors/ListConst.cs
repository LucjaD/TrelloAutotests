namespace TrelloAutotest.Selectors
{
    public static class ListConst
    {
        public const string CreateList = "//span[contains(text(), 'Dodaj ') and contains(text(), 'listę')]";
        public const string ListNameInput = "//input[@placeholder = 'Wprowadź tytuł listy']";
        public const string AddListButton = "mod-list-add-button";

        public const string ListHeaderName = "list-header-name";

        public const string ListHeader = ".list-header ";
        public const string ListActions = "[aria-label='Akcje listy']";
        public const string ListArchive = "//a[contains(text(),'Zarchiwizuj tę listę')]";
    }
}
