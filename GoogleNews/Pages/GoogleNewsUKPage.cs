using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace GoogleNews.Pages
{
    public class GoogleNewsUKHomePage
    {
        private IWebDriver driver;
        public GoogleNewsUKHomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".KaRWed.XogBlf")]
        private IWebElement header;


        [FindsBy(How = How.CssSelector, Using = ".JPdR6b.Zdjuef")]
        public IWebElement section;


        public void goToGoogleNewsUK()
        {
            driver.Navigate().GoToUrl("https://news.google.com/news/headlines?hl=en-GB&ned=us");
            driver.Manage().Window.Maximize();
        }

        public void validateSectionHavetheCountry(String country)
        {
            try
            {
                Assert.True(section.Text.Contains(country));
            } finally
            {
                driver.Quit();
            }
        }

        public void validateImage()
        {
            IList<IWebElement> imageElements = header.FindElements(By.CssSelector(".PaqQNc"));

            foreach (IWebElement imageElement in imageElements)
            {
                try
                {
                    IWebElement img = imageElement.FindElement(By.CssSelector(".lmFAjc"));
                    Assert.IsTrue(img.Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Assert.IsTrue(false);
                   Console.WriteLine("Img not displayed");
                }
                finally
                {
                    driver.Quit();
                }
              
            }
        }

        [AfterScenario("tearDown")]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
