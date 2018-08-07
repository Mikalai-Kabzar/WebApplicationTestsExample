using Framework.Lib.Driver;
using Framework.Tools.Logger;
using OpenQA.Selenium;

namespace Framework.Lib.Elements
{
    public class WebElement : ICustomElement
    {
        private readonly Logger _logger;
        public readonly By Selector;
        
        public IWebElement BrowserElement => Browser.Instance.FindElement(Selector);

        public WebElement(By selector)
        {
            Selector = selector;
            _logger = new Logger(typeof(WebElement));
        }

        public string GetAttribute(string attribute)
        {
            _logger.Debug($"Get attribute {attribute} of element {Selector}");
            return BrowserElement.GetAttribute(attribute);
        }

        public string GetText()
        {
            _logger.Info($"Get text of element {Selector}");
            return BrowserElement.Text;
        }

        public void Click()
        {
            _logger.Info($"Click element {Selector}");
            BrowserElement.Click();
        }

        public void SendKeys(string text)
        {
            _logger.Info($"Send keys {text} to element {Selector}");
            BrowserElement.SendKeys(text);
        }

        public void ReplaceKeys(string text)
        {
            _logger.Info($"Replace keys on {text} of element {Selector}");
            BrowserElement.Clear();
            SendKeys(text);
        }
    }
}
