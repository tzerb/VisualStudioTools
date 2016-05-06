using System.Linq;

using WatiN.Core;

namespace InsuranceAppWebUI.CA
{
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
}
