using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrelloAPI
{
    public class GETRequests
    {
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
            var GetAllBoardsRequest = new GETRequests();
            return GetAllBoardsRequest.GetBoardsList().First(x => x.name == boardName);
        }
    }
}
