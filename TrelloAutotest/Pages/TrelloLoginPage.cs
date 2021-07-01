﻿using System.Linq;
using TrelloAutotest.Messages;
using TrelloAutotest.Selectors;

namespace TrelloAutotests.Pages
{
    class TrelloLoginPage : BasePage
    {
        public void Login(User user)
        {
            driver.FindElement(LoginSelectors.User).SendKeys(user.Username);
            driver.FindElement(LoginSelectors.Login).Click();
            driver.FindElement(LoginSelectors.Password).SendKeys(user.Password);
            driver.FindElement(LoginSelectors.LoginButton).Click();
        }

        public bool IsPasswordCorrect() => driver.FindElements(BaseSelectors.IncorrectLoginPanel).Any();

        public bool DoesUserExists() => driver.FindElements(LoginSelectors.ErrorPanel).Any(x => x.Text.Contains(MessageText.AccountDoesNotExists));

    }
}
