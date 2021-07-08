using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrelloAPI
{
    public class GETRequests
    {
        private GETRequests _GetRequest;
        public List<BoardProperties> GetBoardsList()
        {
            RestRequest request = new RestRequest($"/members/me/boards?key={APIUserData.CorrectTestUser.Key}&token={APIUserData.CorrectTestUser.Token}", Method.GET);
            IRestResponse restResponse = BaseRestClient.Response(request);

            var response = restResponse.Content;
            var BoardProperties = new BoardProperties();
            return BoardProperties.GetBoardsFromJSON(response);
        }

        public BoardProperties GetSpecificBoard(string boardName)
        {
            _GetRequest = new GETRequests();
            return _GetRequest.GetBoardsList().First(x => x.name == boardName);
        }

        public List<WorkspaceProperties> GetWorkspacesNames()
        {
            RestRequest getWorkspacesRequest = new RestRequest($"/Members/me/organizations?key={APIUserData.CorrectTestUser.Key}&token={APIUserData.CorrectTestUser.Token}", Method.GET);
            IRestResponse restResponse = BaseRestClient.Response(getWorkspacesRequest);

            var response = restResponse.Content;
            var WorkspaceProperties = new WorkspaceProperties();

            return WorkspaceProperties.GetWorkspacesFromJSON(response);
        }

        public WorkspaceProperties GetSpecificWorkspace(string workspaceName)
        {
            _GetRequest = new GETRequests();
            return _GetRequest.GetWorkspacesNames().First(x => x.displayName == workspaceName);
        }
    }
}
