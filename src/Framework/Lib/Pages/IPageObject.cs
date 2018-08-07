using OpenQA.Selenium;

namespace Framework.Lib.Pages
{
    public interface IPageObject
    {
        By Locator { get; set; }
        void WaitLoading();
    }
}
