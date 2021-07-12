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
            var getRequest = new GetRequests();
            return getRequest.GetBoardsList().First(x => x.Name == boardName);
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
            var getRequest = new GetRequests();
            return getRequest.GetWorkspacesNames().First(x => x.DisplayName == workspaceName);
        }
    }
}
