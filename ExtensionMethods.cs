using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTests_AutomationPracticeCom
{
    public static class ExtensionMethods
    {
        public static void SelectElementFromDropDownByName(this IWebElement element, string name)
        {
            var selectElement = new SelectElement(element);
            selectElement.SelectByText(name);
        }

        // To use when Date is filled in CreateAccountPage
        public static void SelectDateFromDropDown(IWebElement dayElement, IWebElement monthElement, IWebElement yearElement,
            int day, int month, int year)
        {
            var selectElementDay = new SelectElement(dayElement);
            selectElementDay.SelectByText(day.ToString());
            var selectElementMonth = new SelectElement(monthElement);
            selectElementMonth.SelectByText(month.ToString());
            var selectElementYear = new SelectElement(yearElement);
            selectElementYear.SelectByText(year.ToString());
        }
    }
}
