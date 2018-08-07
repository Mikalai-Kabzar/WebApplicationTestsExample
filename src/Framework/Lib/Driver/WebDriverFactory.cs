using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Framework.Lib.Driver
{
    public enum Driver
    {
        Chrome,
        Firefox
    }

    public class WebDriverFactory
    {
        public static IWebDriver GetDriver(Driver driverType, DriverOptions options)
        {
            var directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + Config.Default.DriverPath;
            var timeout = TimeSpan.FromMilliseconds(Config.Default.ExplicitWait);
            switch (driverType)
            {
                case Driver.Chrome:
                    return new ChromeDriver(ChromeDriverService.CreateDefaultService(directory), options as ChromeOptions, timeout);
                case Driver.Firefox:
                    return new FirefoxDriver(FirefoxDriverService.CreateDefaultService(directory), options as FirefoxOptions, timeout);
            }

            return null;
        }
    }
}
