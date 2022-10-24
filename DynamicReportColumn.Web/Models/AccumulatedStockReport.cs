using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DynamicReportColumn.Web.Models
{
    public class AccumulatedStockViewModel
    {
        public AccumulatedStockIndex AccumulatedStockIndex { get; set; } = new AccumulatedStockIndex();
        public List<AccumulatedStockItemList> AccumulatedStockItemList { get; set; } = new List<AccumulatedStockItemList>();
        public int RecordTotalCount { get; set; }
        public string ReportDate { get; set; }
        public string Center { get; set; }

        [DisplayName("Shown Column")]
        public List<ShownColumn> ShownColumns { get; set; } = new List<ShownColumn>();

        public AccumulatedStockReportColumnCss ReportColumnCss { get; set; } = new AccumulatedStockReportColumnCss();
    }

    public class AccumulatedStockIndex
    {
        public int? CenterTypeID { get; set; }
        public int? CenterID { get; set; }
        public int? RegionID { get; set; }
        public int? BUID { get; set; }
        public int? CategoryID { get; set; }
        public int? BrandID { get; set; }
        public int? ModelID { get; set; }
        public int? StatusID { get; set; }
        public int? TypeID { get; set; }
        public int? IsSerialized { get; set; }
    }

    public class AccumulatedStockItemList
    {
        public string DealerCode { get; set; }
        public string Center { get; set; }
        public string CenterType { get; set; }
        public string Region { get; set; }
        public string BusinessUnit { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Qty { get; set; }
        public int ReserveQty { get; set; }
        public int BalanceQty { get; set; }
        public bool IsSerialized { get; set; }
        public string IsSerializedString { get; set; }

        public string Center1 { get; set; }
        public string Center2{ get; set; }
        public string Center3 { get; set; }
        public string Center4 { get; set; }
        public string Center5 { get; set; }
        public string Center6 { get; set; }
        public string Center7 { get; set; }
        public string Center8 { get; set; }
    }

    public class AccumulatedStockReportColumnCss
    {
        public string LocationCodeCss { get; set; }
        public string LocationCss { get; set; }
        public string LocationTypeCss { get; set; }
        public string RegionCss { get; set; }
        public string BusinessUnitCss { get; set; }
        public string ModelCss { get; set; }
        public string ColourCss { get; set; }
        public string TypeCss { get; set; }
        public string StatusCss { get; set; }
        public string QuantityCss { get; set; }
        public string ReserveQuantityCss { get; set; }
        public string BalanceQuantityCss { get; set; }

        public string Location1Css { get; set; }
        public string Location2Css { get; set; }
        public string Location3Css { get; set; }
        public string Location4Css { get; set; }
        public string Location5Css { get; set; }
        public string Location6Css { get; set; }
        public string Location7Css { get; set; }
        public string Location8Css { get; set; }
    }
}