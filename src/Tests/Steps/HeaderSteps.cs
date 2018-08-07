using Framework.Lib.Services;
using TechTalk.SpecFlow;

namespace Tests.Steps
{
    [Binding]
    public class HeaderSteps
    {
        [Given(@"User search item by query ""(.*)""")]
        [When(@"User search item by query ""(.*)""")]
        public void UserSearchItemByQuery(string query)
        {
            new YandexMarketService()
                .SearchByQuery(query);
        }

        [Given(@"User sign in with login ""(.*)"" and password ""(.*)""")]
        [When(@"User sign in with login ""(.*)"" and password ""(.*)""")]
        public void UserClicksLoginButton(string login, string password)
        {
            new YandexMarketService()
                .Login(login, password);
        }
    }
}
