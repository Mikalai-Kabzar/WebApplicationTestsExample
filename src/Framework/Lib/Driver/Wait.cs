using System;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Lib.Driver
{
    public class Wait
    {
        public static void ElementEnabled(By locator, TimeSpan timeout)
        {
            new WebDriverWait(Browser.Instance.WebDriver, timeout)
                .Until(driver => driver.FindElement(locator).Enabled);
        }

        public static void ElementPresense(By locator, TimeSpan timeout)
        {
            new WebDriverWait(Browser.Instance.WebDriver, timeout)
                .Until(driver => driver.FindElement(locator).Displayed);
        }

        public static void ElementSize(By locator, TimeSpan timeout, Size size)
        {
            new WebDriverWait(Browser.Instance.WebDriver, timeout)
                .Until(driver => driver.FindElement(locator).Size.Equals(size));
        }
    }
}
