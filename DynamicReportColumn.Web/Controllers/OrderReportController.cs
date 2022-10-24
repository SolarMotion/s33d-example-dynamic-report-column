using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DynamicReportColumn.Data;
using DynamicReportColumn.Web.Models;

namespace DynamicReportColumn.Web.Controllers
{
    public class OrderReportController : Controller
    {
        private static readonly string SHOW_COLUMN_CSS = "";
        private static readonly string HIDE_COLUMN_CSS = "display:none;";

        public ActionResult Index()
        {
            var viewModel = new OrderReportViewModel();

            RetrieveDisplayColumn(viewModel.ShownColumns);

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult IndexResult(OrderReportViewModel viewModel, FormCollection collection, string Format)
        {
            try
            {
                return RetrieveOrderReport(viewModel, collection);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        private ActionResult RetrieveOrderReport(OrderReportViewModel viewModel, FormCollection collection)
        {
            using (var db = new Database_Entities())
            {
                var spResult = db.usp_rpt_OrderReport(collection["dateType"].ToString(), null, null, viewModel.OrderReportIndex.OrderDateFrom, viewModel.OrderReportIndex.OrderDateTo,
                                                   viewModel.OrderReportIndex.CenterTypeID, viewModel.OrderReportIndex.StatusID, 0).ToList();

                viewModel.ReportColumnCss.RegionCss = viewModel.ShownColumns.First(a => a.ColumnValue == "region").IsTick ? SHOW_COLUMN_CSS : HIDE_COLUMN_CSS;
                viewModel.ReportColumnCss.StateCss = viewModel.ShownColumns.First(a => a.ColumnValue == "state").IsTick ? SHOW_COLUMN_CSS : HIDE_COLUMN_CSS;

                viewModel.OrderReportList = spResult.Select(a => new OrderReportList()
                {
                    Region = a.Region,
                    State = a.State,
                    CenterType = a.CenterType,
                    Code = a.CenterCode,
                    Location = a.Center,
                    OrderID = a.ID,
                    POSID = a.POSID,
                    OrderDT = a.OrderDT.ToString(),
                    ReceiveDT = a.OrderDT.ToString(),
                    Brand = a.Brand,
                    Model = a.Model,
                    ItemCode = a.ItemCode,
                    Qty = a.Qty.ToString(),
                    TaggedQty = a.Qty.ToString(),
                    Status = a.Status,
                    Remark = a.Remark,
                    Balance = a.Balance ?? 0,
                    Access = a.Access
                }).ToList();


                viewModel.RecordTotalCount = viewModel.OrderReportList.Count();
                viewModel.ReportDate = DateTime.Now.ToString();
                viewModel.Center = "Test Center 1";

                return View(viewModel);
            }
        }

        private void RetrieveDisplayColumn(List<ShownColumn> ShownColumns)
        {
            var allActiveRoles = new Dictionary<string, string>();

            allActiveRoles.Add("region", "Region");
            allActiveRoles.Add("state", "State");

            foreach (var allActiveRole in allActiveRoles)
                ShownColumns.Add(new ShownColumn() { ColumnValue = allActiveRole.Key, ColumnName = allActiveRole.Value, IsTick = true });
        }
    }
}