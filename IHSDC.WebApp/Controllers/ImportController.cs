using System;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using IHSDC.WebApp.Models;
using IHSDC.WebApp.Connection;
using static IHSDC.WebApp.Filters.CustomFilters;

namespace IHSDC.WebApp.Controllers
{
    [SessionTimeoutAttribute]
    public class ImportController : Controller
    {

        readonly DBConnection con = new DBConnection();

        public ActionResult importData()
        {
            return View();
        }
        string query = string.Empty;

      [HttpPost]
        public ActionResult ImportData(HttpPostedFileWrapper[] fileBase)
        {
            ImportResult model = new ImportResult();
            foreach (var file in fileBase)
            {
                if (file.ContentLength > 0) //if file not empty the go to 
                {
                    string _FileName = Path.GetFileName(file.FileName);
                    if (_FileName == "Aviator.xml")
                    {
                        Session["_FileName"] = _FileName.ToString();
                    }
                    string _path = Path.Combine(Server.MapPath("~/Content/XML"), _FileName);
                    if ((System.IO.File.Exists(_path)))
                    {
                        try
                        {
                            System.IO.File.Delete(_path);
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    file.SaveAs(_path);
                    XmlDocument doc = new XmlDocument();
                    //For Aviator 
                    if (_FileName == "Aviator.xml")
                    {
                         doc.Load(Server.MapPath("~/Content/XML/" + Convert.ToString(Session["_FileName"].ToString())));
                         query = "<Table>" + doc.DocumentElement.InnerXml.ToString() + "</Table>";
                        var data = con.CheckXML(1, query);
                        if (data[0].IsSuccess == true)
                        {
                            DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                        }                        
                    }
                    //For Aviator COurse
                    if (_FileName == "Course.xml")
                    {
                        doc.Load(Server.MapPath("~/Content/XML/" + Convert.ToString(_FileName)));
                         query = "<Table>" + doc.DocumentElement.InnerXml.ToString() + "</Table>";
                        var data = con.ReadXML(2, query);
                        if (data[0].IsSuccess == true)
                        {
                            DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                        }
                    }
                    /// For Aviator Honour Award
                    if (_FileName == "HonourAward.xml")
                    {
                        doc.Load(Server.MapPath("~/Content/XML/" + Convert.ToString(_FileName)));
                        query = "<Table>" + doc.DocumentElement.InnerXml.ToString() + "</Table>";
                        var data = con.ReadXML(3, query);
                        if (data[0].IsSuccess == true)
                        {
                            DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                        }
                    }
                    ///-For Aviator Contact details
                    if (_FileName == "ContactDetail.xml")
                    {
                        doc.Load(Server.MapPath("~/Content/XML/" + Convert.ToString(_FileName)));
                        query = "<Table>" + doc.DocumentElement.InnerXml.ToString() + "</Table>";
                        var data = con.ReadXML(4, query);
                        if (data[0].IsSuccess == true)
                        {
                            DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                        }
                    }
                    //For Aviator SP QUAL
                    if (_FileName == "SpecialQual.xml")
                    {
                        doc.Load(Server.MapPath("~/Content/XML/" + Convert.ToString(_FileName)));
                        query = "<Table>" + doc.DocumentElement.InnerXml.ToString() + "</Table>";
                        var data = con.ReadXML(5, query);
                        if (data[0].IsSuccess == true)
                        {
                            DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                        }
                    }
                    ////NOT TESTED
                    ///For Aviator SP EQPT
                    if (_FileName == "SpecialEqpt.xml")
                    {
                        doc.Load(Server.MapPath("~/Content/XML/" + Convert.ToString(_FileName)));
                        query = "<Table>" + doc.DocumentElement.InnerXml.ToString() + "</Table>";
                        var data = con.ReadXML(6, query);
                        if (data[0].IsSuccess == true)
                        {
                            DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                        }
                    }
                    
                    //For Aviator Medical 
                    if (_FileName == "Medical.xml")
                    {
                        doc.Load(Server.MapPath("~/Content/XML/" + Convert.ToString(_FileName)));
                        query = "<Table>" + doc.DocumentElement.InnerXml.ToString() + "</Table>";
                        var data = con.ReadXML(7, query);
                        if (data[0].IsSuccess == true)
                        {
                            DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                        }
                    }
                    ///AVIATOR FLYING HRS Data 
                    if (_FileName == "FlyingHrs.xml")
                    {
                        doc.Load(Server.MapPath("~/Content/XML/" + Convert.ToString(_FileName)));
                        query = "<Table>" + doc.DocumentElement.InnerXml.ToString() + "</Table>";
                        var data = con.ReadXML(8, query);
                        if (data[0].IsSuccess == true)
                        {
                            DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                        }
                    }
                    //Aviator Posting  
                    if (_FileName == "Posting.xml")
                    {
                        doc.Load(Server.MapPath("~/Content/XML/" + Convert.ToString(_FileName)));
                        query = "<Table>" + doc.DocumentElement.InnerXml.ToString() + "</Table>";
                        var data = con.ReadXML(9, query);
                        if (data[0].IsSuccess == true)
                        {
                            DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                        }
                    }
                }
            }         
            return View(model);
       
        }

        public ActionResult UploadAviator(string c)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath("~/Content/XML/" + Convert.ToString(Session["_FileName"].ToString())));
            query = "<Table>" + doc.DocumentElement.InnerXml.ToString() + "</Table>";
            var data = con.ReadXML(1, query);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
            }
            return RedirectToAction("ImportData");
        }


        


        #region message
        public void DisplayMessage(string message, string midMsg, string messageStatus_s_e_w_i_Or_blank)
        {
            string status = messageStatus_s_e_w_i_Or_blank.ToLower();
            TempData["Message"] = message;
            TempData["messagemidStatus"] = midMsg;
            if (status == "s")
                TempData["messageStatus"] = "success";
            else if (status == "e")
                TempData["messageStatus"] = "error";
            else if (status == "w")
                TempData["messageStatus"] = "warning";
            else if (status == "i")
                TempData["messageStatus"] = "info";
        }
        #endregion
    }

}


