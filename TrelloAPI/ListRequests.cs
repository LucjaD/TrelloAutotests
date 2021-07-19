using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using TrelloApi;

namespace TrelloApi
{
    public class ListRequests : BaseRequest
    {
        public void CreateList(string boardName, string listName)
        {
            var board = new BoardRequests();
            var parameters = new Dictionary<string, string>
            {
                {"name", listName },
                {"idBoard", board.GetSpecificBoard(boardName).Id  }
            };
            var createListRequest = CreateRequest("lists", method: Method.POST, parameters: parameters);

            BaseRestClient.Response(createListRequest);
        }
    }
}
