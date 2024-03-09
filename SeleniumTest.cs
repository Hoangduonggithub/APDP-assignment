
using NUnit.Framework;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

using System.Collections.ObjectModel;

using System.IO;

namespace SeleniumCsharp

{

    public class Tests
    {
        IWebDriver driver;

        public object ExpectedConditions { get; private set; }

        [OneTimeSetUp]
        public void Setup()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            driver = new ChromeDriver(path + @"\drivers\");
        }

        [Test]
        public void verifyLogo()
        {
            driver.Navigate().GoToUrl("https://www.youtube.com/");
            Assert.IsTrue(driver.FindElement(By.Id("logo-icon")).Displayed); // Example selector for YouTube logo
        }
        [Test]
        public void verifyVideoPlayback()
        {
            driver.Navigate().GoToUrl("https://www.youtube.com/watch?v=dQw4w9WgXcQ"); // Rickroll video
            IWebElement videoPlayer = driver.FindElement(By.CssSelector("video.html5-main-video"));
            Assert.IsTrue(videoPlayer.Displayed);
            Assert.IsTrue(videoPlayer.Enabled);
            // Assuming the video player is present and active on the video page
        }
        [Test]
        public void verifyHomePageTitle()
        {
            driver.Navigate().GoToUrl("https://www.youtube.com/");
            Assert.AreEqual("YouTube", driver.Title); // Verify the title of the YouTube homepage
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
