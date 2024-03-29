﻿using Microsoft.Extensions.Configuration;
using System.Configuration;
using TrelloApi;
using TrelloAutotests;

namespace TrelloAutotest
{
    public static class Users
    {
        public static readonly User CorrectTestUser = new User(ConfigHelper.InitConfiguration()["LoginData:UserName"], ConfigHelper.InitConfiguration()["LoginData:Password"]);
    }
}
