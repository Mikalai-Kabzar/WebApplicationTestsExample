using System;
using Framework.Lib.Driver;
using Framework.Tools.Logger;
using OpenQA.Selenium;

namespace Framework.Lib.Pages
{
    public class PageObject : IPageObject
    {
        private readonly TimeSpan _timeout = TimeSpan.FromMilliseconds(Config.Default.ImplicitWait);
        private readonly Logger _logger = new Logger(typeof(PageObject));

        public By Locator { get; set; }

        public PageObject() { }

        public PageObject(By locator)
        {
            Locator = locator;
            WaitLoading();
        }

        public void WaitLoading()
        {
            _logger.Debug("Wait for page loading");
            Wait.ElementPresense(Locator, _timeout);
        } 
    }
}
