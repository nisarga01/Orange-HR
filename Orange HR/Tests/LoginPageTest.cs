using Orange_HR.Drivers;
using Orange_HR.Sources.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_HR.Tests
{
    public class LoginPageTest:Driver
    {
        [Test]
        public void Login()
        {
            LoginPage lp = new LoginPage(_driver);
            
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            lp.EnterUserName("Admin");
            lp.EnterPassword("admin123");
            lp.ClickLoginButton();
            

            // Store the main window handle before switching
            string mainWindow = _driver.CurrentWindowHandle;

            // Wait until a new tab opens
            //lp.GetWebDriverWait().Until(driver => driver.WindowHandles.Count > 1);

            // Switch to the new tab (Google login)
            foreach (string handle in _driver.WindowHandles) // ❌ Fix: Don't use lp.GetWebDriverWait().WindowHandles
            {
                if (handle != mainWindow)
                {
                    _driver.SwitchTo().Window(handle); // ❌ Fix: Use _driver, not _webDriver
                    break;
                }
            }
            Thread.Sleep(6000); 
        }
    }
}
