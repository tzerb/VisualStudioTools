using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WatiN.Core;
using InsuranceAppWebUI.Obits;
using WatiN.Core.DialogHandlers;
using InsuranceAppWebUI.Model;

namespace InsuranceAppWebUI
{
    [TestClass]
    public class ObituaryAddTests : TestBase
    {
        private string PopulateTestPage(ObituaryAdd oa, Browser browser)
        {
            var firstName = string.Format("DecFirst{0:MMddyyyy_hhmmss}", DateTime.Now);
            var lastName = string.Format("DecLast{0:MMddyyyy_hhmmss}", DateTime.Now);

            oa.txtDecFirstName = firstName;
            oa.txtDecLastName = lastName;

            oa.cmdDayDeath.Options[3].Select();
            oa.cmdMonthDeath.Options[3].Select();
            oa.drpMemorialDeathYear.Options[3].Select();

            oa.txtContactFirstName = "ConFirst";
            oa.txtContactLastName = "ConLast";

            oa.txtContactPhone = "9205551212";

            oa.txtObituary = "[center]Centered[/center]";
            browser.Eval("window.eaaRichEdit.update()");
            var previewDiv = (ElementContainer<Element>)browser.Element(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_view_text"));
            Assert.AreEqual(previewDiv.InnerHtml, "<center>Centered</center>");

            return firstName;
        }
        [TestMethod]
        public void RequiredFields()
        {
            using (var browser = BrowseTo("/en/eaa/apps/obituaries/obituary-add"))
            {
                ObituaryAdd oa = new ObituaryAdd(browser);
                oa.Submit.Click();

                var decFirstNameSpan = (ElementContainer<Element>)browser.Element(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_RequiredFieldValidatorDecFirstName"));
                Assert.IsTrue(decFirstNameSpan.Style.Display != "none");
                Assert.IsTrue(decFirstNameSpan.Text.ToLower().Contains("required"));

                var decLastNameSpan = (ElementContainer<Element>)browser.Element(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_RequiredFieldValidatorDecLastName"));
                Assert.IsTrue(decLastNameSpan.Style.Display != "none");
                Assert.IsTrue(decLastNameSpan.Text.ToLower().Contains("required"));

                var contactFirstNameSpan = (ElementContainer<Element>)browser.Element(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_RequiredFieldValidatorContactLastName"));
                Assert.IsTrue(contactFirstNameSpan.Style.Display != "none");
                Assert.IsTrue(contactFirstNameSpan.Text.ToLower().Contains("required"));

                var contactLastNameSpan = (ElementContainer<Element>)browser.Element(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_RequiredFieldValidatorContactFirstName"));
                Assert.IsTrue(contactLastNameSpan.Style.Display != "none");
                Assert.IsTrue(contactLastNameSpan.Text.ToLower().Contains("required"));

                var emailOrPhoneSpan = (ElementContainer<Element>)browser.Element(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_valEmailPhone"));
                Assert.IsTrue(emailOrPhoneSpan.Style.Display != "none");
                Assert.IsTrue(emailOrPhoneSpan.Text.ToLower().Contains("please enter an email address or a phone number"));

                oa.txtContactEmail = "invalidemailaddress";
                oa.Submit.Click();

                Assert.IsTrue(emailOrPhoneSpan.Style.Display == "none");

                var emailAddressSpan = (ElementContainer<Element>)browser.Element(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_valObitContactEmail"));
                Assert.IsTrue(emailAddressSpan.Style.CssText.Contains("visibility: visible;"));
                Assert.IsTrue(emailAddressSpan.Text.ToLower().Contains("invalid"));

                oa.txtContactEmail = "valid@emailaddress.com";
                oa.Submit.Click();

                Assert.IsTrue(emailOrPhoneSpan.Style.Display == "none");
                Assert.IsTrue(emailAddressSpan.Style.CssText.Contains("visibility: hidden;"));

                oa.txtContactFirstName = "first";
                oa.txtContactLastName = "last";
                oa.txtDecFirstName = "first";
                oa.txtDecLastName = "last";

                oa.Submit.Click();

                var obitPhotoSpan = (ElementContainer<Element>)browser.Element(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_CustomValidatorPhotoObit"));
                Assert.IsTrue(obitPhotoSpan.Style.Display != "none");
                Assert.IsTrue(obitPhotoSpan.Text.ToLower().Contains("please enter an obituary or a photo!"));

                oa.txtObituary = "txtObituary";
                oa.Submit.Click();

                //
                var dateOfDeathSpan = (ElementContainer<Element>)browser.Element(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_lblMyCheckDeath"));
                Assert.IsTrue(dateOfDeathSpan.Style.Display != "none");
                Assert.IsTrue(dateOfDeathSpan.Text.ToLower().Contains("required!"));

                oa.cmdDayDeath.Options[3].Select();
                oa.cmdMonthDeath.Options[3].Select();
                oa.drpMemorialDeathYear.Options[103].Select();

                oa.Submit.Click();

                var thanksSpan = (ElementContainer<Element>)browser.Element(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_lblMessage"));
                Assert.IsTrue(thanksSpan.InnerHtml.Contains("Thank you."));
            }
        }

        [TestMethod]
        public void SmokeTestNoImage()
        {
            using (var browser = BrowseTo("/en/eaa/apps/obituaries/obituary-add"))
                
            {
                browser.AutoClose = false;

                ObituaryAdd oa = new ObituaryAdd(browser);
                var firstName = PopulateTestPage(oa, browser);

                oa.Submit.Click();

                var thanksSpan = (ElementContainer<Element>)browser.Element(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_lblMessage"));
                Assert.IsTrue(thanksSpan.InnerHtml.Contains("Thank you."));

                InsuranceAppWebUI.Model.EAA_Memorial_WallEntities mwdb = new Model.EAA_Memorial_WallEntities();
                var obits = mwdb.Obituaries.Where(o => o.DecFirstName == firstName);

                Assert.IsTrue(obits.Count() == 1);

                var obit = obits.FirstOrDefault();
                Assert.IsNotNull(obit);

                Assert.AreEqual(obit.ContactFirstName, "ConFirst");
                Assert.AreEqual(obit.ContactLastName, "ConLast");
                Assert.AreEqual(obit.Obituary1, "[center]Centered[/center]");
            }
        }

        [TestMethod]
        public void SmokeTestWithImage()
        {
            using (var browser = BrowseTo("/en/eaa/apps/obituaries/obituary-add"))
            {
                browser.AutoClose = false;

                ObituaryAdd oa = new ObituaryAdd(browser);
                var firstName = PopulateTestPage(oa, browser);

                oa.FileUpload.Set(TestImage());

                oa.Submit.Click();

                var thanksSpan = (ElementContainer<Element>)browser.Element(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_lblMessage"));
                Assert.IsTrue(thanksSpan.InnerHtml.Contains("Thank you."));

                // Get the entry out of the db and make sure it's correct
                EAA_Memorial_WallEntities mwdb = new Model.EAA_Memorial_WallEntities();
                var obits = mwdb.Obituaries.Where(o => o.DecFirstName == firstName);

                Assert.IsTrue(obits.Count() == 1);

                var obit = obits.FirstOrDefault();
                Assert.IsNotNull(obit);

                Assert.AreEqual(obit.ContactFirstName, "ConFirst");
                Assert.AreEqual(obit.ContactLastName, "ConLast");
                Assert.AreEqual(obit.Obituary1, "[center]Centered[/center]");

                Assert.IsTrue(obit.Photo == "Y");

                // Test the image in the db
                EAA_Memorial_Wall_ContentEntities content = new EAA_Memorial_Wall_ContentEntities();
                var contentImage = content.Contents.Where(c => c.ContentGUID == obit.PhotoID).FirstOrDefault();
                Assert.IsNotNull(contentImage);
            }
        }
    }
}
