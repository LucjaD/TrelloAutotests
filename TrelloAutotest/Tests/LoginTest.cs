﻿using NUnit.Framework;
using TrelloAutotest.Pages;
using TrelloAutotests;
using TrelloAutotests.Pages;
using TrelloAutotests.Tests;

namespace TrelloAutotest.Tests
{
    class LoginTest : BaseTest
    {
        private TrelloLoginPage _trelloLoginPage;
        [SetUp]
        public override void SetUp()
        {
            StartBrowser();
            var trelloWelcomePage = new TrelloWelcomePage();
            trelloWelcomePage.LoginButton.Click();
            _trelloLoginPage = new TrelloLoginPage();
        }

        [Test]
        public void CorrectLogin()
        {
            _trelloLoginPage.
                EnterUserName(Users.CorrectTestUser).
                DoesUserExists().
                Login(Users.CorrectTestUser).
                IsPasswordCorrect().
                IsLoginCorrect();
        }
    }
}
