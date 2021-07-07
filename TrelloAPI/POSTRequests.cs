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
    }
}
