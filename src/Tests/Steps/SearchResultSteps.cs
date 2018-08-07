using Framework.Lib.Services;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Tests.Steps
{
    [Binding]
    public class SearchResultSteps
    {
        [Then(@"User can see item with name ""(.*)""")]
        public void UserCanSeeItemWithName(string name)
        {
            var item = new YandexMarketService().GetSearchResultByName(name);
            Assert.That(item, Is.Not.Null);
        }

        [Then(@"All result items contain titles corresponding to query ""(.*)""")]
        public void AllResultItemsContainTitlesCorrespondingToQuery(string query)
        {
            var results = new YandexMarketService().GetSearchResults();
            foreach (var result in results)
            {
                Assert.That(result.Title, Does.Contain(query));
            }
        }
    }
}
