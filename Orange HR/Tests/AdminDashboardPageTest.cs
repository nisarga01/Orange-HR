using OpenQA.Selenium.Support.UI;
using Orange_HR.Drivers;
using Orange_HR.Sources.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_HR.Tests
{
    public class AdminDashboardPageTest:Driver
    {
        [Test]
        public void AdminInDashboard()
        {
            LoginPage lp = new LoginPage(_driver);
            AdminDashboardPage ad = new AdminDashboardPage(_driver);

            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            lp.EnterUserName("Admin");
            lp.EnterPassword("admin123");
            lp.ClickLoginButton();

            // Wait until login completes and dashboard is ready
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.Url.Contains("dashboard"));
            // Navigate to Admin page
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/admin/viewSystemUsers");

            ad.AdminInDashboard();

            Thread.Sleep(6000);
        }
        [Test]
        public void AddNewAdmin()
        {
            LoginPage lp = new LoginPage(_driver);
            AdminDashboardPage ad = new AdminDashboardPage(_driver);

            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            lp.EnterUserName("Admin");
            lp.EnterPassword("admin123");
            lp.ClickLoginButton();

            // Wait until login completes and dashboard is ready
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.Url.Contains("dashboard"));
            // Navigate to Admin page
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/admin/viewSystemUsers");

            ad.AdminInDashboard();
            ad.AddAdmin();

            Thread.Sleep(6000);
        }
    }
}
