using System;
using TechTalk.SpecFlow;
using TideSpecflowProject.PageObjectModel;

namespace TideSpecflowProject.StepDefinitions
{
    [Binding]
    public class TideWebsiteStepDefinitions
    {
        [Given(@"Go to Tide Website for SearchBar")]
        public void GivenGoToTideWebsiteForSearchBar()
        {
            SearchBarMethod.NavigateURL();
        }

        [When(@"website load click on Search bar")]
        public void WhenWebsiteLoadClickOnSearchBar()
        {
            SearchBarMethod.ClickOnSearchBar(); 
        }

        [Then(@"enter data the in search bar")]
        public void ThenEnterDataTheInSearchBar()
        {
            SearchBarMethod.PutValueInSearchBar();
        }

        [Then(@"ScreenShot of SearchBar")]
        public void ThenScreenShotOfSearchBar()
        {
            SearchBarMethod.TakeScreenShot();
        }



        [Given(@"Go to Tide Website for ShopProducts")]
        public void GivenGoToTideWebsiteForShopProducts()
        {
            ShopProducts.NavigateURL();
        }

        [When(@"website load click on shop products")]
        public void WhenWebsiteLoadClickOnShopProducts()
        {
           ShopProducts.ClickButton();
        }

        [Then(@"Select Find retailers")]
        public void ThenSelectFindRetailers()
        {
            ShopProducts.SelectProduct();
        }

        [Then(@"ScreenShot of ShopProducts")]
        public void ThenScreenShotOfShopProducts()
        {
            ShopProducts.TakeScreenShot();
        }



        [Given(@"Go to Tide Website and Load WhatsNew")]
        public void GivenGoToTideWebsiteAndLoadWhatsNew()
        {
            WhatsNewMethod.NavigateURL();
        }

        [When(@"website load click on the Latest Article")]
        public void WhenWebsiteLoadClickOnTheLatestArticle()
        {
            WhatsNewMethod.ClickButton();
        }

        [Then(@"ScreenShot of WhatsNew")]
        public void ThenScreenShotOfWhatsNew()
        {
            WhatsNewMethod.TakeScreenShot();
        }



        [Given(@"Go to Tide Website for LiveChat")]
        public void GivenGoToTideWebsiteForLiveChat()
        {
           LiveChatMethod.NavigateURL();
        }

        [When(@"Website load click on live chat")]
        public void WhenWebsiteLoadClickOnLiveChat()
        {
           LiveChatMethod.ClickOnLiveChat();
        }

        [Then(@"scroll to element")]
        public void ThenScrollToElement()
        {
            LiveChatMethod.ScrollToElement();
        }

        [Then(@"ScreenShot of LiveChat")]
        public void ThenScreenShotOfLiveChat()
        {
            LiveChatMethod.TakeScreenShot();
        }



        [Given(@"Go to Tide Website and Load OurCommitment")]
        public void GivenGoToTideWebsiteAndLoadOurCommitment()
        {
            OurCommitmentMethod.NavigateURL();
        }

        [When(@"Website load click on OurCommitment")]
        public void WhenWebsiteLoadClickOnOurCommitment()
        {
            OurCommitmentMethod.ClickButton();
        }

        [Then(@"ScreenShot of OurCommitment")]
        public void ThenScreenShotOfOurCommitment()
        {
            OurCommitmentMethod.TakeScreenShot();
        }



        [Given(@"Go to Tide Website for PnG")]
        public void GivenGoToTideWebsiteForPnG()
        {
            PnGMethod.NavigateURL();
        }

        [When(@"website load click on PnG section")]
        public void WhenWebsiteLoadClickOnPnGSection()
        {
            PnGMethod.ClickButton();
        }

        [Then(@"click on Explore the Report")]
        public void ThenClickOnExploreTheReport()
        {
            PnGMethod.ExploreTheReport();
        }

        [Then(@"ScreenShot of PnG")]
        public void ThenScreenShotOfPnG()
        {
            PnGMethod.TakeScreenShot();
        }



        [Given(@"Go to Tide Website and load ContactUs")]
        public void GivenGoToTideWebsiteAndLoadContactUs()
        {
            ContactUsMethod.NavigateURL();
        }

        [When(@"Select on the Contact Us")]
        public void WhenSelectOnTheContactUs()
        {
            ContactUsMethod.ClickButton();
        }

        [Then(@"ScreenShot of ContactUs")]
        public void ThenScreenShotOfContactUs()
        {
            ContactUsMethod.TakeScreenShot();
        }



        [Given(@"Go to Tide Website and load CouponsAndRewards")]
        public void GivenGoToTideWebsiteAndLoadCouponsAndRewards()
        {
           CouponsAndRewardsMethod.NavigateURL();   
        }

        [When(@"Click on Coupon and Rewards")]
        public void WhenClickOnCouponAndRewards()
        {
            CouponsAndRewardsMethod.ClickCouponsAndRewards();
        }

        [Then(@"ScreenShot of CouponAndRewardsards")]
        public void ThenScreenShotOfCouponAndRewardsards()
        {
            CouponsAndRewardsMethod.TakeScreenShot();
        }



        [Given(@"Go to Tide Website for LanguageChange")]
        public void GivenGoToTideWebsiteForLanguageChange()
        {
            LanguageChange.NavigateURL();
        }

        [When(@"website load click on the Language")]
        public void WhenWebsiteLoadClickOnTheLanguage()
        {
            LanguageChange.ClickButton();
        }

        [Then(@"Popup open and choose Language")]
        public void ThenPopupOpenAndChooseLanguage()
        {
            LanguageChange.ChooseLanguage(); ;
        }

        [Then(@"ScreenShot of LanguageChange")]
        public void ThenScreenShotOfLanguageChange()
        {
            LanguageChange.TakeScreenShot();
        }



        [Given(@"Go to Tide Website for HowTowashClothes")]
        public void GivenGoToTideWebsiteForHowTowashClothes()
        {
            HowToWashClothes.NavigateURL();
        }

        [When(@"website load click on How to wash clothes")]
        public void WhenWebsiteLoadClickOnHowToWashClothes()
        {
           HowToWashClothes.ClickButton();
        }

        [Then(@"click on How to Remove Stains")]
        public void ThenClickOnHowToRemoveStains()
        {
            HowToWashClothes.ScrollToElement();
        }

        [Then(@"ScreenShot of HowToWashClothes")]
        public void ThenScreenShotOfHowToWashClothes()
        {
            HowToWashClothes.TakeScreenShot();
        }
    }
}
