namespace TrelloAPI
{
    public class APIUser
    {
        public string Key { get; set; }
        public string Token { get; set; }

        public APIUser(string key, string token)
        {
            Key = key;
            Token = token;
        }
    }
}
