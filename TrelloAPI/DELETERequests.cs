using RestSharp;

namespace TrelloAPI
{
    public class DeleteRequests : BaseRequest 
    {
        public void DeleteBoard(string boardName)
        {
            var _GETRequest = new GetRequests();
            var deleteBoardRequest = CreateRequest("boards", _GETRequest.GetSpecificBoard(boardName).Id, Method.DELETE);
            BaseRestClient.Response(deleteBoardRequest);
        }

        public void DeleteWorkspace(string workspaceName)
        {
            var _GETRequest = new GetRequests();
            var deleteWorkspaceRequest =  CreateRequest("organizations", _GETRequest.GetSpecificWorkspace(workspaceName).Name, Method.DELETE);
            BaseRestClient.Response(deleteWorkspaceRequest);
        }
    }
}
