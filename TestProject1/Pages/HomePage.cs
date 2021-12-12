using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Pages
{
    public class HomePage : DriverHelper
    {
        IWebElement lnkLogin => driver.FindElement(By.LinkText("Login"));
        IWebElement lnkLogOff => driver.FindElement(By.LinkText("Log off"));

        public void ClickLogin() => lnkLogin.Click();

        public bool IsLogOffButtonExist => lnkLogOff.Displayed;
    }
}
