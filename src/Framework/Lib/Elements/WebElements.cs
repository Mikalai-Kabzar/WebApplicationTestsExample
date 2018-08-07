using System.Collections.Generic;
using System.Linq;
using Framework.Lib.Driver;
using Framework.Tools.Logger;
using OpenQA.Selenium;

namespace Framework.Lib.Elements
{
    public class WebElements : ICustomElement
    {
        private readonly Logger _logger;

        public readonly By Selector;

        public List<IWebElement> BrowserElements => Browser.Instance.FindElements(Selector).ToList();

        public int Count => BrowserElements.Count;

        public WebElements(By selector)
        {
            Selector = selector;
            _logger = new Logger(typeof(WebElement));
        }

        public string GetAttribute(int index, string attribute)
        {
            _logger.Debug($"Get attribute {attribute} from elements {Selector} with index {index}");
            return BrowserElements[index].GetAttribute(attribute);
        }

        public string GetText(int index)
        {
            _logger.Debug($"Get text from elements {Selector} with index {index}");
            return BrowserElements[index].Text;
        }

        public void Click(int index)
        {
            _logger.Info($"Click element with index {index} from elements {Selector}");
            BrowserElements[index].Click();
        }

        public void SendKeys(int index, string text)
        {
            _logger.Info($"Send keys to element with index {index} from element {Selector}");
            BrowserElements[index].SendKeys(text);
        }

        public void ReplaceKeys(int index, string text)
        {
            _logger.Info($"Replace keys in element with index {index} from elements {Selector}");
            BrowserElements[index].Clear();
            SendKeys(index, text);
        }
    }
}
