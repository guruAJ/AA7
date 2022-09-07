using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IHSDC.WebApp.Models;
using IHSDC.WebApp.Connection;
using static IHSDC.WebApp.Filters.CustomFilters;

namespace IHSDC.WebApp.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        readonly Connection.DBConnection con = new Connection.DBConnection();
        int item = 0;
        public ActionResult UnitStrReturn(string id)
        {
            TransationStrengthReturn model = new TransationStrengthReturn();
            ViewBag.ButtonName = "Add";
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                 item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.StrId = item;
                var editData = con.IUDUnitStrReturn(model, 2).ToList();
                model = editData[0];

            }
            var result = con.IUDUnitStrReturn(model, 2).ToList();
            ViewBag.count = result.Count();
            model.ILTransationStrengthReturn = result;
            return View(model);
        }


        [HttpPost]
        public ActionResult UnitStrReturn(string btnName, TransationStrengthReturn model)
        {
            if(btnName == "Add")
            {
                var result = con.IUDUnitStrReturn(model, 1);
                if (result[0].IsSuccess == true)
                {
                    DisplayMessage(result[0].Msg, result[0].MidMsg, result[0].MsgStatus);

                }
                if (result[0].IsExist == true)
                {
                    DisplayMessage(result[0].Msg, result[0].MidMsg, result[0].MsgStatus);

                }

            }

            if (btnName == "Update")
            {
                 var result = con.IUDUnitStrReturn(model, 4);
                if (result[0].IsSuccess == true)
                {
                    DisplayMessage(result[0].Msg, result[0].MidMsg, result[0].MsgStatus);

                }               
            }
            return RedirectToAction("UnitStrReturn", new { id = string.Empty });
        }


        public ActionResult DeleteUnitStrReturn(string id)
        {
            TransationStrengthReturn model = new TransationStrengthReturn();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.Aviator_ID = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.IUDUnitStrReturn( model,5);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);         
            }
            return RedirectToAction("UnitStrReturn", new { id = string.Empty });
        }






        [HttpGet]
        public ActionResult GenerateIAFZ(string id )
        {
            

            TransationStrengthReturn model = new TransationStrengthReturn();
           model.StrId = item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            var result = con.IUDUnitStrReturn(model, 3).ToList();
            model.ILTransationStrengthReturn = result;
            return View(model);
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