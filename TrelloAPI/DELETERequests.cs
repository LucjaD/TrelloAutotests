using RestSharp;

namespace TrelloAPI
{
    public class DeleteRequests : BaseRequest 
    {
        public void DeleteBoard(string boardName)
        {
            var getRequest = new GetRequests();
            var deleteBoardRequest = CreateRequest("boards", getRequest.GetSpecificBoard(boardName).Id, Method.DELETE);
            BaseRestClient.Response(deleteBoardRequest);
        }

        public void DeleteWorkspace(string workspaceName)
        {
            var getRequest = new GetRequests();
            var deleteWorkspaceRequest =  CreateRequest("organizations", getRequest.GetSpecificWorkspace(workspaceName).Name, Method.DELETE);
            BaseRestClient.Response(deleteWorkspaceRequest);
        }
    }
}
