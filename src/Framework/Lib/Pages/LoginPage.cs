using Framework.Lib.Elements;
using OpenQA.Selenium;

namespace Framework.Lib.Pages
{
    public class LoginPage : PageObject
    {
        private static string LoginInputCssSelector = "input[name='login']";
        private static string PasswordInputCssSelector = "input[name='passwd']";
        private static string SubmitButtonCssSelector = "button[type='submit']";
        private static string FormErrorDivCssSelector = ".passport-Domik-Form-Error";

        private WebElement LoginInput = new WebElement(By.CssSelector(LoginInputCssSelector));
        private WebElement PasswordInput = new WebElement(By.CssSelector(PasswordInputCssSelector));
        private WebElement SubmitInput = new WebElement(By.CssSelector(SubmitButtonCssSelector));
        private WebElement FormErrorDiv = new WebElement(By.CssSelector(FormErrorDivCssSelector));

        public LoginPage SendKeysLoginInput(string text)
        {
            LoginInput.SendKeys(text);
            return this;
        }

        public LoginPage SendKeysPasswordInput(string text)
        {
            PasswordInput.SendKeys(text);
            return this;
        }

        public void ClickConfirmButton() => SubmitInput.Click();

        public string GetFormErrorDivText()
        {
            return FormErrorDiv.GetText();
        }
    }
}