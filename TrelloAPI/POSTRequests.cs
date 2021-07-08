using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrelloAPI
{
    public class POSTRequests
    {
        public void CreateBoard(string boardName)
        {
            RestRequest createBoardRequest = new RestRequest($"/boards/?key={APIUserData.CorrectTestUser.Key}&token={APIUserData.CorrectTestUser.Token}&name={boardName}", Method.POST);
            IRestResponse createResponse = BaseRestClient.Response(createBoardRequest);
        }

        public void CreateList(string boardName ,string listName)
        {
            var board = new GETRequests();
            RestRequest createListRequest = new RestRequest($"/lists?key={APIUserData.CorrectTestUser.Key}&token={APIUserData.CorrectTestUser.Token}&name={listName}&idBoard={board.GetSpecificBoard(boardName).id}", Method.POST);
            IRestResponse createResponse = BaseRestClient.Response(createListRequest);
        }

        public void CreateWorkSpace(string workspaceName)
        {
            RestRequest createWorkspaceRequest = new RestRequest($"/organizations?key={APIUserData.CorrectTestUser.Key}&token={APIUserData.CorrectTestUser.Token}&displayName={workspaceName}", Method.POST);
            IRestResponse createResponse = BaseRestClient.Response(createWorkspaceRequest);
        }
    }
}
