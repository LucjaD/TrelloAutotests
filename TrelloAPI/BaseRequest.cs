using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrelloAPI
{
    public class BaseRequest
    {

        protected RestRequest CreateRequest(string prefix, string specificElement = "", Method method = Method.GET, Dictionary<string, string> parameters = null)
        {
            var request = new RestRequest($"/{prefix}/{specificElement}", method);
            request.AddParameter("key", ApiUserData.CorrectTestUser.Key);
            request.AddParameter("token", ApiUserData.CorrectTestUser.Token);

            if (parameters != null)
            {
                foreach (var item in parameters)
                {
                    request.AddParameter(item.Key, item.Value);
                }
            }

            return request;
        }
    }
}
