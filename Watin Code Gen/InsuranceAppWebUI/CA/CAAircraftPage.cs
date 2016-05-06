﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatiN.Core;

namespace InsuranceAppWebUI.CA
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
}