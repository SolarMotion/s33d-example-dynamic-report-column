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
    
    public partial class lnkSalesOrder
    {
        public int ID { get; set; }
        public int SalesOrderID { get; set; }
        public int ItemCodeID { get; set; }
        public string ItemCode { get; set; }
        public int Quantity { get; set; }
        public bool Active { get; set; }
        public System.DateTime CreateDT { get; set; }
        public Nullable<System.DateTime> LastUpdateDT { get; set; }
        public int LastAccessID { get; set; }
        public Nullable<System.DateTime> ReturnDT { get; set; }
    }
}