using System;
using System.Collections.ObjectModel;
using Framework.Tools.Logger;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace Framework.Lib.Driver
{
    public class Browser
    {
        private static Browser _instanse;
        private static string BrowserName = Config.Default.Browser.ToUpper();
        private readonly ILogger _logger;


        public readonly IWebDriver WebDriver;

        public static Browser Instance
        {
            get
            {
                if (_instanse is null)
                {
                    Logger.Init();

                    Driver browser;
                    DriverOptions options;

                    switch (BrowserName)
                    {
                        case "CHROME":
                            browser = Driver.Chrome;
                            options = new ChromeOptions();
                            break;
                        case "FIREFOX":
                            browser = Driver.Firefox;
                            options = new FirefoxOptions();
                            break;
                        default:
                            browser = Driver.Chrome;
                            options = new ChromeOptions();
                            break;
                    }

                    _instanse = new Browser(WebDriverFactory.GetDriver(browser, options));
                }
                
                return _instanse;
            }
        }
        public string Url
        {
            get => WebDriver.Url;
            set => WebDriver.Url = value;
        }

        private Browser(IWebDriver webDriver)
        {
            WebDriver = webDriver;
            _logger = new Logger(typeof(Browser));
            _logger.Debug(BrowserName + " instance created");
        }

        public void SwitchToTab(int index)
        {
            WebDriver.SwitchTo().Window(WebDriver.WindowHandles[index]);
        }

        public IWebElement FindElement(By by)
        {
            Wait.ElementPresense(by, TimeSpan.FromMilliseconds(Config.Default.ImplicitWait));
            return WebDriver.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return WebDriver.FindElements(by);
        }

        public void Maximize()
        {
            Instance.WebDriver.Manage().Window.Maximize();
        }

        public void Close()
        {
            WebDriver.Quit();
            _instanse = null;
            _logger.Debug(BrowserName + " instance closed");
        }
    }
}
