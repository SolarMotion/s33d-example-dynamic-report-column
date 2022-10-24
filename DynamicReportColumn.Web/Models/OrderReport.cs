using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DynamicReportColumn.Web.Models
{
    public class OrderReportViewModel
    {
        public OrderReportIndex OrderReportIndex { get; set; } = new OrderReportIndex();
        public List<OrderReportList> OrderReportList { get; set; } = new List<OrderReportList>();

        [DisplayName("Shown Column")]
        public List<ShownColumn> ShownColumns { get; set; } = new List<ShownColumn>();

        public OrderReportColumnCss ReportColumnCss { get; set; } = new OrderReportColumnCss();

        public int RecordTotalCount { get; set; }
        public string ReportDate { get; set; }
        public string Center { get; set; }
    }

    public class OrderReportIndex
    {
        public DateTime ReceivedDateFrom { get; set; }
        public DateTime ReceivedDateTo { get; set; }
        public DateTime OrderDateFrom { get; set; } = new DateTime(2019, 5, 1);
        public DateTime OrderDateTo { get; set; } = new DateTime(2019, 5, DateTime.Now.Day);
        public string DateType { get; set; }
        public int CenterTypeID { get; set; }
        public int StatusID { get; set; }
    }

    public class OrderReportList
    {
        public string Region { get; set; }
        public string State { get; set; }
        public string CenterType { get; set; }
        public string Code { get; set; }
        public string Location { get; set; }
        public int OrderID { get; set; }
        public string POSID { get; set; }
        public string OrderDT { get; set; }
        public string ReceiveDT { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string ItemCode { get; set; }
        public string Qty { get; set; }
        public string TaggedQty { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public int Balance { get; set; }
        public string Access { get; set; }
    }

    public class OrderReportColumnCss
    {
        public string StateCss { get; set; }
        public string RegionCss { get; set; }
    }
}