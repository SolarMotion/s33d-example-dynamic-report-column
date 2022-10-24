using DynamicReportColumn.Data;
using DynamicReportColumn.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DynamicReportColumn.Web.Controllers
{
    public class AccumulatedStockReportController : Controller
    {
        private static readonly string SHOW_COLUMN_CSS = "";
        private static readonly string HIDE_COLUMN_CSS = "display:none;";

        public ActionResult Index()
        {
            var viewModel = new AccumulatedStockViewModel();

            RetrieveDisplayColumn(viewModel.ShownColumns);

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult IndexResult(AccumulatedStockViewModel viewModel, FormCollection collection, string Format)
        {
            try
            {
                return RetrieveAccumulatedStockReport(viewModel, collection);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        private ActionResult RetrieveAccumulatedStockReport(AccumulatedStockViewModel viewModel, FormCollection collection)
        {
            using (var db = new Database_Entities())
            {
                var spResult = db.usp_rpt_AccumulatedStockReport(0, 0, 0, 0, 0, 0, 0, 0, 0, 2).ToList();

                viewModel.ReportColumnCss.LocationCodeCss = viewModel.ShownColumns.First(a => a.ColumnValue == "locationCode").IsTick ? SHOW_COLUMN_CSS : HIDE_COLUMN_CSS;
                viewModel.ReportColumnCss.LocationCss = viewModel.ShownColumns.First(a => a.ColumnValue == "location").IsTick ? SHOW_COLUMN_CSS : HIDE_COLUMN_CSS;
                viewModel.ReportColumnCss.LocationTypeCss = viewModel.ShownColumns.First(a => a.ColumnValue == "locationType").IsTick ? SHOW_COLUMN_CSS : HIDE_COLUMN_CSS;
                viewModel.ReportColumnCss.RegionCss = viewModel.ShownColumns.First(a => a.ColumnValue == "region").IsTick ? SHOW_COLUMN_CSS : HIDE_COLUMN_CSS;
                viewModel.ReportColumnCss.BusinessUnitCss = viewModel.ShownColumns.First(a => a.ColumnValue == "businessUnit").IsTick ? SHOW_COLUMN_CSS : HIDE_COLUMN_CSS;
                viewModel.ReportColumnCss.ModelCss = viewModel.ShownColumns.First(a => a.ColumnValue == "model").IsTick ? SHOW_COLUMN_CSS : HIDE_COLUMN_CSS;
                viewModel.ReportColumnCss.ColourCss = viewModel.ShownColumns.First(a => a.ColumnValue == "colour").IsTick ? SHOW_COLUMN_CSS : HIDE_COLUMN_CSS;
                viewModel.ReportColumnCss.TypeCss = viewModel.ShownColumns.First(a => a.ColumnValue == "type").IsTick ? SHOW_COLUMN_CSS : HIDE_COLUMN_CSS;
                viewModel.ReportColumnCss.StatusCss = viewModel.ShownColumns.First(a => a.ColumnValue == "status").IsTick ? SHOW_COLUMN_CSS : HIDE_COLUMN_CSS;
                viewModel.ReportColumnCss.QuantityCss = viewModel.ShownColumns.First(a => a.ColumnValue == "quantity").IsTick ? SHOW_COLUMN_CSS : HIDE_COLUMN_CSS;
                viewModel.ReportColumnCss.ReserveQuantityCss = viewModel.ShownColumns.First(a => a.ColumnValue == "reserveQuantity").IsTick ? SHOW_COLUMN_CSS : HIDE_COLUMN_CSS;
                viewModel.ReportColumnCss.BalanceQuantityCss = viewModel.ShownColumns.First(a => a.ColumnValue == "balanceQuantity").IsTick ? SHOW_COLUMN_CSS : HIDE_COLUMN_CSS;

                viewModel.ReportColumnCss.Location1Css = viewModel.ShownColumns.First(a => a.ColumnValue == "location1").IsTick ? SHOW_COLUMN_CSS : HIDE_COLUMN_CSS;
                viewModel.ReportColumnCss.Location2Css = viewModel.ShownColumns.First(a => a.ColumnValue == "location2").IsTick ? SHOW_COLUMN_CSS : HIDE_COLUMN_CSS;
                viewModel.ReportColumnCss.Location3Css = viewModel.ShownColumns.First(a => a.ColumnValue == "location3").IsTick ? SHOW_COLUMN_CSS : HIDE_COLUMN_CSS;
                viewModel.ReportColumnCss.Location4Css = viewModel.ShownColumns.First(a => a.ColumnValue == "location4").IsTick ? SHOW_COLUMN_CSS : HIDE_COLUMN_CSS;
                viewModel.ReportColumnCss.Location5Css = viewModel.ShownColumns.First(a => a.ColumnValue == "location5").IsTick ? SHOW_COLUMN_CSS : HIDE_COLUMN_CSS;
                viewModel.ReportColumnCss.Location6Css = viewModel.ShownColumns.First(a => a.ColumnValue == "location6").IsTick ? SHOW_COLUMN_CSS : HIDE_COLUMN_CSS;
                viewModel.ReportColumnCss.Location7Css = viewModel.ShownColumns.First(a => a.ColumnValue == "location7").IsTick ? SHOW_COLUMN_CSS : HIDE_COLUMN_CSS;
                viewModel.ReportColumnCss.Location8Css = viewModel.ShownColumns.First(a => a.ColumnValue == "location8").IsTick ? SHOW_COLUMN_CSS : HIDE_COLUMN_CSS;

                viewModel.AccumulatedStockItemList = spResult.Select(a => new AccumulatedStockItemList()
                {
                    Region = a.RegionName,
                    BusinessUnit = a.BizUnitName,
                    CenterType = a.CenterTypeName,
                    Center = a.CenterName,
                    Model = a.ModelName,
                    Colour = a.ColourName,
                    Type = a.TypeName,
                    Status = a.StatusName,
                    Qty = a.Qty.ToString(),
                    ReserveQty = a.ReserveQty,
                    BalanceQty = a.BalanceQty ?? 0,
                    DealerCode = a.CenterCode,
                    IsSerializedString = a.IsSerialized ? "Yes" : "No",

                    Center1 = a.CenterName,
                    Center2 = a.CenterName,
                    Center3 = a.CenterName,
                    Center4 = a.CenterName,
                    Center5 = a.CenterName,
                    Center6 = a.CenterName,
                    Center7 = a.CenterName,
                    Center8 = a.CenterName,

                }).ToList();


                viewModel.RecordTotalCount = viewModel.AccumulatedStockItemList.Count();
                viewModel.ReportDate = DateTime.Now.ToString();
                viewModel.Center = "Test Center 1";

                return View(viewModel);
            }
        }

        private void RetrieveDisplayColumn(List<ShownColumn> ShownColumns)
        {
            var allActiveRoles = new Dictionary<string, string>();

            allActiveRoles.Add("locationCode", "Location Code");
            allActiveRoles.Add("location", "Location");
            allActiveRoles.Add("locationType", "Location Type");
            allActiveRoles.Add("region", "Region");
            allActiveRoles.Add("businessUnit", "Business Unit");
            allActiveRoles.Add("model", "Model");
            allActiveRoles.Add("colour", "Colour");
            allActiveRoles.Add("type", "Type");
            allActiveRoles.Add("status", "Status");
            allActiveRoles.Add("quantity", "Quantity");
            allActiveRoles.Add("reserveQuantity", "Reserve Quantity");
            allActiveRoles.Add("balanceQuantity", "Balance Quantity");

            allActiveRoles.Add("location1", "Location 1");
            allActiveRoles.Add("location2", "Location 2");
            allActiveRoles.Add("location3", "Location 3");
            allActiveRoles.Add("location4", "Location 4");
            allActiveRoles.Add("location5", "Location 5");
            allActiveRoles.Add("location6", "Location 6");
            allActiveRoles.Add("location7", "Location 7");
            allActiveRoles.Add("location8", "Location 8");

            foreach (var allActiveRole in allActiveRoles)
                ShownColumns.Add(new ShownColumn() { ColumnValue = allActiveRole.Key, ColumnName = allActiveRole.Value, IsTick = true });
        }
    }
}