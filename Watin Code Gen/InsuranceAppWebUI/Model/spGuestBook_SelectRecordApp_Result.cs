//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InsuranceAppWebUI.Model
{
    using System;
    
    public partial class spGuestBook_SelectRecordApp_Result
    {
        public int GuestBookID { get; set; }
        public Nullable<int> ObituaryID { get; set; }
        public Nullable<System.DateTime> DateSubmitted { get; set; }
        public string SubmitterName { get; set; }
        public string SubmitterMemberNum { get; set; }
        public string SubmitterComments { get; set; }
        public string Approver { get; set; }
        public string Approved { get; set; }
        public Nullable<System.DateTime> ApprovalDate { get; set; }
        public string ApproverComments { get; set; }
        public System.DateTime SignedByDBTeam4EAA { get; set; }
    }
}