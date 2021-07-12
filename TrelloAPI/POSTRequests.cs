using RestSharp;
using System.Collections.Generic;

namespace TrelloAPI
{
    public class PostRequests : BaseRequest
    {
        public void CreateBoard(string boardName)
        {
            var parameters = new Dictionary<string, string>
            {
                {"name", boardName }
            };
            var createBoardRequest = CreateRequest("boards", method: Method.POST, parameters: parameters);

            BaseRestClient.Response(createBoardRequest);
        }

        public void CreateList(string boardName, string listName)
        {
            var board = new GetRequests();
            var parameters = new Dictionary<string, string>
            {
                {"name", listName },
                {"idBoard", board.GetSpecificBoard(boardName).Id  }
            };
            var createListRequest = CreateRequest("lists", method: Method.POST, parameters: parameters);

            BaseRestClient.Response(createListRequest);
        }

        public void CreateWorkSpace(string workspaceName)
        {
            var parameters = new Dictionary<string, string>
            {
                {"displayName", workspaceName },
            };
            var createWorkspaceRequest = CreateRequest("organizations", method: Method.POST, parameters: parameters);
            BaseRestClient.Response(createWorkspaceRequest);
        }
    }
}
