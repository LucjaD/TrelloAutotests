using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrelloAPI
{
    public class DELETERequests
    {
        public void DeleteBoard(string boardName)
        {
            var board = new GETRequests();
            RestRequest deleteBoardRequest = new RestRequest($"/boards/{board.GetSpecificBoard(boardName).id}?key={APIUserData.CorrectTestUser.Key}&token={APIUserData.CorrectTestUser.Token}", Method.DELETE);
            IRestResponse deleteResponse = BaseRestClient.Response(deleteBoardRequest);
        }
    }
}
