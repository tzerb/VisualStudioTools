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

                EAA_Memorial_WallEntities mwdb = new Model.EAA_Memorial_WallEntities();
                var obits = mwdb.Obituaries.Where(o => o.DecFirstName == firstName);

                Assert.IsTrue(obits.Count() == 1);

                var obit = obits.FirstOrDefault();
                Assert.IsNotNull(obit);

                Assert.AreEqual(obit.ContactFirstName, "ConFirst");
                Assert.AreEqual(obit.ContactLastName, "ConLast");
                Assert.AreEqual(obit.Obituary1, "[center]Centered[/center]");

                Assert.IsTrue(obit.Photo == "Y");

                EAA_Memorial_Wall_ContentEntities content = new EAA_Memorial_Wall_ContentEntities();
                var contentImage = content.Contents.Where(c => c.ContentGUID == obit.PhotoID).FirstOrDefault();
                Assert.IsNotNull(contentImage);
            }
        }
    }
}
