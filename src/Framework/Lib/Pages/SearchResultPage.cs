using System.Collections.Generic;
using Framework.Lib.Driver;
using Framework.Lib.Elements;
using Framework.Lib.Entities.Objects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Framework.Lib.Pages
{
    public class SearchResultPage : PageObject
    {
        private static string ResultArrayXpathLocator = "//div[contains(@data-id,'model')]";
        private static string ResultTitleXpathLocator = "//div[contains(@class,'title')]/a";
        private static string ResultPriceXpathLocator = "//div[contains(@class,'main-price')]";

        private WebElements Results = new WebElements(By.XPath(ResultArrayXpathLocator));
        private WebElements ResultsTitles = new WebElements(By.XPath(ResultArrayXpathLocator + ResultTitleXpathLocator));
        private WebElements ResultsPrices = new WebElements(By.XPath(ResultArrayXpathLocator + ResultPriceXpathLocator));

        public List<SearchResult> GetResults()
        {
            List<SearchResult> result = new List<SearchResult>();
            for (int index = 0; index < Results.Count; index++)
            {
                result.Add(new SearchResult
                {
                    Title = ResultsTitles.GetText(index),
                    Price = ResultsPrices.GetText(index)
                });
            }

            return result;
        }

        public SearchResult GetResult(string title)
        {
            for (int index = 0; index < Results.Count; index++)
            {
                var resultTitle = ResultsTitles.GetAttribute(index, "title");
                if (resultTitle.Contains(title))
                {
                    return new SearchResult
                    {
                        Title = resultTitle,
                        Price = ResultsPrices.GetText(index)
                    };
                };
            }

            return null;
        }
    }
}
