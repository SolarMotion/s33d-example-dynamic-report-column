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
    
    public partial class lnkOrderUpload
    {
        public int ID { get; set; }
        public int OrderUploadID { get; set; }
        public string CenterCode { get; set; }
        public Nullable<int> CenterID { get; set; }
        public Nullable<int> Qty { get; set; }
        public string ErrMsg { get; set; }
        public bool IsOrdered { get; set; }
        public bool Active { get; set; }
        public System.DateTime CreateDT { get; set; }
        public Nullable<System.DateTime> LastUpdateDT { get; set; }
        public int AccessID { get; set; }
    }
}