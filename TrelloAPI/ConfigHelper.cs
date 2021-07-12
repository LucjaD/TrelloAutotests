using Microsoft.Extensions.Configuration;

namespace TrelloAPI
{
    public static class ConfigHelper
    {
        public static IConfiguration InitConfiguration()
        {
            return new ConfigurationBuilder()
                .AddJsonFile("appconfig.json")
                .Build();
        }
    }
}
