using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject1 
{
    public class CustomControls : DriverHelper
    {
        public static void ComboBox(string controlName, string value)
        {
            IWebElement comboControl = driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            comboControl.Clear();
            comboControl.SendKeys(value);
            driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();
        }

        public static void EnterText(IWebElement webElement, string value) => webElement.SendKeys(value);

        public static void Click(IWebElement webElement) => webElement.Click();

        public static void SelectByValue(IWebElement webElement)
        {
            
        }
    }
}
