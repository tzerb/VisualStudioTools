using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatiN.Core;

namespace InsuranceAppWebUI.Obits
{
    public class MemorialWall
    {
        private Browser browser;
        public MemorialWall(Browser bro)
        {
            browser = bro;
        }

        public string EVENTTARGET { get { return browser.TextField(Find.ById("__EVENTTARGET")).Value; } set { browser.TextField(Find.ById("__EVENTTARGET")).Value = value; } }
        public string EVENTARGUMENT { get { return browser.TextField(Find.ById("__EVENTARGUMENT")).Value; } set { browser.TextField(Find.ById("__EVENTARGUMENT")).Value = value; } }
        public string LASTFOCUS { get { return browser.TextField(Find.ById("__LASTFOCUS")).Value; } set { browser.TextField(Find.ById("__LASTFOCUS")).Value = value; } }
        public string VIEWSTATE { get { return browser.TextField(Find.ById("__VIEWSTATE")).Value; } set { browser.TextField(Find.ById("__VIEWSTATE")).Value = value; } }
        public string VIEWSTATEGENERATOR { get { return browser.TextField(Find.ById("__VIEWSTATEGENERATOR")).Value; } set { browser.TextField(Find.ById("__VIEWSTATEGENERATOR")).Value = value; } }
        public string EVENTVALIDATION { get { return browser.TextField(Find.ById("__EVENTVALIDATION")).Value; } set { browser.TextField(Find.ById("__EVENTVALIDATION")).Value = value; } }
        public string incomingType { get { return browser.TextField(Find.ById("incomingType")).Value; } set { browser.TextField(Find.ById("incomingType")).Value = value; } }
        public string BrickType { get { return browser.TextField(Find.ById("BrickType")).Value; } set { browser.TextField(Find.ById("BrickType")).Value = value; } }
        public string SelectedProductName { get { return browser.TextField(Find.ById("SelectedProductName")).Value; } set { browser.TextField(Find.ById("SelectedProductName")).Value = value; } }
        public string SelectedProductDatabaseId { get { return browser.TextField(Find.ById("SelectedProductDatabaseId")).Value; } set { browser.TextField(Find.ById("SelectedProductDatabaseId")).Value = value; } }
        public string SelectedProductSku { get { return browser.TextField(Find.ById("SelectedProductSku")).Value; } set { browser.TextField(Find.ById("SelectedProductSku")).Value = value; } }
        public string SelectedProductCost { get { return browser.TextField(Find.ById("SelectedProductCost")).Value; } set { browser.TextField(Find.ById("SelectedProductCost")).Value = value; } }
        public string memorialWallEAAMemberID { get { return browser.TextField(Find.ById("memorialWallEAAMemberID")).Value; } set { browser.TextField(Find.ById("memorialWallEAAMemberID")).Value = value; } }
        public string txtDecFirstName { get { return browser.TextField(Find.ById("txtDecFirstName")).Value; } set { browser.TextField(Find.ById("txtDecFirstName")).Value = value; } }
        public string txtDecLastName { get { return browser.TextField(Find.ById("txtDecLastName")).Value; } set { browser.TextField(Find.ById("txtDecLastName")).Value = value; } }
        public string txtDecCity { get { return browser.TextField(Find.ById("txtDecCity")).Value; } set { browser.TextField(Find.ById("txtDecCity")).Value = value; } }
        public string birthDate { get { return browser.TextField(Find.ById("birthDate")).Value; } set { browser.TextField(Find.ById("birthDate")).Value = value; } }
        public string deathDate { get { return browser.TextField(Find.ById("deathDate")).Value; } set { browser.TextField(Find.ById("deathDate")).Value = value; } }
        public string selectedBrick { get { return browser.TextField(Find.ById("selectedBrick")).Value; } set { browser.TextField(Find.ById("selectedBrick")).Value = value; } }
        public string PhotoProductName { get { return browser.TextField(Find.ById("PhotoProductName")).Value; } set { browser.TextField(Find.ById("PhotoProductName")).Value = value; } }
        public string PhotoProductSku { get { return browser.TextField(Find.ById("PhotoProductSku")).Value; } set { browser.TextField(Find.ById("PhotoProductSku")).Value = value; } }
        public string PhotoProductPrice { get { return browser.TextField(Find.ById("PhotoProductPrice")).Value; } set { browser.TextField(Find.ById("PhotoProductPrice")).Value = value; } }
        public string BrickInscription01 { get { return browser.TextField(Find.ById("BrickInscription01")).Value; } set { browser.TextField(Find.ById("BrickInscription01")).Value = value; } }
        public string BrickInscription02 { get { return browser.TextField(Find.ById("BrickInscription02")).Value; } set { browser.TextField(Find.ById("BrickInscription02")).Value = value; } }
        public string BrickInscription03 { get { return browser.TextField(Find.ById("BrickInscription03")).Value; } set { browser.TextField(Find.ById("BrickInscription03")).Value = value; } }
        public string BrickInscription04 { get { return browser.TextField(Find.ById("BrickInscription04")).Value; } set { browser.TextField(Find.ById("BrickInscription04")).Value = value; } }
        public string BrickInscription05 { get { return browser.TextField(Find.ById("BrickInscription05")).Value; } set { browser.TextField(Find.ById("BrickInscription05")).Value = value; } }
        public string BrickInscription06 { get { return browser.TextField(Find.ById("BrickInscription06")).Value; } set { browser.TextField(Find.ById("BrickInscription06")).Value = value; } }
        public string BrickInscription07 { get { return browser.TextField(Find.ById("BrickInscription07")).Value; } set { browser.TextField(Find.ById("BrickInscription07")).Value = value; } }
        public string BrickInscription08 { get { return browser.TextField(Find.ById("BrickInscription08")).Value; } set { browser.TextField(Find.ById("BrickInscription08")).Value = value; } }
        public string BrickInscription09 { get { return browser.TextField(Find.ById("BrickInscription09")).Value; } set { browser.TextField(Find.ById("BrickInscription09")).Value = value; } }
        public string BrickInscription10 { get { return browser.TextField(Find.ById("BrickInscription10")).Value; } set { browser.TextField(Find.ById("BrickInscription10")).Value = value; } }
        public string BrickInscription11 { get { return browser.TextField(Find.ById("BrickInscription11")).Value; } set { browser.TextField(Find.ById("BrickInscription11")).Value = value; } }
        public string firstName { get { return browser.TextField(Find.ById("firstName")).Value; } set { browser.TextField(Find.ById("firstName")).Value = value; } }
        public string lastName { get { return browser.TextField(Find.ById("lastName")).Value; } set { browser.TextField(Find.ById("lastName")).Value = value; } }
        public string address { get { return browser.TextField(Find.ById("address")).Value; } set { browser.TextField(Find.ById("address")).Value = value; } }
        public string city { get { return browser.TextField(Find.ById("city")).Value; } set { browser.TextField(Find.ById("city")).Value = value; } }
        public string zip { get { return browser.TextField(Find.ById("zip")).Value; } set { browser.TextField(Find.ById("zip")).Value = value; } }
        public string AreaCode { get { return browser.TextField(Find.ById("AreaCode")).Value; } set { browser.TextField(Find.ById("AreaCode")).Value = value; } }
        public string PhoneNumber { get { return browser.TextField(Find.ById("PhoneNumber")).Value; } set { browser.TextField(Find.ById("PhoneNumber")).Value = value; } }
        public string email { get { return browser.TextField(Find.ById("email")).Value; } set { browser.TextField(Find.ById("email")).Value = value; } }
        public string DonationAmount { get { return browser.TextField(Find.ById("DonationAmount")).Value; } set { browser.TextField(Find.ById("DonationAmount")).Value = value; } }
        public string CreditCard { get { return browser.TextField(Find.ById("CreditCard")).Value; } set { browser.TextField(Find.ById("CreditCard")).Value = value; } }
        public string CVC { get { return browser.TextField(Find.ById("CVC")).Value; } set { browser.TextField(Find.ById("CVC")).Value = value; } }
        public string txtObituary { get { return browser.TextField(Find.ById("txtObituary")).Value; } set { browser.TextField(Find.ById("txtObituary")).Value = value; } }
        public string NotesComments { get { return browser.TextField(Find.ById("NotesComments")).Value; } set { browser.TextField(Find.ById("NotesComments")).Value = value; } }
        public SelectList ddlDecState { get { return browser.SelectList(Find.ById("ddlDecState")); } }
        public SelectList ddlCountry { get { return browser.SelectList(Find.ById("ddlCountry")); } }
        public SelectList ddlState { get { return browser.SelectList(Find.ById("ddlState")); } }
        public SelectList ddlCreditCardExpirationMonth { get { return browser.SelectList(Find.ById("ddlCreditCardExpirationMonth")); } }
        public SelectList ddlCreditCardExpirationYear { get { return browser.SelectList(Find.ById("ddlCreditCardExpirationYear")); } }
        public Button btnB { get { return browser.Button(Find.ById("btnB")); } }
        public Button btnI { get { return browser.Button(Find.ById("btnI")); } }
        public Button btnU { get { return browser.Button(Find.ById("btnU")); } }
        public Button btnC { get { return browser.Button(Find.ById("btnC")); } }
        public Button SubmitButton { get { return browser.Button(Find.ById("SubmitButton")); } }
    }


}
