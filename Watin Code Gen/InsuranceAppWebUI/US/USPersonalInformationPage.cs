using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatiN.Core;

namespace InsuranceAppWebUI.US
{
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
        public string txtEveningPhone { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtEveningPhone")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtEveningPhone")).Value = value; } }
        public string txtCellPhone { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtCellPhone")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtCellPhone")).Value = value; } }
        public string txtVintageAircraftAssociation { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtVintageAircraftAssociation")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtVintageAircraftAssociation")).Value = value; } }
        public string txtInternationalAerobaticClub { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtInternationalAerobaticClub")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtInternationalAerobaticClub")).Value = value; } }
        public string txtWarbirdsofAmerica { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtWarbirdsofAmerica")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtWarbirdsofAmerica")).Value = value; } }
        public string txtAircraftOwnersPilotsAssociation { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtAircraftOwnersPilotsAssociation")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_txtAircraftOwnersPilotsAssociation")).Value = value; } }
        public string txtAntiqueAircraft { get { return browser.TextField(Find.ById("txtAntiqueAircraft")).Value; } set { browser.TextField(Find.ById("txtAntiqueAircraft")).Value = value; } }
        public SelectList ddlState { get { return browser.SelectList(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPersonalInformation_ddlState")); } }
    }
}
