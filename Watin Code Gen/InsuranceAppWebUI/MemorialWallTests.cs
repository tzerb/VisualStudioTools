using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InsuranceAppWebUI.Obits;
using WatiN.Core;
using WatiN.Core.DialogHandlers;

namespace InsuranceAppWebUI
{
    /// <summary>
    /// Summary description for MemorialWall
    /// </summary>
    [TestClass]
    public class MemorialWallTests : TestBase
    {
        public MemorialWallTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void RequiredFields()
        {
            using (var browser = new IE("http://dev.eaa.org/apps/airventure/bricks_memorialwall.aspx"))
            {
                browser.AutoClose = false;
                MemorialWall mw = new MemorialWall(browser);
                mw.SubmitButton.Click();

                Assert.AreEqual(mw.txtDecFirstNameLabel, "This field is required.");
                Assert.AreEqual(mw.txtDecLastNameLabel, "This field is required.");
                Assert.AreEqual(mw.deathDateLabel, "This field is required.");
                Assert.AreEqual(mw.BrickInscription01Label, "This field is required.");
                Assert.AreEqual(mw.firstNameLabel, "This field is required.");
                Assert.AreEqual(mw.lastNameLabel, "This field is required.");
                Assert.AreEqual(mw.addressLabel, "This field is required.");
                Assert.AreEqual(mw.cityLabel, "This field is required.");
                Assert.AreEqual(mw.ddlStateLabel, "This field is required.");
                Assert.AreEqual(mw.zipLabel, "This field is required.");
                Assert.AreEqual(mw.AreaCodeLabel, "This field is required.");
                Assert.AreEqual(mw.PhoneNumberLabel, "This field is required.");
                Assert.AreEqual(mw.emailLabel, "This field is required.");
                Assert.AreEqual(mw.CreditCardLabel, "This field is required.");
                Assert.AreEqual(mw.ddlCreditCardExpirationMonthLabel, "This field is required.");
                Assert.AreEqual(mw.ddlCreditCardExpirationYearLabel, "This field is required.");
                Assert.AreEqual(mw.CVCLabel, "This field is required.");
            }
        }

        [TestMethod]
        public void PopulateMemWall()
        {
            //using (var browser = new IE("http://qa.eaa.org/apps/airventure/bricks_memorialwall.aspx"))
            using (var browser = new IE("http://www.eaa.org/apps/airventure/bricks_memorialwall.aspx"))
            {
                browser.AutoClose = false;
                MemorialWall mw = new MemorialWall(browser);
                mw.txtDecFirstName = DateTime.Now.ToString("MMddyyyy_hhmmss");
                mw.txtDecLastName = "Last";
                mw.txtDecCity = "Forestville";
                mw.ddlDecState.Options[56].Select();

                mw.birthDate = "1/1/2000";
                mw.deathDate = "1/1/2016";
                mw.txtObituary = "[center]The [b]formatted [/b][i]obituary [/i]will show up [u]here[/u].[/center]";
                mw.NotesComments = "Notes / Comments";

                mw.firstName = "First";
                mw.lastName = "Last";
                mw.city = "Forestville";
                mw.address = "123 Address";
                mw.ddlState.Options[56].Select();
                mw.PhoneNumber = "5551212";
                mw.AreaCode = "920";
                mw.zip = "55555";
                mw.email = "tzirbel@eaa.org";
                mw.CreditCard = "4111111111111111";
                mw.CVC = "111";
                mw.ddlCreditCardExpirationMonth.Options[10].Select();
                mw.ddlCreditCardExpirationYear.Options[2].Select();

                mw.BrickInscription01 = "BrickInscription01";
                mw.BrickInscription02 = "BrickInscription01";

                //AlertDialogHandler alertDialogHandler = new AlertDialogHandler();

                //using (new UseDialogOnce(browser.DialogWatcher, alertDialogHandler))
                //{
                //    mw.FileUpload.Set(TestImage);
                //    alertDialogHandler.WaitUntilExists(10 /*seconds*/);

                //    if (!alertDialogHandler.Exists())
                //    {
                //        Assert.Fail("No JavaScript alert when it should have been there");
                //    }

                //    alertDialogHandler.OKButton.Click();
                //}

                mw.SubmitButton.Click();

                string s1 = browser.NativeDocument.Url;
                string s2 = browser.Url;

                browser.WaitForComplete();
            }       
        }
    }
}
