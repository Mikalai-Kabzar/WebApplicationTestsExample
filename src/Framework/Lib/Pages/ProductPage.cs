using System.Collections.Generic;
using Framework.Lib.Elements;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Framework.Lib.Pages
{
    public class ProductPage : PageObject
    {
        private static string SummaryListCssSelector = ".n-product-spec-list";
        private static string SummaryListItemCssSelector = SummaryListCssSelector + ">li";

        private WebElements SummaryListItems = new WebElements(By.CssSelector(SummaryListItemCssSelector));

        public List<string> GetSummaryList()
        {
            List<string> result = new List<string>();
            for (int index = 0; index < SummaryListItems.Count; index++)
            {
                result.Add(SummaryListItems.GetText(index));
            }

            return result;
        }
    }
}
