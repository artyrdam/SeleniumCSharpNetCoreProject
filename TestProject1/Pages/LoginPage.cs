using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Pages
{
    public class LoginPage :DriverHelper
    {
        //this is like assigning to a variable but to a method instead
        IWebElement textUserName => driver.FindElement(By.Id("UserName"));
        IWebElement textPassword => driver.FindElement(By.Id("Password"));
        IWebElement btnLogin => driver.FindElement(By.ClassName("btn-default"));


        public void EnterUserNameAndPassword(string userName, string password)
        {
            textUserName.SendKeys(userName);
            textPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
        }
    }
}
