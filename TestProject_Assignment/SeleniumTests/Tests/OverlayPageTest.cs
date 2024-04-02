using Microsoft.VisualBasic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject_Assignment.SeleniumTests.Pages;

namespace TestProject_Assignment.SeleniumTests.Tests
{
    [TestFixture]
    public class OverlayPageTest : BaseTest
    {
        private OverlayPage overlayPage;

        [SetUp]
        public void SetUpOverlayPage()
        {
            overlayPage = new OverlayPage(driver, wait);
        }

        [Test]
        public void VerifyIsThumbnailClickable()
        {
            Assert.IsTrue(overlayPage.IsThumbnailClickable(), "Thumbnail is not clickable and overlay is not displayed");

        }

        [Test]
        public void VerifyIsOverlayClosable()
        {
            Assert.IsTrue(overlayPage.IsOverlayClosable(), "Overlay is not able to close");

        }

        [Test]
        public void VerifyIsArticleNamePresent()
        {
            Assert.IsTrue(overlayPage.IsArticleNamePresent(), "Article name isn't displayed");

        }

        [Test]
        public void VerifyIsArticleNameSameOnOverlay()
        {
            Assert.IsTrue(overlayPage.IsArticleNameSameOnOverlay(), "Article name on articles list and overlay are not same");

        }

        [Test]
        public void VerifyIsArticlePriceSameOnOverlay()
        {
            Assert.IsTrue(overlayPage.IsArticlePriceSameOnOverlay(), "Article Price on articles list and overlay are not same");

        }

        [Test]
        public void VerifyIsArticlePricePresent()
        {
            Assert.IsTrue(overlayPage.IsArticlePricePresent(), "Article price isn't displayed");

        }

        [Test]
        public void VerifyIsArticlePicturePresent()
        {
            Assert.IsTrue(overlayPage.IsArticlePicturePresent(), "Article picture isn't displayed");

        }

        [Test]
        public void VerifyIsArticleHasColorOptions()
        {
            Assert.IsTrue(overlayPage.IsArticleHasColorOptions(), "Article does not have color options");

        }

        [Test]
        public void VerifyIsArticleHasSizeOptions()
        {
            Assert.IsTrue(overlayPage.IsArticleHasSizeOptions(), "Article does not have size options");

        }

        [Test]
        public void VerifyProductViewTabs()
        {
            List<string> expectedTabs = new List<string> { "PRODUCT DETAILS", "FIT", "MATERIAL & CARE INSTRUCTIONS", "SUSTAINABILITY" };
            List<string> actualTabs = overlayPage.GetListOfTabs();
            CollectionAssert.AreEqual(expectedTabs, actualTabs, "Tabs are not as expected");

        }

        [Test]
        public void VerifyIsProductDetailsTabInfoDisplayed()
        {
            Assert.IsTrue(overlayPage.IsProductDetailsTabInfoDisplayed(), "Product Details info isn't available");

        }

        [Test]
        public void VerifyIsFitTabClickableANDInfoDisplayed()
        {
            Assert.IsTrue(overlayPage.IsFitTabClickable(), "Fit tab info isn't available");

        }

        [Test]
        public void VerifyIsMaterialCareInstructionsTabClickableANDInfoDisplayed()
        {
            Assert.IsTrue(overlayPage.IsMaterialCareInstructionsTabClickable(), "MaterialCareInstructions tab info isn't available");

        }

        [Test]
        public void VerifyIsSustainabilityTabClickableANDInfoDisplayed()
        {
            Assert.IsTrue(overlayPage.IsSustainabilityTabClickable(), "Sustainability tab info isn't available");

        }

        //
        [Test]
        public void VerifyArticleNameInFooterDisplayedAndSticky()
        {
            Assert.IsTrue(overlayPage.IsArticleNameInFooterDisplayed(), "Article Name in footer isn't available");
            Assert.That(overlayPage.IsArticleNameInFooterSticky(), "Article name in footer is not sticky");

        }

        [Test]
        public void VerifyAddToCartInFooterDisplayedAndSticky()
        {
            Assert.IsTrue(overlayPage.IsAddToCartInFooterDisplayed(), "Add to cart in footer isn't available");
            Assert.That(overlayPage.IsAddToCartInFooterSticky(), "Add to cart in footer is not sticky");

        }

        [Test]
        public void VerifyIsColorSelectionChangesImagesAndSizes()
        {
            overlayPage.IsColorSelectionChangesImagesAndSizes();
            Assert.IsTrue(overlayPage.SlideshowImagesChanged, "Images did not change after selecting different color");
            Assert.That(overlayPage.AvailableSizesChanged, "Sizes did not change after selecting different color");

        }

        [Test]
        public void VerifyIsSelectedColorAndLabelEqual()
        {
            Assert.AreEqual("BLACK", overlayPage.IsSelectedColorAndLabelEqual(), "Selected color is different that displayed one");
            
        }

        [Test]
        public void VerifyResponsiveLayout()
        {
            int[] viewports = { 320, 768, 1024, 1200 }; 
            foreach (int width in viewports)
            {
                driver.Manage().Window.Size = new System.Drawing.Size(width, 800);
                bool isResponsive = overlayPage.IsWebsiteResponsive();
                Assert.IsTrue(isResponsive, $"Website is not responsive at viewport width {width}px");
            }
        }
    }

}
