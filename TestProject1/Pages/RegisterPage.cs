using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Pages
{
    public class RegisterPage : DriverHelper
    {
        IWebElement textUserName => driver.FindElement(By.Id("UserName"));
        IWebElement textPassword => driver.FindElement(By.Id("Password"));
        IWebElement textConfirmPasswpord => driver.FindElement(By.Id("ConfirmPassword"));
        IWebElement textEmail => driver.FindElement(By.Id("Email"));
        IWebElement btnRegister => driver.FindElement(By.ClassName("btn-default"));


        public string registerPageUrl => driver.Url;

        public void EnterRegistrationDetails(string userName, string password, string confirmPassword, string email)
        {
            textUserName.SendKeys(userName);
            textPassword.SendKeys(password);
            textConfirmPasswpord.SendKeys(confirmPassword);
            textEmail.SendKeys(email);
            
        }

        public void ClickRegister() => btnRegister.Click();

    }
}
