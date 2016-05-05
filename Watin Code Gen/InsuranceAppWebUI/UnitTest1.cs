using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WatiN.Core;
using WatiN.Core.Constraints;
using System.Text.RegularExpressions;
using System.Text;

namespace InsuranceAppWebUI
{
    public class CAAircraftPage
    {
        private Browser browser;
        public CAAircraftPage(Browser bro)
        {
            browser = bro;
        }

        public string hiddenAircraftCountSub { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_hiddenAircraftCountSub")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_hiddenAircraftCountSub")).Value = value; } }
        public string txtAircraftFAANumber { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtAircraftFAANumber")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtAircraftFAANumber")).Value = value; } }
        public string txtAircraftYear { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtAircraftYear")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtAircraftYear")).Value = value; } }
        public string txtAircraftMake { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtAircraftMake")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtAircraftMake")).Value = value; } }
        public string txtAircraftModel { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtAircraftModel")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtAircraftModel")).Value = value; } }
        public string txtTotalSeats { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtTotalSeats")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtTotalSeats")).Value = value; } }
        public string txtHorsepower { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtHorsepower")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtHorsepower")).Value = value; } }
        public string txtOverhaulHours { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtOverhaulHours")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtOverhaulHours")).Value = value; } }
        public string APCurrentValue { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_APCurrentValue")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_APCurrentValue")).Value = value; } }
        public string APCompletedValue { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_APCompletedValue")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_APCompletedValue")).Value = value; } }
        public string APKitValue { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_APKitValue")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_APKitValue")).Value = value; } }
        public string APLocation { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_APLocation")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_APLocation")).Value = value; } }
        public string txtCurrentInsurance { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtCurrentInsurance")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtCurrentInsurance")).Value = value; } }
        public string txtHullValue { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtHullValue")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtHullValue")).Value = value; } }
        public string txtLandplaneValue { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtLandplaneValue")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtLandplaneValue")).Value = value; } }
        public string txtSeaplaneValue { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtSeaplaneValue")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtSeaplaneValue")).Value = value; } }
        public string txtAmphibianValue { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtAmphibianValue")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtAmphibianValue")).Value = value; } }
        public string txtAirportName { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtAirportName")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtAirportName")).Value = value; } }
        public string txtCommercialUseExplaination { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtCommercialUseExplaination")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtCommercialUseExplaination")).Value = value; } }
        public string txtUnknownExplain { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtUnknownExplain")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_txtUnknownExplain")).Value = value; } }

        public bool xAircraftchkbxNNumberUnknown { get { return browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_chkbxNNumberUnknown")).Checked; } set { browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_chkbxNNumberUnknown")).Checked = value; } }
        public bool CBLGearConfiguration0 { get { return browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_CBLGearConfiguration_0")).Checked; } set { browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_CBLGearConfiguration_0")).Checked = value; } }
        public bool CBLGearConfiguration3 { get { return browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_CBLGearConfiguration_3")).Checked; } set { browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_CBLGearConfiguration_3")).Checked = value; } }
        public bool CBLGearConfiguration1 { get { return browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_CBLGearConfiguration_1")).Checked; } set { browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_CBLGearConfiguration_1")).Checked = value; } }
        public bool CBLGearConfiguration4 { get { return browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_CBLGearConfiguration_4")).Checked; } set { browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_CBLGearConfiguration_4")).Checked = value; } }
        public bool CBLGearConfiguration2 { get { return browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_CBLGearConfiguration_2")).Checked; } set { browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_CBLGearConfiguration_2")).Checked = value; } }
        public bool CBLGearConfiguration5 { get { return browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_CBLGearConfiguration_5")).Checked; } set { browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_CBLGearConfiguration_5")).Checked = value; } }
        public bool cbxQuoteFor0 { get { return browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_cbxQuoteFor_0")).Checked; } set { browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_cbxQuoteFor_0")).Checked = value; } }
        public bool cbxQuoteFor2 { get { return browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_cbxQuoteFor_2")).Checked; } set { browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_cbxQuoteFor_2")).Checked = value; } }
        public bool cbxQuoteFor1 { get { return browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_cbxQuoteFor_1")).Checked; } set { browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_cbxQuoteFor_1")).Checked = value; } }
        public bool cbxQuoteFor3 { get { return browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_cbxQuoteFor_3")).Checked; } set { browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_cbxQuoteFor_3")).Checked = value; } }
        public bool CBLRunwaysurface0 { get { return browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_CBLRunwaysurface_0")).Checked; } set { browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_CBLRunwaysurface_0")).Checked = value; } }
        public bool CBLRunwaysurface1 { get { return browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_CBLRunwaysurface_1")).Checked; } set { browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_CBLRunwaysurface_1")).Checked = value; } }
        public bool CBLRunwaysurface2 { get { return browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_CBLRunwaysurface_2")).Checked; } set { browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_CBLRunwaysurface_2")).Checked = value; } }
        public bool CBLRunwaysurface3 { get { return browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_CBLRunwaysurface_3")).Checked; } set { browser.CheckBox(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_CBLRunwaysurface_3")).Checked = value; } }

        public SelectList ddlAircraftUse { get { return browser.SelectList(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_ddlAircraftUse")); } }
        public SelectList ddlExpireMonth { get { return browser.SelectList(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_ddlExpireMonth")); } }
        public SelectList ddlExpireDay { get { return browser.SelectList(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_ddlExpireDay")); } }
        public SelectList ddlExpireYear { get { return browser.SelectList(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_ddlExpireYear")); } }
        public SelectList ddlHullCoverage { get { return browser.SelectList(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_ddlHullCoverage")); } }
        public SelectList rbLimits { get { return browser.SelectList(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_rbLimits")); } }
        public SelectList ddlAircraftStatus { get { return browser.SelectList(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_ddlAircraftStatus")); } }
    }

    public class CAPersonalInformationPage
    {
        private Browser browser;
        public CAPersonalInformationPage(Browser bro)
        {
            browser = bro;
        }

        public string txtEAANumber { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtEAANumber")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtEAANumber")).Value = value; } }
        public string txtContactNameFirst { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtContactNameFirst")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtContactNameFirst")).Value = value; } }
        public string txtContactNameLast { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtContactNameLast")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtContactNameLast")).Value = value; } }
        public string txtNamedInsured { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtNamedInsured")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtNamedInsured")).Value = value; } }
        public string txtAddress1 { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtAddress1")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtAddress1")).Value = value; } }
        public string txtAddress2 { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtAddress2")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtAddress2")).Value = value; } }
        public string txtCity { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtCity")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtCity")).Value = value; } }
        public string txtZipCode { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtZipCode")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtZipCode")).Value = value; } }
        public string txtEmailAddress { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtEmailAddress")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtEmailAddress")).Value = value; } }
        public string txtDaytimePhone { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtDaytimePhone")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtDaytimePhone")).Value = value; } }
        public SelectList ddlState { get { return browser.SelectList(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_ddlState")); } }
    }

    public class USPersonalInformationPage
    {
        private Browser browser;
        public USPersonalInformationPage(Browser bro)
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
        public SelectList ddlState { get { return browser.SelectList(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_ddlState")); } }
    }

    [TestClass]
    public class UnitTest1
    {
        private void CAPopulatePersonalInfoPage(Browser browser)
        {
            string tag = "1";
            var pi = new CAPersonalInformationPage(browser);
            pi.txtEAANumber = "1";
            pi.txtEAANumber = tag;
            pi.txtContactNameFirst = tag;
            pi.txtContactNameLast = tag;
            pi.txtNamedInsured = tag;
            pi.txtAddress1 = tag;
            pi.txtAddress2 = tag;
            pi.txtCity = tag;
            pi.txtZipCode = "54025";
            pi.txtEmailAddress = "tzirbel@eaa.org";
            pi.txtDaytimePhone = "2628930720";

            pi.ddlState.Options[3].Select();

        }

        private void CAPopulateAircraftPage(Browser browser, string tag)
        {
            var a = new CAAircraftPage(browser);
            a.ddlAircraftUse.Options[1].Select();
            a.txtCommercialUseExplaination = tag;
            a.txtAircraftFAANumber = tag;
            a.txtAircraftYear = tag;
            a.txtAircraftMake = tag;
            a.txtAircraftModel = tag;
            a.txtTotalSeats = tag;
            a.txtHullValue = tag;
            a.ddlHullCoverage.Options[2].Select();
            a.rbLimits.Options[2].Select();
            a.txtAirportName = tag;
            a.ddlAircraftStatus.Options[2].Select();
            a.CBLGearConfiguration1 = true;
            a.cbxQuoteFor1 = true;
        }

        private void USPopulatePersonalInfoPage(Browser browser)
        {

            var pi = new USPersonalInformationPage(browser);
            pi.txtEAANumber = "1";

            // Populate personal info page
            pi.txtContactNameFirst = "First";
            pi.txtContactNameMiddle = "Middle";
            pi.txtContactNameLast = "Last";

            pi.txtAddress1 = "Address1";
            pi.txtZipCode = "54025";

            pi.txtDaytimePhone = "2628930720";
            pi.txtCity = "City";
            pi.txtEmailAddress = "tzirbel@eaa.org";

            OptionCollection stateOptions = browser.SelectList("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_ddlState").Options;
            stateOptions[3].Select();
        }

        private void USPopulateAircraftPage(Browser browser, string tag)
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

        // using (var browser = new FireFox("http://dev.eaa.org/eaa/eaa-membership/eaa-aircraft-insurance-plans/aircraft-insurance/insurance-submit-us"))
        private void GenerateCode(Browser browser)
        {
            StringBuilder sb = new StringBuilder();

            string textTemplate = @"public string {0}"
                                + @"{{"
                                + @"    get {{ return browser.TextField(Find.ById(""{1}"")).Value; }}"
                                + @"    set {{"
                                + @"        browser.TextField(Find.ById(""{1}"")).Value = value;"
                                + @"    }}"
                                + @"}}";

            foreach (var tf in browser.TextFields)
            {
                try
                {
                    string[] a = tf.Id.Split('_');
                    string s = string.Format(textTemplate, a[a.Length - 1], tf.Id);
                    sb.AppendLine(s);
                }
                catch (Exception ex)
                {
                    sb.AppendLine(@"\\ Error processing " + tf.Id);
                }
            }

            string checkboxTemplate = @"public bool {0}{1}"
                                + @"{{"
                                + @"    get {{ return browser.CheckBox(Find.ById(""{2}"")).Checked; }}"
                                + @"    set {{"
                                + @"        browser.CheckBox(Find.ById(""{2}"")).Checked = value;"
                                + @"    }}"
                                + @"}}";

            foreach (var tf in browser.CheckBoxes)
            {
                try
                {
                    string[] a = tf.Id.Split('_');
                    string s = string.Format(checkboxTemplate, a[a.Length - 2], a[a.Length - 1], tf.Id);
                    sb.AppendLine(s);
                }
                catch (Exception ex)
                {
                    sb.AppendLine(@"\\ Error processing " + tf.Id);
                }
            }

            string selectTemplate = @"public SelectList {0}"
                                + @"{{"
                                + @"    get {{ return browser.SelectList(Find.ById(""{1}"")); }}"
                                + @"}}";
            foreach (var tf in browser.SelectLists)
            {
                try
                {
                    string[] a = tf.Id.Split('_');
                    string s = string.Format(selectTemplate, a[a.Length - 1], tf.Id);
                    sb.AppendLine(s);
                }
                catch (Exception ex)
                {
                    sb.AppendLine(@"\\ Error processing " + tf.Id);
                }
            }

            string linkTemplate = @"";
            foreach (var tf in browser.Links)
            {
                try
                {
                    string[] a = tf.Id.Split('_');
                    string s = string.Format(linkTemplate, a[a.Length - 1], tf.Id);
                    sb.AppendLine(s);
                }
                catch (Exception ex)
                {
                    sb.AppendLine(@"\\ Error processing " + tf.Id);
                }
            }

            string buttonTemplate = @"";
            foreach (var tf in browser.Buttons)
            {
                try
                {
                    string[] a = tf.Id.Split('_');
                    string s = string.Format(buttonTemplate, a[a.Length - 1], tf.Id);
                    sb.AppendLine(s);
                }
                catch (Exception ex)
                {
                    sb.AppendLine(@"\\ Error processing " + tf.Id);
                }
            }


            string radioButtonTemplate = @"";
            foreach (var tf in browser.RadioButtons)
            {
                try
                {
                    string[] a = tf.Id.Split('_');
                    string s = string.Format(radioButtonTemplate, a[a.Length - 1], tf.Id);
                    sb.AppendLine(s);
                }
                catch (Exception)
                {
                    sb.AppendLine(@"\\ Error processing " + tf.Id);
                }
            }
        }

        [TestMethod]
        public void Generate()
        {
            using (var browser = new IE("http://dev.eaa.org/eaa/eaa-membership/eaa-aircraft-insurance-plans/aircraft-insurance/insurance-submit-ca"))
            {
                GenerateCode(browser);
            }
        }

        [TestMethod]
        public void FillCA()
        {
            using (var browser = new IE("http://dev.eaa.org/eaa/eaa-membership/eaa-aircraft-insurance-plans/aircraft-insurance/insurance-submit-ca"))
            {
                browser.AutoClose = false;
                CAPopulatePersonalInfoPage(browser);
                browser.Button(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_StartNavigationTemplateContainerID_StartNextButton")).Click();

                CAPopulateAircraftPage(browser, "1");
                browser.Button(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_StepNavigationTemplateContainerID_StepNextButton")).Click();

                // Add another aircraft
                browser.Link(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraftList_lnkAircraftAdd")).Click();

                CAPopulateAircraftPage(browser, "2");
                browser.Button(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_AddButton")).Click();

                // Add another aircraft
                browser.Link(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraftList_lnkAircraftAdd")).Click();

                CAPopulateAircraftPage(browser, "3");
                browser.Button(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xAircraft_AddButton")).Click();
            }
        }

        [TestMethod]
        public void FillUS()
        {
            using (var browser = new IE("http://dev.eaa.org/eaa/eaa-membership/eaa-aircraft-insurance-plans/aircraft-insurance/insurance-submit-us"))
            {
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
                browser.AutoClose = false;
            }
        }
    }
}
