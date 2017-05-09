using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Testing_1
{
    public static class CreateAccount
    {
        public static void Go()
        {
            Driver.Instance.Navigate().GoToUrl("https://crmdev.diamondgroup.net.au/main.aspx");

            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
           // wait.
        }

        public static bool HasTerritory()
        {
            var element = Driver.Instance.FindElement(By.Id("dict_territory_label"));
            string test = element.Text;
            return (test != "" && test != null);
        }


        public static bool HasSubTerritory()
        {
            var element = Driver.Instance.FindElement(By.Id("dict_subterritory_label"));
            string test = element.Text;
            return (test != "" && test != null);
        }
    }
}
