using GoogleNews.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace GoogleNews.Steps
{
    [Binding]
    public sealed class GoogleNewsUKSteps
    {
        IWebDriver driver = new ChromeDriver();
      
        [Given(@"the user landed in the google news uk homepage")]
        public void GivenTheUserLandedInTheGoogleNewsUkHomepage()
        {
            GoogleNewsUKHomePage page = new GoogleNewsUKHomePage(driver);
            page.goToGoogleNewsUK();
        }
        
        [Then(@"the user should see the UK section")]
        public void ThenTheUserShouldSeeTheUKSectionAlways()
        {
            GoogleNewsUKHomePage page = new GoogleNewsUKHomePage(driver);
            page.validateSectionHavetheCountry("U.K");
        }

        [Then(@"the user should see the image next to every news story")]
        public void ThenTheUserShouldSeeTheImageNextToEveryNewsStory()
        {
            GoogleNewsUKHomePage page = new GoogleNewsUKHomePage(driver);
            page.validateImage();
        }

       
    }
}
