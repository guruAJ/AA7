using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace IHSDC.WebApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        // GET: Session Time Out

        public ActionResult SessionTimeOut()
        {


            return View();

        }
        public ActionResult index2()
        {


            return View();

        }
        public ActionResult Index()
        {
            if (Session["UserIntId"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            //var UserId = Session["UserIntId"];
            //Session.Clear();
            //Session.RemoveAll();
            //Session["UserIntId"] = UserId;
            return View();
        }
        [HttpPost]
        public ActionResult Upload(string data1,string filename)
        {
            //create pdf
            
            var dir = Server.MapPath("~/Content/ExportPdf");

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
               string FileDetails = filename + DateTime.Now.ToString("ddmmyyyyhhmmss") + ".pdf";
            
            var fileName = dir + "\\" + FileDetails;
          
            byte[] result = Convert.FromBase64String(data1);
            if (!Directory.Exists(fileName))
            {        
         
                using (FileStream Writer = new System.IO.FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    Writer.Write(result, 0, result.Length);
                    Session["filename"] = FileDetails;
                }
                //using (FileStream Writer = new System.IO.FileStream(fileName1, FileMode.Create, FileAccess.Write))
                //{
                //    Writer.Write(result, 0, result.Length);
                //    Session["filename1"] = FileDetails1;
                //}
            }
            else
            {
                
            }

            return RedirectToAction("ReadPdf","Home");
        }


        public string GetIPAddress(bool OnlyIP = false)
        {
            string IP = HttpContext.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (string.IsNullOrEmpty(IP))
            {
                IP = HttpContext.Request.ServerVariables["REMOTE_ADDR"];
                return IP;
            }
            else
            {
                string RemoteIP = HttpContext.Request.ServerVariables["REMOTE_ADDR"];
                return string.IsNullOrEmpty(RemoteIP) && OnlyIP ? IP : string.Format("{0} ({1})", IP, RemoteIP);
            }
        }




        public ActionResult ReadPdf()
        {
            string myCookie = GetIPAddress(true);
            string fileName = Session["filename"].ToString();
           /// string fileName1 = Session["filename1"].ToString();
            PdfReader PDFReader = new PdfReader(Server.MapPath("~/Content/ExportPdf/"+fileName));

            FileStream Stream = new FileStream(Server.MapPath("~/Content/ExportPdf/test.pdf" ), FileMode.Create, FileAccess.Write);

            PdfStamper PDFStamper = new PdfStamper(PDFReader, Stream);

            for (int iCount = 0; iCount < PDFStamper.Reader.NumberOfPages; iCount++)
            {
                PdfContentByte PDFData = PDFStamper.GetUnderContent(iCount + 1);
                BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.WINANSI, BaseFont.EMBEDDED);
                PDFData.BeginText();
                PDFData.SetColorFill(CMYKColor.LIGHT_GRAY);
                PDFData.SetFontAndSize(baseFont, 60);
                PDFData.ShowTextAligned(PdfContentByte.ALIGN_CENTER, myCookie.ToString(), 300, 400, 45);
                PDFData.SetFontAndSize(baseFont, 30);
                PDFData.ShowTextAligned(PdfContentByte.ALIGN_CENTER, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), 320, 370, 45);
                PDFData.EndText();
            }
            PDFStamper.FormFlattening = true;
            PDFStamper.Close();
            PDFReader.Close();
            return File("~/Content/ExportPdf/test.pdf", "application/pdf");
        }   


    }
}