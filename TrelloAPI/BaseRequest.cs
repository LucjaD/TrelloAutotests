using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrelloApi
{
    public class BaseRequest
    {

        protected RestRequest CreateRequest(string prefix, string specificElement = "", Method method = Method.GET, Dictionary<string, string> parameters = null)
        {
            var request = new RestRequest($"/{prefix}/{specificElement}", method);
            request.AddParameter("key", ApiUserData.CorrectTestUser.Key);
            request.AddParameter("token", ApiUserData.CorrectTestUser.Token);
            parameters?.ToList().ForEach(item => request.AddParameter(item.Key, item.Value));

            return request;
        }
    }
}
