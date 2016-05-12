using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InsuranceAppWebUI.Obits;
using WatiN.Core;

namespace InsuranceAppWebUI
{
    /// <summary>
    /// Summary description for MemorialWall
    /// </summary>
    [TestClass]
    public class MemorialWallTests
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
        public void PopulateMemWall()
        {
            using (var browser = new IE("http://dev.eaa.org/apps/airventure/bricks_memorialwall.aspx"))
            {
                browser.AutoClose = false;
                MemorialWall mw = new MemorialWall(browser);
                mw.txtDecFirstName = "First";
                mw.txtDecLastName = "Last";
                mw.txtDecCity = "Forestville";
                mw.ddlDecState.Options[56].Select();

                mw.birthDate = "1/1/2000";
                mw.deathDate = "1/1/2016";
                mw.txtObituary = "[center]Center[/center]";
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
            }
        }
    }
}
