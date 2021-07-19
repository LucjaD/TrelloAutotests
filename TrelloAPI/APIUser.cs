namespace TrelloApi
{
    public class ApiUser
    {
        public string Key { get; set; }
        public string Token { get; set; }

        public ApiUser(string key, string token)
        {
            Key = key;
            Token = token;
        }
    }
}
