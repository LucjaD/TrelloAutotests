namespace TrelloAutotests
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string userName, string password)
        {
            Username = userName;
            Password = password;
        }
    }
}
