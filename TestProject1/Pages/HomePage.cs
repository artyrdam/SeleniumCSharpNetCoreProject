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
        IWebElement lnkRegister => driver.FindElement(By.LinkText("Register"));
        IWebElement lnkEmployeeList => driver.FindElement(By.LinkText("Employee List"));
        IWebElement lnkAbout => driver.FindElement(By.LinkText("About"));
        IWebElement lnkHome => driver.FindElement(By.LinkText("Home"));
        IWebElement lnkVisitNow => driver.FindElement(By.XPath("/html/body/div[2]/div[1]/table/tbody/tr/td/a"));



        public void ClickLogin() => lnkLogin.Click();
        public void ClickLogOff() => lnkLogOff.Click();
        public void ClickRegister() => lnkRegister.Click();
        public void ClicjEmployeeList() => lnkEmployeeList.Click();
        public void ClickAbout() => lnkAbout.Click();
        public void ClickHome() => lnkHome.Click();
        public void ClickVisitNow() => lnkVisitNow.Click();

        public bool IsLogOffButtonExist => lnkLogOff.Displayed;

    }
}
