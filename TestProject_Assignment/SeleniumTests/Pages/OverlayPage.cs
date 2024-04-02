using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using System.Xml.Linq;
using NUnit.Framework;
using NUnit.Framework.Internal.Commands;
using OpenQA.Selenium.Interactions;

namespace TestProject_Assignment.SeleniumTests.Pages
{
    public class OverlayPage : BasePage
    {
        public OverlayPage(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        private IWebElement thumbnail => driver.FindElement(By.XPath("//img[contains(@src, \"./assets/images/WHITE-2.webp\")]"));
        private IWebElement closeOverlay => driver.FindElement(By.XPath("//button[contains(@class, 'close-button-container__button')]"));
        private IWebElement productView => driver.FindElement(By.XPath("//div[@class=\"product-view\"]"));
        private IWebElement articleNameOnArticlesList => driver.FindElement(By.XPath("//div[contains(@class,'product-page__card')][1]//div[contains(@class, 'product-page__name')]"));
        private IWebElement articlePriceOnArticlesList => driver.FindElement(By.XPath("//div[contains(@class,'product-page__card')][1]//div[contains(@class, 'product-page__price')]"));
        private IWebElement articlePictureOnOverlay => driver.FindElement(By.XPath("//div[contains(@class, 'lazy-image cursor-zoom-in product-gallery__carousel-item')][1]/img"));
        private IWebElement articleNameOnOverlay => driver.FindElement(By.XPath("//div[contains(@class, 'product-detail__name')]"));
        private IWebElement articlePriceOnOverlay => driver.FindElement(By.XPath("//div[@class= 'product-detail__price']"));
        private IList<IWebElement> articleColors => driver.FindElements(By.XPath("//div[contains(@class, 'product-detail__color-options')]/input"));
        private IList<IWebElement> tabsList => driver.FindElements(By.XPath("//ul[contains(@class,\"product-info__tab-list\")]/li"));
        private IWebElement productDetailsTab => driver.FindElement(By.XPath("//ul[contains(@class,\"product-info__tab-list\")]/li[1]"));
        private IWebElement fitTab => driver.FindElement(By.XPath("//ul[contains(@class,\"product-info__tab-list\")]/li[2]"));
        private IWebElement materialCareInstructionsTab => driver.FindElement(By.XPath("//ul[contains(@class,\"product-info__tab-list\")]/li[3]"));
        private IWebElement sustainabilityTab => driver.FindElement(By.XPath("//ul[contains(@class,\"product-info__tab-list\")]/li[4]"));
        private IWebElement productDetailsTabInfo => driver.FindElement(By.XPath("//div[contains(@class,\"product-details-tab__content\")]"));
        private IWebElement fitTabInfo => driver.FindElement(By.XPath("//div[@class=\"fit-tab\"]"));
        private IWebElement materialCareInstructionsTabInfo => driver.FindElement(By.XPath("//div[@class=\"material-care-tab\"]"));
        private IWebElement sustainabilityTabInfo => driver.FindElement(By.XPath("//div[@class=\"sustainability-tab\"]"));
        private IWebElement articleNameInFooter => driver.FindElement(By.XPath("//div[contains(@class,\"product-sticky-footer__name\")]"));
        private IWebElement addToCartInFooter => driver.FindElement(By.XPath("//button[@type=\"submit\"]"));
        private IList<IWebElement> slideshowImagesLocator => driver.FindElements(By.XPath("//div[contains(@class, 'lazy-image cursor-zoom-in product-gallery__carousel-item')]/img"));
        private IList<IWebElement> availableSizesLocator => driver.FindElements(By.XPath("//div[@class='product-detail__size-options']/button[not(@disabled)]"));
        private IWebElement targetColorSelectionLocator => driver.FindElement(By.XPath("//input[@src='./assets/images/BLACK-2.webp']"));
        private IWebElement targetColorLabel => driver.FindElement(By.XPath("//div[@class='product-detail__color-label']/span"));

        //Methods to click on elements
        public void ClickOnThumbnail()
        {
            //thumbnail.Click();
            Actions actions = new Actions(driver);
            actions.MoveToElement(thumbnail).Click().Perform();
            Thread.Sleep(5000);
        }

        public void ClickOnFitTab()
        {
            fitTab.Click();
            Thread.Sleep(2000);
        }

        public void ClickOnMaterialCareInstructionsTab()
        {
            materialCareInstructionsTab.Click();
            Thread.Sleep(2000);
        }

        public void ClickOnSustainabilityTab()
        {
            sustainabilityTab.Click();
            Thread.Sleep(2000);
        }

        public void ClickOnCloseOverlay()
        {
            closeOverlay.Click();
            Thread.Sleep(2000);
        }

        //Methods to verify element present on the page
        public bool IsThumbnailClickable()
        {
            ClickOnThumbnail();
            if (productView.Displayed)
                return true;
            else
                return false;
        }

        public bool IsArticleNamePresent()
        {
            ClickOnThumbnail();
            if (articleNameOnOverlay.Displayed)
                return true;
            else
                return false;
        }

        public bool IsArticlePricePresent()
        {
            ClickOnThumbnail();
            if (articlePriceOnOverlay.Displayed)
                return true;
            else
                return false;
        }

        public bool IsArticlePicturePresent()
        {
            ClickOnThumbnail();
            if (articlePictureOnOverlay.Displayed)
                return true;
            else
                return false;

        }

        public bool IsProductDetailsTabInfoDisplayed()
        {
            ClickOnThumbnail();
            if (productDetailsTabInfo.Displayed)
                return true;
            else
                return false;

        }

        public bool IsFitTabClickable()
        {
            ClickOnThumbnail();
            ClickOnFitTab();
            if (fitTabInfo.Displayed)
                return true;
            else
                return false;
        }

        public bool IsMaterialCareInstructionsTabClickable()
        {
            ClickOnThumbnail();
            ClickOnMaterialCareInstructionsTab();
            if (materialCareInstructionsTabInfo.Displayed)
                return true;
            else
                return false;
        }
        public bool IsSustainabilityTabClickable()
        {
            ClickOnThumbnail();
            ClickOnSustainabilityTab();
            if (sustainabilityTabInfo.Displayed)
                return true;
            else
                return false;
        }

        public bool IsArticleNameInFooterDisplayed()
        {
            ClickOnThumbnail();
            if (articleNameInFooter.Displayed)
                return true;
            else
                return false;
        }

        public bool IsAddToCartInFooterDisplayed()
        {
            ClickOnThumbnail();
            if (addToCartInFooter.Displayed)
                return true;
            else
                return false;
        }

        public bool IsOverlayClosable()
        {
            ClickOnThumbnail();
            ClickOnCloseOverlay();
            if (thumbnail.Displayed)
                return true;
            else
                return false;
        }

        //Methods to verify data on Articles list page and Overlay are same
        public bool IsArticleNameSameOnOverlay()
        {
            string aNameOnArticlesList = articleNameOnArticlesList.Text;
            ClickOnThumbnail();
            string aNameOnoverlay = articleNameOnOverlay.Text;
            if (aNameOnoverlay== aNameOnArticlesList)
                return true;
            else
                return false;
        }

        public bool IsArticlePriceSameOnOverlay()
        {
            string aPriceOnArticlesList = articlePriceOnArticlesList.Text;
            ClickOnThumbnail();
            string aPriceOnoverlay = articlePriceOnOverlay.Text;
            if (aPriceOnoverlay == aPriceOnArticlesList)
                return true;
            else
                return false;
        }

        //This method checks if the article has minimum one color/size option
        public bool IsArticleHasColorOptions()
        {
            ClickOnThumbnail();
            if (articleColors.Count > 0)
                return true;
            else
                return false;

        }

        public bool IsArticleHasSizeOptions()
        {
            ClickOnThumbnail();
            if (availableSizesLocator.Count > 0)
                return true;
            else
                return false;

        }

        public List<string> GetListOfTabs()
        {
            List<string> ListOfTabs = new List<string> ();
            ClickOnThumbnail();
            Console.WriteLine(tabsList.Count);

            foreach (var tabElement in tabsList)
            {
                ListOfTabs.Add(tabElement.Text);
            }
            return ListOfTabs;
        }

        //Methods to verify footer sticky
        public bool IsFooterSticky(IWebElement footer)
        {
            int footerPositionBeforeScroll = footer.Location.Y;
            
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");

            int footerPositionAfterScroll = footer.Location.Y;
            
            if (footerPositionBeforeScroll <= footerPositionAfterScroll)
                return true;
            else
                return false;
        }

        public bool IsArticleNameInFooterSticky()
        {
            return IsFooterSticky(articleNameInFooter);
        }

        public bool IsAddToCartInFooterSticky()
        {
            return IsFooterSticky(addToCartInFooter);
        }

        public String IsSelectedColorAndLabelEqual()
        {
            ClickOnThumbnail();
            targetColorSelectionLocator.Click();
            Console.WriteLine(targetColorLabel.Text);
            return targetColorLabel.Text;
        }

        private List<string> GetSlideshowImages()
        {
            List<string> slideshowImages = new List<string>();
            foreach (var image in slideshowImagesLocator)
                slideshowImages.Add(image.GetAttribute("src"));
            return slideshowImages;
        }

        private List<string> GetAvailableSizes()
        {
            List<string> availableSizes = new List<string>();
            foreach (var sizes in availableSizesLocator)
                availableSizes.Add(sizes.Text);
            return availableSizes;
        }

        public void IsColorSelectionChangesImagesAndSizes()
        {
            ClickOnThumbnail();
            List<string> initialSlideshowImages = GetSlideshowImages();
            List<string> initialAvailableSizes = GetAvailableSizes();
            
            targetColorSelectionLocator.Click();
            Thread.Sleep(4000);
            
            List<string> updatedSlideshowImages = GetSlideshowImages();
            List<string> updatedAvailableSizes = GetAvailableSizes();
            
            try
            {
                CollectionAssert.AreNotEqual(initialSlideshowImages, updatedSlideshowImages);
                SlideshowImagesChanged = true;
            }
            catch (Exception)
            {
                SlideshowImagesChanged = false;
            }

            try
            {
                CollectionAssert.AreNotEqual(initialAvailableSizes, updatedAvailableSizes);
                AvailableSizesChanged = true;
            }
            catch (Exception)
            {
                AvailableSizesChanged = false;
            }


        }
        public bool SlideshowImagesChanged { get; private set; }
        public bool AvailableSizesChanged { get; private set; }

        public bool IsWebsiteResponsive()
        {
            try
            {
                ClickOnThumbnail();
                return productView.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
