using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_HR.Sources.Pages
{
    public class LoginPage
    {
        IWebDriver _webDriver;

        [FindsBy(How = How.CssSelector, Using = "input[placeholder='Username']")]
        private IWebElement UserName;

        [FindsBy(How = How.CssSelector, Using = "input[placeholder='Password']")]
        private IWebElement Password;

        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Login']")]
        private IWebElement Login;

        public LoginPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            PageFactory.InitElements(_webDriver, this);
        }
        public WebDriverWait GetWebDriverWait()
        {
            return new WebDriverWait(_webDriver, TimeSpan.FromSeconds(15));
        }
        public void EnterUserName(string name)
        {
            GetWebDriverWait().Until(driver => UserName.Displayed && UserName.Enabled);
            UserName.SendKeys(name);

        }
        public void EnterPassword(string password)
        {
            GetWebDriverWait().Until(driver => Password.Displayed && Password.Enabled);
            Password.SendKeys(password);
        }
        public void ClickLoginButton()
        {
            
            GetWebDriverWait().Until(driver => Login.Displayed && Login.Enabled);
            Login.Click();
        }
    }
}
