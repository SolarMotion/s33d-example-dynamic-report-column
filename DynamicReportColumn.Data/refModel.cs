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
    
    public partial class refModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int BrandID { get; set; }
        public bool HasSerial { get; set; }
        public bool HasIMEI { get; set; }
        public bool HasRange { get; set; }
        public int RangeQty { get; set; }
        public bool IsSerialized { get; set; }
        public Nullable<bool> Taxable { get; set; }
        public Nullable<int> TaxID { get; set; }
        public bool Active { get; set; }
        public System.DateTime CreateDT { get; set; }
        public Nullable<System.DateTime> LastUpdateDT { get; set; }
        public int AccessID { get; set; }
        public int TenantID { get; set; }
    }
}
