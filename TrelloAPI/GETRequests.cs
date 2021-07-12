using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace TrelloAPI
{
    public class GetRequests : BaseRequest
    {
        public List<BoardProperties> GetBoardsList()
        {
            var request = CreateRequest("members/me/boards");
            var restResponse = BaseRestClient.Response(request);
            var response = restResponse.Content;
            return JsonConvert.DeserializeObject<List<BoardProperties>>(response);
        }

        public BoardProperties GetSpecificBoard(string boardName)
        {
            var _GetRequest = new GetRequests();
            return _GetRequest.GetBoardsList().First(x => x.Name == boardName);
        }

        public List<WorkspaceProperties> GetWorkspacesNames()
        {
            var getWorkspacesRequest = CreateRequest("Members/me/organizations");
            var restResponse = BaseRestClient.Response(getWorkspacesRequest);
            var response = restResponse.Content;
            return JsonConvert.DeserializeObject<List<WorkspaceProperties>>(response);
        }

        public WorkspaceProperties GetSpecificWorkspace(string workspaceName)
        {
            var _GetRequest = new GetRequests();
            return _GetRequest.GetWorkspacesNames().First(x => x.DisplayName == workspaceName);
        }
    }
}
