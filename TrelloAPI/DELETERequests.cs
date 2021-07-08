using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrelloAPI
{
    public class DELETERequests
    {
        private GETRequests _GETRequest;
        public void DeleteBoard(string boardName)
        {
            _GETRequest = new GETRequests();
            RestRequest deleteBoardRequest = new RestRequest($"/boards/{_GETRequest.GetSpecificBoard(boardName).id}?key={APIUserData.CorrectTestUser.Key}&token={APIUserData.CorrectTestUser.Token}", Method.DELETE);
            IRestResponse deleteResponse = BaseRestClient.Response(deleteBoardRequest);
        }

        public void DeleteWorkspace(string workspaceName)
        {
            _GETRequest = new GETRequests();
            RestRequest deleteWorkspaceRequest = new RestRequest($"/organizations/{_GETRequest.GetSpecificWorkspace(workspaceName).name}?key={APIUserData.CorrectTestUser.Key}&token={APIUserData.CorrectTestUser.Token}", Method.DELETE);
            IRestResponse deleteResponse = BaseRestClient.Response(deleteWorkspaceRequest);

        }
    }
}
