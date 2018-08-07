using Framework.Lib.Driver;
using TechTalk.SpecFlow;

namespace Tests.Steps
{
    [Binding]
    public class CommonSteps
    {
        [Given(@"User goes to ""(.*)""")]
        [When(@"User goes to ""(.*)""")]
        public void UserGoesTo(string url)
        {
            Browser.Instance.Url = url;
        }

        [Given(@"User switches to tab with index ""(.*)""")]
        [When(@"User switches to tab with index ""(.*)""")]
        public void UserSwitchesToTabWithIndex(int index)
        {
            Browser.Instance.SwitchToTab(index);
        }
    }
}
