using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Lib.Driver;
using Framework.Lib.Elements;
using OpenQA.Selenium;

namespace Framework.Lib.Pages.Common
{
    public class Header : PageObject
    {
        private static string SearchInputCssSelector = "#header-search";
        private static string SearchSubmitButtonCssSelector = ".search2__button > .button2";
        private static string RegionButtonCssSelector = ".header2-menu__item_type_region";
        private static string LoginButtonCssSelector = ".header2-nav__content .user__login";

        private WebElement SearchInput = new WebElement(By.CssSelector(SearchInputCssSelector));
        private WebElement SearchSubmit = new WebElement(By.CssSelector(SearchSubmitButtonCssSelector));
        private WebElement RegionButton = new WebElement(By.CssSelector(RegionButtonCssSelector));
        private WebElement LoginButton = new WebElement(By.CssSelector(LoginButtonCssSelector));

        public string GetRegionName() => RegionButton.GetText();

        public Header SendKeysToSearchInput(string query)
        {
            SearchInput.ReplaceKeys(query);
            return this;
        }

        public void ClickSearchSubmitButton() => SearchSubmit.Click();

        public Header ClickSwitchRegionButton()
        {
            RegionButton.Click();
            return this;
        }

        public void ClickLoginButton()
        {
            LoginButton.Click();
            Browser.Instance.SwitchToTab(1);
        }
    }
}
