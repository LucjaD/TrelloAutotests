namespace TrelloAPI
{
    public class Api
    {
        public static void CreateBoard(string boardName)
        {
            var POSTRequests = new PostRequests();
            POSTRequests.CreateBoard(boardName);
        }

        public static void DeleteBoard(string boardName)
        {
            var DeleteBoardRequest = new DeleteRequests();
            DeleteBoardRequest.DeleteBoard(boardName);
        }

        public static void CreateWorkspace(string workspacedName)
        {
            var POSTRequests = new PostRequests();
            POSTRequests.CreateWorkSpace(workspacedName);
        }

        public static void DeleteWorkspace(string workspacedName)
        {
            var deleteWorkspaceRequest = new DeleteRequests();
            deleteWorkspaceRequest.DeleteWorkspace(workspacedName);
        }

        public static void CreateList(string boardName, string listName)
        {
            var POSTRequests = new PostRequests();
            POSTRequests.CreateList(boardName, listName);
        }

    }
}
