using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.UI;
using PagedList;
using PagedList.Mvc;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using AA7.Models;
using Microsoft.Reporting.WebForms;

namespace AA7.Controllers
{
    public class dbo_ViewListofSearchController : Controller
    {
        private IHSDCAA7DBDBContext db = new IHSDCAA7DBDBContext();

        // GET: Session Time Out

        public ActionResult SessionTimeOut()
        {


            return View();

        }
        // Search List
        public ActionResult SearchList()
        {
            if (Session["UserIntId"] == null)
            {
                return View("SessionTimeOut");
            }

            int SessionId = Convert.ToInt32(Session["UserIntId"].ToString());

            try
            {
                if (db.dbo_tbl_SeacrhHeading.Where(x => x.SearchedBy == SessionId).Max(x => x.Sno) > 0)
                {
                    int Sno = db.dbo_tbl_SeacrhHeading.Where(x => x.SearchedBy == SessionId).Max(x => x.Sno);
                    int searchtype = db.dbo_tbl_SearchType.Where(x => x.Sno == Sno).Max(x => x.SearchTypeId);
                    return View(db.dbo_ViewListofSearch.Where(x => x.SearchedBy == SessionId && x.SearchTypeId == searchtype).ToList());
                }
            }
            catch (Exception)
            {
                Session["Heading"] = "No Search List Created by You";
            }
            

            return View("NoListSelected");
                
        }
        // GET: Session Time Out

        // reportgeneration Report
        public ActionResult SearchReport()
        {
            if (Session["UserIntId"] == null)
            {
                return View("SessionTimeOut");
            }

            int SessionId = Convert.ToInt32(Session["UserIntId"].ToString());
            int Sno = db.dbo_tbl_SeacrhHeading.Where(x => x.SearchedBy == SessionId).Max(x => x.Sno);
            int searchtype = db.dbo_tbl_SearchType.Where(x => x.Sno == Sno).Max(x => x.SearchTypeId);
            LocalReport localreport = new LocalReport();
            localreport.ReportPath = Server.MapPath("~/Reports/Report.rdlc");
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "ReportList";
            reportDataSource.Value = db.dbo_ViewListofSearch.Where(x => x.SearchedBy == SessionId && x.SearchTypeId == searchtype).ToList();
            //reportDataSource.Name = "Heading";
            //reportDataSource.Value = db.dbo_tbl_SeacrhHeading.Where(x=>x.Sno==Sno).ToList();
            localreport.DataSources.Add(reportDataSource);
            String reportingitem = ".pdf";
            String mimeType;
            String encoding;
            String[] stream;
            Warning[] warning;
            byte[] renderedbyte;
            renderedbyte = localreport.Render("PDF", "", out mimeType, out encoding, out reportingitem, out stream, out warning);
            Response.AddHeader("content-disposition", "attachment;filename=Report." + reportingitem);
            return File(renderedbyte, reportingitem);


        }




        public ActionResult NoListSelected()
        {

            Session["Heading"] = "No Search List Created by You";
            return View();

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

     
        }

    }

