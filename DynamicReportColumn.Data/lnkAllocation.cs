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
    
    public partial class lnkAllocation
    {
        public int ID { get; set; }
        public int FromCenterID { get; set; }
        public int ToCenterID { get; set; }
        public int AllocationID { get; set; }
        public int ItemID { get; set; }
        public Nullable<System.DateTime> AllocationDT { get; set; }
        public Nullable<System.DateTime> AcceptDT { get; set; }
        public Nullable<System.DateTime> RejectDT { get; set; }
        public Nullable<System.DateTime> CancelDT { get; set; }
        public bool Checked { get; set; }
        public string Remark { get; set; }
        public bool Active { get; set; }
        public System.DateTime CreateDT { get; set; }
        public Nullable<System.DateTime> LastUpdateDT { get; set; }
        public int AccessID { get; set; }
    }
}