using TrelloAutotests;

namespace TrelloAutotest
{
    public static class Users
    {
        public static readonly User CorrectTestUser = new User("","");
        public static readonly User IncorrectTestUser = new User("example@gmail.com", "password");
    }
}
