using Framework.Lib.Pages;
using Framework.Lib.Services;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Tests.Steps
{
    [Binding]
    public class ProductSteps
    {
        [Then(@"Summary contains string ""(.*)""")]
        public void SummaryContainsString(string listItem)
        {
            Assert.That(new YandexMarketService().GetSummaryList(), Does.Contain(listItem));
        }
    }
}
