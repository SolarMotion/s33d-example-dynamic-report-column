using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicReportColumn.Web.Models
{ 
    public class ShownColumn
    {
        public string ColumnValue { get; set; }
        public string ColumnName { get; set; }
        public bool IsTick { get; set; }
    }
}