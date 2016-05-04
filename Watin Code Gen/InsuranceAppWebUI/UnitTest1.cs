using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WatiN.Core;
using WatiN.Core.Constraints;
using System.Text.RegularExpressions;
using System.Text;

namespace InsuranceAppWebUI
{
    public class USPersonalInformationPage
    {
        private IE browser;
        public USPersonalInformationPage(IE bro)
        {
            browser = bro;
        }

        public string txtEAANumber { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtEAANumber")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtEAANumber")).Value = value; } }
        public string txtContactNameFirst { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtContactNameFirst")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtContactNameFirst")).Value = value; } }
        public string txtContactNameMiddle { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtContactNameMiddle")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtContactNameMiddle")).Value = value; } }
        public string txtContactNameLast { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtContactNameLast")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtContactNameLast")).Value = value; } }
        public string txtNamedInsured { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtNamedInsured")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtNamedInsured")).Value = value; } }
        public string txtAddress1 { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtAddress1")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtAddress1")).Value = value; } }
        public string txtAddress2 { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtAddress2")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtAddress2")).Value = value; } }
        public string txtCity { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtCity")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtCity")).Value = value; } }
        public string txtZipCode { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtZipCode")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtZipCode")).Value = value; } }
        public string txtEmailAddress { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtEmailAddress")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtEmailAddress")).Value = value; } }
        public string txtDaytimePhone { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtDaytimePhone")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtDaytimePhone")).Value = value; } }
        public string txtVintageAircraftAssociation { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtVintageAircraftAssociation")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtVintageAircraftAssociation")).Value = value; } }
        public string txtInternationalAerobaticClub { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtInternationalAerobaticClub")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtInternationalAerobaticClub")).Value = value; } }
        public string txtWarbirdsofAmerica { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtWarbirdsofAmerica")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtWarbirdsofAmerica")).Value = value; } }
        public string txtAircraftOwnersPilotsAssociation { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtAircraftOwnersPilotsAssociation")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtAircraftOwnersPilotsAssociation")).Value = value; } }
        public string txtAntiqueAircraft { get { return browser.TextField(Find.ById("txtAntiqueAircraft")).Value; } set { browser.TextField(Find.ById("txtAntiqueAircraft")).Value = value; } }

    }

    [TestClass]
    public class UnitTest1
    {
        private void USPopulatePersonalInfoPage(IE browser)
        {

            var pi = new USPersonalInformationPage(browser);
            pi.txtEAANumber = "1";

            // Populate personal info page
            pi.txtContactNameFirst = "First";
            pi.txtContactNameMiddle= "Middle";
            pi.txtContactNameLast = "Last";

            pi.txtAddress1= "Address1";
            pi.txtZipCode= "54025";

            pi.txtDaytimePhone = "2628930720";
            pi.txtCity = "City";
            pi.txtEmailAddress = "tzirbel@eaa.org";

            OptionCollection stateOptions = browser.SelectList("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_ddlState").Options;
            stateOptions[3].Select();
        }

        private void USPopulateAircraftPage(IE browser, string tag)
        {
            browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtAircraftFAANumber")).Value = tag;
            browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtAircraftYear")).Value = tag;
            browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtAircraftMake")).Value = tag;
            browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtAircraftModel")).Value = tag;

            browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtTotalSeats")).Value = tag;
            browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtEngineMake")).Value = tag;

            OptionCollection aircraftUse = browser.SelectList("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_ddlAircraftUse").Options;
            aircraftUse[3].Select();

            OptionCollection gearConfiguration = browser.SelectList("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_ddlGearConfiguration").Options;
            gearConfiguration[3].Select();

            OptionCollection hullCoverage = browser.SelectList("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_ddlHullCoverage").Options;
            hullCoverage[3].Select();

            browser.RadioButton(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_rbLimits_2")).Click();

            browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtHullValue")).Value = tag;

            OptionCollection medicalPayments = browser.SelectList("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_ddlMedicalPayments").Options;
            medicalPayments[3].Select();

            browser.RadioButton(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_cbxQuoteFor_1")).Click();

            browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtAirportName")).Value = tag;

            browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtHullValue")).Value = tag;

            OptionCollection aircraftStatus = browser.SelectList("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_ddlAircraftStatus").Options;
            aircraftStatus[3].Select();

            browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtAirportCity")).Value = tag;

            OptionCollection airportState = browser.SelectList("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_ddlAirportState").Options;
            airportState[3].Select();
        }

        [TestMethod]
        public void SearchForWatiNOnGoogle()
        {
            using (var browser = new IE("http://dev.eaa.org/eaa/eaa-membership/eaa-aircraft-insurance-plans/aircraft-insurance/insurance-submit-us"))
            {
                StringBuilder sb = new StringBuilder();

                string textTemplate = @"public string {0}"
                                    + @"{{"
                                    + @"    get {{ return browser.TextField(Find.ById(""{1}"")).Value; }}"
                                    + @"    set {{"
                                    + @"        browser.TextField(Find.ById(""{1}"")).Value = value;"
                                    + @"    }}"
                                    + @"}}";

                foreach(var tf in browser.TextFields)
                {
                    string [] a = tf.Id.Split('_');
                    try
                    {
                        string s = string.Format(textTemplate, a[a.Length-1], tf.Id);
                        sb.AppendLine(s);
                    }
                    catch (Exception)
                    {
                    }
                }

                var textElements = browser.ElementsWithTag("input", "text");

                USPopulatePersonalInfoPage(browser);
                browser.Button(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_StartNavigationTemplateContainerID_StartNextButton")).Click();

                USPopulateAircraftPage(browser, "1");
                browser.Button(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_StepNavigationTemplateContainerID_StepNextButton")).Click();

                // Add another aircraft
                browser.Link(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraftList_lnkAircraftAdd")).Click();

                USPopulateAircraftPage(browser, "2");
                browser.Button(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_AddButton")).Click();

                // Add another aircraft
                browser.Link(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraftList_lnkAircraftAdd")).Click();

                USPopulateAircraftPage(browser, "3");
                browser.Button(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_AddButton")).Click();

            }
        }
    }
}
