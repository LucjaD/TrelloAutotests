namespace TrelloApi
{
    public class Api
    {
        public static void CreateBoard(string boardName)
        {
            var PostRequests = new BoardRequests();
            PostRequests.CreateBoard(boardName);
        }

        public static void DeleteBoard(string boardName)
        {
            var DeleteBoardRequest = new BoardRequests();
            DeleteBoardRequest.DeleteBoard(boardName);
        }

        public static void CreateWorkspace(string workspacedName)
        {
            var PostRequests = new WorkspaceRequests();
            PostRequests.CreateWorkSpace(workspacedName);
        }

        public static void DeleteWorkspace(string workspacedName)
        {
            var deleteWorkspaceRequest = new WorkspaceRequests();
            deleteWorkspaceRequest.DeleteWorkspace(workspacedName);
        }

        public static void CreateList(string boardName, string listName)
        {
            var PostRequests = new ListRequests();
            PostRequests.CreateList(boardName, listName);
        }

    }
}
