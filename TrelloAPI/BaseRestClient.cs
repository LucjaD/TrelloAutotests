using RestSharp;

namespace TrelloAPI
{
    public static class BaseRestClient
    {
        public static RestClient RestClientInstance { get; private set; }
        public static void ClientConnection(string url) => RestClientInstance = new RestClient(url);

        public static IRestResponse Response(RestRequest request) => RestClientInstance.Execute(request);
    }
}
