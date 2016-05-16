using InsuranceAppWebUI.CA;
using InsuranceAppWebUI.Obits;
using InsuranceAppWebUI.US;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;
using WatiN.Core;

namespace InsuranceAppWebUI
{
    [TestClass]
    public class InsuranceTests
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

        private void CAPopulatePilotPage(Browser browser, string tag)
        {
            var p = new CAPilotPage(browser);
            p.txtPilotInfoName = tag;
            p.txtPilotInfoNameLast = tag;
            p.txtPilotInfoAge = tag;
            p.ddlPilotInfoCertificate.Options[2].Select();
            p.cbxPilotInfoRatings1 = true;
            p.txtPilotInfoTotalHours = tag;
            p.txtPilotInfoTotalHoursLast12Mths = tag;
            p.cbxPilotInfoViolations0 = true;
            p.txtAdditionalInfo = "txtAdditionalInfo";
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

        private void USPopulatePilotPage(Browser browser, string tag)
        {
            var p = new USPilotPage(browser);
            p.ddlPilotInfoCertificate.Options[2].Select();
            p.cbxPilotInfoRatings1 = true;
            p.txtPilotInfoName = tag;
            p.txtPilotInfoNameMiddle = tag;
            p.txtPilotInfoNameLast = tag;
            p.txtPilotInfoOccupation = tag;
            p.txtPilotInfoAge = tag;
            p.txtPilotInfoTotalHours = tag;
            p.txtPilotInfoTotalHoursLast12Mths = tag;
            p.txtRGHours = tag;
            p.txtMEHours = tag;
            p.txtTWHours = tag;
            p.txtSeaplaneHours = tag;
            p.txtAmphibianHours = tag;
            p.txtRWHours = tag;
            p.txtWSCTrikeHours = tag;
            p.txtPPCHours = tag;
            p.txtGliderHours = tag;
            p.txtGyroHours = tag;
            p.txtAdditionalInfo = tag;
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

        private void GenerateCodeOBITS(Browser browser)
        {
            StringBuilder sb = new StringBuilder();

            string labelTemplate = @"public string {0}Label {{ get {{ return browser.Label(Find.ByFor(""{1}"")).Text; }}  }}";

            foreach (var tf in browser.Labels)
            {
                try
                {
                    string f = tf.For;
                    string s = string.Format(labelTemplate, f, f);
                    sb.AppendLine(s);
                }
                catch (Exception ex)
                {
                    sb.AppendLine(@"\\ Error processing " + tf.Id);
                }
            }

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

            //foreach (var tf in browser.CheckBoxes)
            //{
            //    try
            //    {
            //        string[] a = tf.Id.Split('_');
            //        string s = string.Format(checkboxTemplate, a[a.Length - 2], a[a.Length - 1], tf.Id);
            //        sb.AppendLine(s);
            //    }
            //    catch (Exception ex)
            //    {
            //        sb.AppendLine(@"\\ Error processing " + tf.Id);
            //    }
            //}

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
                    sb.AppendLine(@"// Error processing " + tf.Id);
                }
            }

            string linkTemplate = @"public Link {0}"
                                + @"{{"
                                + @"    get {{ return browser.Link(Find.ById(""{1}"")); }}"
                                + @"}}";
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
                    sb.AppendLine(@"// Error processing " + tf.Id);
                }
            }

            string buttonTemplate = @"public Button {0}"
                                  + @"{{"
                                  + @"    get {{ return browser.Button(Find.ById(""{1}"")); }}"
                                  + @"}}"; ;
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
                    sb.AppendLine(@"// Error processing " + tf.Id);
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
                    sb.AppendLine(@"// Error processing " + tf.Id);
                }
            }
        }

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
                    sb.AppendLine(@"// Error processing " + tf.Id);
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
                    sb.AppendLine(@"// Error processing " + tf.Id);
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
                    sb.AppendLine(@"// Error processing " + tf.Id);
                }
            }

            string linkTemplate = @"public Link {0}"
                                + @"{{"
                                + @"    get {{ return browser.Link(Find.ById(""{1}"")); }}"
                                + @"}}";
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
                    sb.AppendLine(@"// Error processing " + tf.Id);
                }
            }

            string buttonTemplate = @"public Button {0}"
                                  + @"{{"
                                  + @"    get {{ return browser.Button(Find.ById(""{1}"")); }}"
                                  + @"}}"; ;
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
                    sb.AppendLine(@"// Error processing " + tf.Id);
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
                    sb.AppendLine(@"// Error processing " + tf.Id);
                }
            }
        }

        [TestMethod]
        public void GenerateOBITS()
        {
            //
            // using (var browser = new IE("http://dev.eaa.org/apps/airventure/bricks_memorialwall.aspx"))
            using (var browser = new IE("http://dev.eaa.org/en/eaa/apps/obituaries/obituary-add"))
            {
                // MemorialWall mw = new MemorialWall(browser);
                // mw.SubmitButton.Click();
                GenerateCodeOBITS(browser);
            }
        }

        [TestMethod]
        public void Generate()
        {
            // using (var browser = new FireFox("http://dev.eaa.org/eaa/eaa-membership/eaa-aircraft-insurance-plans/aircraft-insurance/insurance-submit-us"))
            using (var browser = new IE("http://dev.eaa.org/apps/airventure/bricks_memorialwall.aspx"))
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

                browser.Button(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_StepNavigationTemplateContainerID_StepNextButton")).Click();

                GenerateCode(browser);

                CAPopulatePilotPage(browser, "1");
                browser.Button(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_StepNavigationTemplateContainerID_StepNextButton")).Click();

                browser.Link(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPilotList_lnkPilotAdd")).Click();

                CAPopulatePilotPage(browser, "2");
                browser.Button(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPilot_AddButton")).Click();
                browser.Link(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPilotList_lnkPilotAdd")).Click();

                CAPopulatePilotPage(browser, "3");
                browser.Button(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPilot_AddButton")).Click();
                browser.Button(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_StepNavigationTemplateContainerID_StepNextButton")).Click();

                // browser.Button(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_FinishNavigationTemplateContainerID_FinishButton")).Click();
            }
        }

        [TestMethod]
        public void FillUS()
        {
            using (var browser = new IE("http://dev.eaa.org/eaa/eaa-membership/eaa-aircraft-insurance-plans/aircraft-insurance/insurance-submit-us"))
            {
                browser.AutoClose = false;

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

                // 
                browser.Button(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_StepNavigationTemplateContainerID_StepNextButton")).Click();

                USPopulatePilotPage(browser, "1");
                browser.Button(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_StepNavigationTemplateContainerID_StepNextButton")).Click();

                browser.Link(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPilotList_lnkPilotAdd")).Click();
                USPopulatePilotPage(browser, "2");
                browser.Button(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPilot_AddButton")).Click();

                browser.Link(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPilotList_lnkPilotAdd")).Click();
                USPopulatePilotPage(browser, "3");
                browser.Button(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_xPilot_AddButton")).Click();

                browser.Button(Find.ById("main_0_eaamain_0_eaacontent_0_acmain_1_Quote_xQuoteWizard_StepNavigationTemplateContainerID_StepNextButton")).Click();

            }
        }
    }
}
