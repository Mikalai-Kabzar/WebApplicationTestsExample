using Framework.Lib.Driver;
using TechTalk.SpecFlow;

namespace Tests.Hooks
{
    [Binding]
    public class SetUp
    {
        [BeforeScenario]
        public static void OpenMainPage()
        {
            Browser.Instance.Maximize();
            Browser.Instance.Url = "https://market.yandex.by/";
        }
    }
}
