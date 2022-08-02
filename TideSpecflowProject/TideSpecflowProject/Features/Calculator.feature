Feature: Tide Website


	@SearchBar
	Scenario: To verify Search Bar
		Given Go to Tide Website for SearchBar
		When website load click on Search bar
		Then enter data the in search bar 
		And ScreenShot of SearchBar


	@ShopProducts
	Scenario: To verify Shop Products  
		Given Go to Tide Website for ShopProducts
		When website load click on shop products
		Then Select Find retailers
		And ScreenShot of ShopProducts


	@WhatsNew
	Scenario: To verify Whats New Section 
		Given Go to Tide Website and Load WhatsNew
		When website load click on the Latest Article
		Then ScreenShot of WhatsNew
	

	@LiveChat
	Scenario: To verify Live Chat Section
		Given Go to Tide Website for LiveChat
		When Website load click on live chat
		Then scroll to element
		And ScreenShot of LiveChat


	@OurCommitment
	Scenario: To verify Our Commitment Section
		Given Go to Tide Website and Load OurCommitment
		When Website load click on OurCommitment 
		Then ScreenShot of OurCommitment

	@PnGFile
	Scenario: To verify PnG section
		Given Go to Tide Website for PnG
		When website load click on PnG section
		Then click on Explore the Report
		And ScreenShot of PnG
		

	@ContactUs
	Scenario: To verify ContactUs Section
		Given Go to Tide Website and load ContactUs
		When Select on the Contact Us
		Then ScreenShot of ContactUs

	@CouponAndRewards
	Scenario: To verify Coupon And Rewards Section
		Given Go to Tide Website and load CouponsAndRewards
		When Click on Coupon and Rewards
		Then ScreenShot of CouponAndRewardsards 
		

	@LanguageChange
	Scenario: To verify Home Screen Language Section
		Given Go to Tide Website for LanguageChange
		When website load click on the Language
		Then Popup open and choose Language
		And ScreenShot of LanguageChange 


	@HowToWashClothes
	Scenario: To verify How to Wash Clothes
		Given Go to Tide Website for HowTowashClothes
		When website load click on How to wash clothes
		Then click on How to Remove Stains
		And ScreenShot of HowToWashClothes

