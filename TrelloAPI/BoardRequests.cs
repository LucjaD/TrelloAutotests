using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrelloApi
{
    public class BoardRequests : BaseRequest
    {
        public void DeleteBoard(string boardName)
        {
            var getRequest = new BoardRequests();
            var deleteBoardRequest = CreateRequest("boards", getRequest.GetSpecificBoard(boardName).Id, Method.DELETE);
            BaseRestClient.Response(deleteBoardRequest);
        }

        public List<BoardProperties> GetBoardsList()
        {
            var request = CreateRequest("members/me/boards");
            var restResponse = BaseRestClient.Response(request);
            var response = restResponse.Content;
            return JsonConvert.DeserializeObject<List<BoardProperties>>(response);
        }

        public BoardProperties GetSpecificBoard(string boardName)
        {
            var getRequest = new BoardRequests();
            return getRequest.GetBoardsList().First(x => x.Name == boardName);
        }

        public void CreateBoard(string boardName)
        {
            var parameters = new Dictionary<string, string>
            {
                {"name", boardName }
            };
            var createBoardRequest = CreateRequest("boards", method: Method.POST, parameters: parameters);

            BaseRestClient.Response(createBoardRequest);
        }
    }
}
