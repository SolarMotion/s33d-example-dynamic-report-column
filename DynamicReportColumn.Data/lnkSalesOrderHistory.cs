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
    
    public partial class lnkSalesOrderHistory
    {
        public int ID { get; set; }
        public int SalesOrderID { get; set; }
        public int SalesDeliveryID { get; set; }
        public int StatusID { get; set; }
        public string Remarks { get; set; }
        public System.DateTime CreateDT { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public bool SentToOMS { get; set; }
        public string OMSResponse { get; set; }
    }
}
