using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatiN.Core;

namespace InsuranceAppWebUI.Obits
{
    public class ObituaryAdd
    {
        private Browser browser;
        public ObituaryAdd(Browser bro)
        {
            browser = bro;
        }

        public string searchboxLabel { get { return browser.Label(Find.ByFor("search-box")).Text; } }
        public string EVENTTARGET { get { return browser.TextField(Find.ById("__EVENTTARGET")).Value; } set { browser.TextField(Find.ById("__EVENTTARGET")).Value = value; } }
        public string EVENTARGUMENT { get { return browser.TextField(Find.ById("__EVENTARGUMENT")).Value; } set { browser.TextField(Find.ById("__EVENTARGUMENT")).Value = value; } }
        public string VIEWSTATE { get { return browser.TextField(Find.ById("__VIEWSTATE")).Value; } set { browser.TextField(Find.ById("__VIEWSTATE")).Value = value; } }
        public string VIEWSTATEGENERATOR { get { return browser.TextField(Find.ById("__VIEWSTATEGENERATOR")).Value; } set { browser.TextField(Find.ById("__VIEWSTATEGENERATOR")).Value = value; } }
        public string EVENTVALIDATION { get { return browser.TextField(Find.ById("__EVENTVALIDATION")).Value; } set { browser.TextField(Find.ById("__EVENTVALIDATION")).Value = value; } }
        public string searchbox { get { return browser.TextField(Find.ById("search-box")).Value; } set { browser.TextField(Find.ById("search-box")).Value = value; } }
        public string txtDecFirstName { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtDecFirstName")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtDecFirstName")).Value = value; } }
        public string txtDecLastName { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtDecLastName")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtDecLastName")).Value = value; } }
        public string txtDecMemberNum { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtDecMemberNum")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtDecMemberNum")).Value = value; } }
        public string txtDecDateDeath { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtDecDateDeath")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtDecDateDeath")).Value = value; } }
        public string txtDecDateBirth { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtDecDateBirth")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtDecDateBirth")).Value = value; } }
        public string txtDecAddress { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtDecAddress")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtDecAddress")).Value = value; } }
        public string txtDecAddress2 { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtDecAddress2")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtDecAddress2")).Value = value; } }
        public string txtDecCity { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtDecCity")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtDecCity")).Value = value; } }
        public string txtDecZip { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtDecZip")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtDecZip")).Value = value; } }
        public string txtContactFirstName { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtContactFirstName")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtContactFirstName")).Value = value; } }
        public string txtContactLastName { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtContactLastName")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtContactLastName")).Value = value; } }
        public string txtContactMemberNum { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtContactMemberNum")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtContactMemberNum")).Value = value; } }
        public string txtContactAddress { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtContactAddress")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtContactAddress")).Value = value; } }
        public string txtContactAddress2 { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtContactAddress2")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtContactAddress2")).Value = value; } }
        public string txtContactCity { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtContactCity")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtContactCity")).Value = value; } }
        public string txtContactZip { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtContactZip")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtContactZip")).Value = value; } }
        public string txtContactPhone { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtContactPhone")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtContactPhone")).Value = value; } }
        public string txtContactEmail { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtContactEmail")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtContactEmail")).Value = value; } }
        public string txtObituary { get { return browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtObituary")).Value; } set { browser.TextField(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_txtObituary")).Value = value; } }
        public SelectList ddHonorific { get { return browser.SelectList(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_ddHonorific")); } }
        public SelectList cmdMonthDeath { get { return browser.SelectList(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_cmdMonthDeath")); } }
        public SelectList cmdDayDeath { get { return browser.SelectList(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_cmdDayDeath")); } }
        public SelectList drpMemorialDeathYear { get { return browser.SelectList(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_drpMemorialDeathYear")); } }
        public SelectList cmdMonthBirth { get { return browser.SelectList(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_cmdMonthBirth")); } }
        public SelectList cmdDayBirth { get { return browser.SelectList(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_cmdDayBirth")); } }
        public SelectList drpMemorialBirthYear { get { return browser.SelectList(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_drpMemorialBirthYear")); } }
        public SelectList ddDecState { get { return browser.SelectList(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_ddDecState")); } }
        public SelectList ddContactState { get { return browser.SelectList(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_ddContactState")); } }

        public FileUpload FileUpload { get { return browser.FileUpload(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_fileUpEx")); } }

        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        // Error processing 
        public Link fancyboxclose { get { return browser.Link(Find.ById("fancybox-close")); } }
        public Link fancyboxleft { get { return browser.Link(Find.ById("fancybox-left")); } }
        public Link fancyboxright { get { return browser.Link(Find.ById("fancybox-right")); } }
        public Button btnB { get { return browser.Button(Find.ById("btnB")); } }
        public Button btnI { get { return browser.Button(Find.ById("btnI")); } }
        public Button btnU { get { return browser.Button(Find.ById("btnU")); } }
        public Button btnC { get { return browser.Button(Find.ById("btnC")); } }
        public Button Submit { get { return browser.Button(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Submit")); } }
        public Button Reset { get { return browser.Button(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Reset")); } }
        // Error processing 


    }
}
