using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoSeleniumSemVBA
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new InternetExplorerOptions
            {
                IgnoreZoomLevel = true
            };
            IWebDriver driver = new OpenQA.Selenium.IE.InternetExplorerDriver(options);

            driver.Navigate().GoToUrl("https://www.tomasvasquez.com.br/blog");

            IWebElement elemento = driver.FindElement(By.TagName("h1"));

            Console.WriteLine("O título do site é: {0}", elemento.Text);
            Console.Read();

            driver.Quit();
        }
    }
}
