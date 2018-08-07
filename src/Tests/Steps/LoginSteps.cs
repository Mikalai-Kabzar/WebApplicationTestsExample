using Framework.Lib.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Tests.Steps
{
    [Binding]
    public class LoginSteps
    {
        [Then(@"User sees following error message: ""(.*)""")]
        public void UserSeesFollowingErrorMessage(string message)
        {
            Assert.That(new LoginPage().GetFormErrorDivText(), Is.EqualTo(message));
        }
    }
}