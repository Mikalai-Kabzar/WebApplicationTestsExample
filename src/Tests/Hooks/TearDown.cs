using Framework.Lib.Driver;
using TechTalk.SpecFlow;

namespace Tests.Hooks
{
    [Binding]
    public class TearDown
    {
        [AfterScenario]
        public static void CloseBrowser()
        {
            Browser.Instance.Close();
        }
    }
}
