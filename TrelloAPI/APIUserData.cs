namespace TrelloApi
{
    public static class ApiUserData
    {
        public static readonly ApiUser CorrectTestUser = new ApiUser(ConfigHelper.InitConfiguration()["ApiData:Key"], ConfigHelper.InitConfiguration()["ApiData:Token"]);
    }
}
