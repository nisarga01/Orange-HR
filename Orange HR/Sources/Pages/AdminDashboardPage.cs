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
    public class AdminDashboardPage
    {
        IWebDriver _webDriver;

        [FindsBy(How = How.XPath, Using = "//a[@class='oxd-main-menu-item active']")]
        private IWebElement Admin;

        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Add']")]
        private IWebElement EditUser;
        public AdminDashboardPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            PageFactory.InitElements(_webDriver, this);
        }
        public WebDriverWait GetWebDriverWait()
        {
            return new WebDriverWait(_webDriver, TimeSpan.FromSeconds(15));
        }
        public void AdminInDashboard()
        {
            GetWebDriverWait().Until(driver => Admin.Displayed && Admin.Enabled);
            Admin.Click();

        }
        public void AddAdmin()
        {
            GetWebDriverWait().Until(driver => EditUser.Displayed && EditUser.Enabled);
            EditUser.Click();
        }

    }
}
