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
    
    public partial class tblCompanySetting
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public Nullable<int> CityID { get; set; }
        public Nullable<int> StateID { get; set; }
        public Nullable<int> CountryID { get; set; }
        public string Postcode { get; set; }
        public string TelNo { get; set; }
        public Nullable<bool> IsAutoAccept { get; set; }
        public Nullable<bool> IsPartialFulfill { get; set; }
        public Nullable<bool> OrderApproval { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.DateTime> CreateDT { get; set; }
        public Nullable<System.DateTime> LastUpdateDT { get; set; }
        public Nullable<int> LastAccessID { get; set; }
    }
}
