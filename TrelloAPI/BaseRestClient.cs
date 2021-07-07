using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrelloAPI
{
    public static class BaseRestClient
    {
        private static RestClient _restClient;
        public static RestClient RestClientInstance { get => _restClient; }

        public static void ClientConnection(string url) => _restClient = new RestClient(url);

        public static IRestResponse Response(RestRequest request) => _restClient.Execute(request);
    }
}
