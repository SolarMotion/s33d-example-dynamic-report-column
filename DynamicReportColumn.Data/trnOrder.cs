//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DynamicReportColumn.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class trnOrder
    {
        public int ID { get; set; }
        public int CenterID { get; set; }
        public Nullable<int> TypeID { get; set; }
        public Nullable<int> OrderCenterID { get; set; }
        public Nullable<int> DeliveryID { get; set; }
        public string ExtOrderID { get; set; }
        public Nullable<int> lnkOrderUploadID { get; set; }
        public int BizUnitID { get; set; }
        public string Remark { get; set; }
        public Nullable<bool> CenterTaxable { get; set; }
        public Nullable<decimal> GrandTotal { get; set; }
        public Nullable<decimal> TotalTaxAmount { get; set; }
        public Nullable<decimal> TTLAmount { get; set; }
        public Nullable<System.DateTime> OrderDT { get; set; }
        public Nullable<System.DateTime> ConfirmDT { get; set; }
        public Nullable<System.DateTime> CancelDT { get; set; }
        public int StatusID { get; set; }
        public bool ApproveNeeded { get; set; }
        public Nullable<System.DateTime> ApproveDT { get; set; }
        public Nullable<System.DateTime> RejectDT { get; set; }
        public string CancelRemark { get; set; }
        public string ExtAccessID { get; set; }
        public bool IsDOReversed { get; set; }
        public System.DateTime CreateDT { get; set; }
        public Nullable<System.DateTime> LastUpdateDT { get; set; }
        public int AccessID { get; set; }
        public Nullable<System.DateTime> FirstPrintedDT { get; set; }
        public Nullable<System.DateTime> LastPrintedDT { get; set; }
    }
}
