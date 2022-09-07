using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IHSDC.WebApp.Models;
using IHSDC.WebApp.Connection;
using static IHSDC.WebApp.Filters.CustomFilters;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace IHSDC.WebApp.Controllers
{
    [SessionTimeoutAttribute]
    public class GEBController : Controller
    {

        ///dfdfgdhf
        readonly Connection.DBConnection con = new Connection.DBConnection();
        public JsonResult Childs(string ComdId, string Gid)
        {
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(ComdId));
            int gid = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(Gid));          


            var result = con.GEBLetterForwardedForUnit(item, gid).ToList();
                ViewBag.UnitName = result.ToList();
                ViewBag.UnitNameCount = result.Count();
            
          
           
            return Json(result, JsonRequestBehavior.AllowGet);

        }

        public JsonResult GetChildsList(string ComdId, string Gid)
        {
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(ComdId));
            int gid = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(Gid));

            var result = con.GEBLetterForwardedForUnitList(item, gid).ToList();
            ViewBag.UnitName = result.ToList();
            ViewBag.UnitNameCount = result.Count();



            return Json(result, JsonRequestBehavior.AllowGet);

        }
        public ActionResult GEBLetter(string id, string ComdId, string Gid)
        {

            ViewBag.ButtonName = "Add";
            GEBLetter model = new GEBLetter();
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.GEBLetterId = item;
                var editdata = con.GEBLetter_CRUD(2, model);
                model = editdata[0];
            }

            if (ComdId != null && ComdId != string.Empty && Gid != String.Empty && Gid != null)
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(ComdId));
                int gid = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(Gid));
                var result = con.GEBLetterForwardedForUnit(item, gid).ToList();
                ViewBag.UnitName = result.ToList();
                ViewBag.UnitNameCount = result.Count();

            }
            if (SessionManager.Role == "BrigAvn"|| SessionManager.Role== "SquadronCommander")
            {
                if (SessionManager.Role == "BrigAvn")
                {
                    model.GEBLetterId = 0;
                    var data1 = con.GEBLetter_CRUD(7, model);                 
                    model.ILGEBLetter = data1;
                    ViewBag.count = model.ILGEBLetter.Count();


                }
                if (Convert.ToString(SessionManager.Role) == "SquadronCommander")
                {
                    model.GEBLetterId = 0;
                    var data1 = con.GEBLetter_CRUD(5, model);
                    //Session["SubmitVal"] = data1[0].SubmitSqnCdr.ToString();
                    model.ILGEBLetter = data1;
                    ViewBag.count = model.ILGEBLetter.Count();

                }
            }
            else
            {

                model.GEBLetterId = 0;
                var data = con.GEBLetter_CRUD(2, model);
                model.ILGEBLetter = data;
                ViewBag.count = model.ILGEBLetter.Count();

            }


            return View(model);
        }
        public ActionResult GEBLetterBrigAvn(string fid)
        {
            Session["fid"] = fid;
            GEBLetter model = new GEBLetter();
            if (Convert.ToString(SessionManager.Role) == "GSO1AA7" || SessionManager.Role == "BrigAvn" || Convert.ToString(SessionManager.Role) == "DirAA7")
            {
                if (fid != string.Empty && fid != null)
                {
                    int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(fid));
                    model.GEBLetterId = item;
                    var result = con.GEBLetter_CRUD(6, model);
                    model.ILGEBLetter = result;
                }
            }
            ViewBag.count = model.ILGEBLetter.Count();

            return View(model);
        }
        public ActionResult GEBLetterBrigAvnNormal(string fid, string Uid)
        {
            Session["sfid"] = fid;
            Session["sUid"] = Uid;
            LetterForwardedGEB model = new LetterForwardedGEB();
            if (Convert.ToString(SessionManager.Role) == "GSO1AA7" || SessionManager.Role == "BrigAvn" || Convert.ToString(SessionManager.Role) == "DirAA7")
            {
                if (fid != string.Empty && fid != null && Uid != string.Empty && Uid != null)
                {
                    int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(fid));
                    int intid = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(Uid));
                    model.GEBLetterId = item;
                    var result = con.GEBListForGSO(item, intid);
                    model.ILLetterForwardedGEB = result;
                }
            }
            ViewBag.count = model.ILLetterForwardedGEB.Count();
            return View(model);
        }
        [HttpPost]
        public ActionResult GEBLetter(string id, GEBLetter model, string btnval)
        {
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            if (btnval == "Add")
            {

                var data = con.GEBLetter_CRUD(1, model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
                if (data[0].IsExist == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
            }
            if (btnval == "Update")
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.GEBLetterId = item;
                var data = con.GEBLetter_CRUD(3, model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("GEBLetter", new { id = string.Empty });
        }
        public ActionResult DeleteGEBLetter(string id)
        {
            GEBLetter model = new GEBLetter();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.GEBLetterId = item;
            var data = con.GEBLetter_CRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
            }
            return RedirectToAction("GEBLetter", new { id = string.Empty, ComdId = string.Empty, Gid = string.Empty });
        }
        //[HttpGet]
        //public ActionResult SubmitGEBLetter(string id, string submit, string Comd)
        //{
        //    int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
        //    int ComdId = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(Comd));
        //    var data = con.SubmitGEBLetter(submit, item, ComdId);
        //    if (data[0].IsSuccess == true)
        //    {
        //        DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
        //    }
        //    return RedirectToAction("GEBLetter", new { id = string.Empty ,  ComdId= string.Empty,  Gid = string.Empty });
        //}

       
        [HttpPost]
        public ActionResult SubmitGEBLetter(string id, string submit, string Comd, string Detailsstr)
        {
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            int ComdId = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(Comd));

            List<GEBLetterForwardedForUnit> value = JsonConvert.DeserializeObject<List<GEBLetterForwardedForUnit>>(Detailsstr);
            XElement table = new XElement("table");
            for (int i = 0; i < value.Count; i++)
            {
                XElement elements = new XElement("GEBLetterForwardedForUnit",
                    new XElement("ChildId", value[i].ChildId),
                    new XElement("UserName", value[i].UserName),
                    new XElement("RoleName", value[i].RoleName),
                    new XElement("TypeOfUnit", value[i].TypeOfUnit),
                    new XElement("IsSubmit", value[i].IsSubmit),
                    new XElement("IsNotification", value[i].IsNotification)
                    );
                table.Add(elements);
            }

            var data = con.SubmitGEBLetter(submit, item, ComdId, table.ToString());
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
            }
            return RedirectToAction("GEBLetter", new { id = string.Empty, ComdId = string.Empty, Gid = string.Empty });
        }


        [HttpGet]
        public ActionResult UserGEBList()
        {
            LetterForwardedGEB model = new LetterForwardedGEB();
            var data = con.LetterForwardedListGEB("LetterForwardedListGEB", 0);
            model.ILLetterForwardedGEB = data;
            if(data!=null && data.Count > 0) { 
            Session["LetterForwordedId"] = RepositryManager.EncryptionManager.Encryption(data[0].LetterForwardedId.ToString());
            }
            //SessionManager.GEBType = data[0].GEBType.ToString();

            ViewBag.count = model.ILLetterForwardedGEB.Count();
            return View(model);
        }
        [HttpGet]
        public ActionResult GEBAviatorList(string id, string fid)
        {
            LetterForwardedGEB model = new LetterForwardedGEB();

            if (id != null && id != "0" && id != string.Empty)
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                var result = con.LetterForwardedListGEB("AviatorList", item);
                if (result[0].IsSuccess == true)
                {
                    DisplayMessage(result[0].Msg, result[0].MidMsg, result[0].MsgStatus);
                }
            }

            if (fid != null && fid != "0" && fid != string.Empty)
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(fid));
                model.FinalAppxId = item;
                var editdata = con.EditUpdateGEB(1, model);
                model = editdata[0];

            }
            ViewBag.ButtonName = "Update";
            var data = con.LetterForwardedListGEB("Get", 0);
            model.ILLetterForwardedGEB = data;
            ViewBag.count = model.ILLetterForwardedGEB.Count();
            return View(model);
        }

        [HttpPost]
        public ActionResult UpdateGEBDetails(LetterForwardedGEB model)
        {
            var result = con.EditUpdateGEB(2, model);
            if (result[0].IsSuccess == true)
            {
                DisplayMessage(result[0].Msg, result[0].MidMsg, result[0].MsgStatus);
            }
          
            
            //return RedirectToAction("GenrateAppx", new { type = Convert.ToString(Session["type"]), fid = Convert.ToString(Session["fid"]), unit = Convert.ToString(Session["unit"]) });
            return RedirectToAction("GEBAviatorList", new { id = "0", fid = "0" });
        }


        [HttpPost]
        public ActionResult UpdateAppxE(LetterForwardedGEB model)
        {
            int procid = 2;

            if (SessionManager.Role == "FlightCommander" && SessionManager.UnitType == "INDEPENDENT" || SessionManager.Role == "SquadronCommander")
            { procid = 4;            }
            var result = con.EditUpdateGEB(procid, model);

            if (result[0].IsSuccess == true)
            {
                DisplayMessage(result[0].Msg, result[0].MidMsg, result[0].MsgStatus);
            }
            return RedirectToAction("GenrateAppx", new { type = Convert.ToString(Session["type"]), fid = Convert.ToString(Session["fid"]), unit = Convert.ToString(Session["unit"]) });
            
        }


        [HttpGet]
        public ActionResult SubmitGEBList(string id, string submit)
        {

            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            int LetterForwardedId = item;
            var data = con.SubmitGEBList(submit, LetterForwardedId);
            if (data.Count != 0)
            {
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                }
                if (SessionManager.Role == "GSO1AA7" || Convert.ToString(SessionManager.Role) == "DirAA7")
                {

                    return RedirectToAction("GEBLetter");
                }
            }
            return RedirectToAction("UserGEBList", new { id = string.Empty });
        }
        [HttpGet]
        public ActionResult SubmitGEBListSqn(string id, string submit)
        {

            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            int LetterForwardedId = item;
            var data = con.SubmitGEBList(submit, LetterForwardedId);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
            }

            return RedirectToAction("GEBLetter", new { id = string.Empty });
        }
        [HttpGet]
        public ActionResult GEBListForSqn(string id)
        {

            Session["ViewID"] = id;

            LetterForwardedGEB model = new LetterForwardedGEB();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            var data = con.GEBListForSqn(item);
            model.ILLetterForwardedGEB = data;
            return View(model);
        }


        // this view is Only For sqn User 
        public ActionResult GEBDetailsForSqnCdr(string id, string uid, string fid)
        {
            LetterForwardedGEB model = new LetterForwardedGEB();
            if (id != null && id != "0" && id != string.Empty && uid != null && uid != "0" && uid != string.Empty)
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                string UnitName = Convert.ToString(RepositryManager.EncryptionManager.Decryption(uid));
                var data = con.GEBDetailsForSqnCdr(item, UnitName).ToList();
                model.ILLetterForwardedGEB = data;



                Session["data"] = data;
                Session["id"] = id; Session["uid"] = uid;
            }
            if (fid != null && fid != "0" && fid != string.Empty)
            {
                int apxid = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(fid));
                model.FinalAppxId = apxid;
                var editdata = con.EditUpdateGEB(1, model);
                model = editdata[0];

            }
            ViewBag.ButtonName = "Update";
            model.ILLetterForwardedGEB = Session["data"] as List<LetterForwardedGEB>;
            return View(model);
        }
        public ActionResult GEBDetailsForGSO(string id, string uid,string type)
        {
            Session["id"] = id;
            Session["uid"] = uid;
            Session["type"] = type;

            int userid = 0;
            SessionManager.AppxC = type;
            LetterForwardedGEB model = new LetterForwardedGEB();
            if (id != null && id != "0" && id != string.Empty && uid != null && uid != "0" && uid != string.Empty)
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                string UnitName = Convert.ToString(RepositryManager.EncryptionManager.Decryption(uid));
                
                if (type == "AppxD")
                {
                    var data = con.GEBDetailsForSqnCdr(item, UnitName).ToList();
                    model.ILLetterForwardedGEB = data;
                }
                if (type == "AppxC")
                {
                    Session["type"] = type;
                    Session["id"] = id;
                    Session["uid"] = uid;

                    if (SessionManager.Role == "BrigAvn")
                        userid = 3;
                    if (SessionManager.Role == "FlightCommander" || SessionManager.Role == "SecondInCommand")
                        userid = 1;
                    if (SessionManager.Role == "GSO1AA7" || Convert.ToString(SessionManager.Role) == "DirAA7")
                        userid = 4;

                 var typeOfFLT= con.GetDataInList<string>("SELECT DISTINCT(TypeOfUnit) FROM dbo.View_Users WHERE EstablishmentFull='" + UnitName + "'").ToList();
                    Session["typeOfFLT"] = typeOfFLT[0].ToString();
                    var data = con.GenrateAppx(1, item, UnitName, userid).ToList();
                    model.ILLetterForwardedGEB = data;
                }
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult UpdateGEBDetailsForSqnCdr(LetterForwardedGEB model)
        {
            var result = con.EditUpdateGEB(3, model);
            if (result[0].IsSuccess == true)
            {
                DisplayMessage(result[0].Msg, result[0].MidMsg, result[0].MsgStatus);
            }

          
            return RedirectToAction("GenrateAppx", new { type = Session["type"].ToString(), fid = Session["fid"].ToString(), unit = Session["unit"].ToString() });

          

        }


        public ActionResult EditGEBDetails(string fid)
        {

            LetterForwardedGEB model = new LetterForwardedGEB();
            if (fid != null && fid != "0" && fid != string.Empty)
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(fid));
                model.FinalAppxId = item;
                var editdata = con.EditUpdateGEB(1, model);
                model = editdata[0];
            }

            ViewBag.ButtonName = "Update";

            return View(model);

        }

        public ActionResult AppxE(string fid)
        {

            LetterForwardedGEB model = new LetterForwardedGEB();
            if (fid != null && fid != "0" && fid != string.Empty)
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(fid));
                model.FinalAppxId = item;
                var editdata = con.EditUpdateGEB(1, model);
                model = editdata[0];
            }
             ViewBag.ButtonName = "Update";
            return View(model);
        }

        public ActionResult AppxEGSO1AA7View()
        {
            LetterForwardedGEB model = new LetterForwardedGEB();
           
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(Session["FinalAppxId"].ToString()));
                model.FinalAppxId = item;
                var editdata = con.EditUpdateGEB(1, model);
                model = editdata[0];
            }
            
            return View(model);

        }


        public ActionResult GEBDetails(string fid)
        {
            LetterForwardedGEB model = new LetterForwardedGEB();
            if (fid != null && fid != "0" && fid != string.Empty)
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(fid));
                model.FinalAppxId = item;
                var editdata = con.EditUpdateGEB(1, model);
                model = editdata[0];
                
            }

            return View(model);
        }
        public ActionResult AppxFPerformance(string apid)
        {
            AppxFPerformance model = new AppxFPerformance();

            if (apid != string.Empty && apid != null)
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(apid));
                model.FinalAppxId = item;
                var editdata = con.UpdateAppxFPerFormence(2, model);
                model = editdata[0];

                model.appxF = new AppxF();
                model.appxF.FinalAppxId = item;
                var AppxF = con.UpdateAppxF(2, model.appxF);
                model.appxF = AppxF[0];

                model.appxFFlgHrs = new AppxFFlgHrs();
                model.appxFFlgHrs.AppxFId = editdata[0].FinalAppxId;
                var AppxFFlgHrs = con.AppxFFlgHrs(2, model.appxFFlgHrs);
                model.ILAppxFFlgHrs = AppxFFlgHrs;

                model.appxFIntsrExp = new AppxFIntsrExp();
                model.appxFIntsrExp.AppxFId = editdata[0].FinalAppxId;
                var AppxFIntsrExp = con.AppxFIntsrExp(2, model.appxFIntsrExp);
                model.ILAppxFIntsrExp = AppxFIntsrExp;
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult AppxFPerformance(AppxFPerformance model)
        {
            var data = con.UpdateAppxFPerFormence(1, model);
            if (data[0].IsSuccess == true || data[0].IsExist == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
            }
            return RedirectToAction("GEBDetailsForGSO", new { id = Session["id"].ToString(), uid = Session["uid"].ToString(), type = Session["type"].ToString() });

        }

        public ActionResult AppxGPerformance(string apid)
        {
            AppxGPerformance model = new AppxGPerformance();

            if (apid != string.Empty && apid != null)
            {


                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(apid));
                model.FinalAppxId = item;
                var editdata = con.UpdateAppxGPerFormence(2, model);
                model = editdata[0];

                model.AppxG = new AppxG();
                model.AppxG.FinalAppxId = item;
                var UpdateAppxG = con.UpdateAppxG(2, model.AppxG);
                model.AppxG = UpdateAppxG[0];

                model.AppxGFlgHrs = new AppxGFlgHrs();
                model.AppxGFlgHrs.AppxGId = item;
                model.ILAppxGFlgHrs = con.AppxGFlgHrs(2, model.AppxGFlgHrs);

            }
            return View(model);
        }
        [HttpPost]
        public ActionResult AppxGPerformance(AppxGPerformance model)
        {
           
            var data = con.UpdateAppxGPerFormence(1, model);
            if (data[0].IsSuccess == true || data[0].IsExist == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
            }
            return RedirectToAction("GEBDetailsForGSO", new { id = Session["id"].ToString(), uid = Session["uid"].ToString(), type = Session["type"].ToString() });


        }
        //AppxEPerformance


        public ActionResult AppxEPerformance(string apid)
        {
            AppxEPerformance model = new AppxEPerformance();

            if (apid != string.Empty && apid != null)
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(apid));
                model.FinalAppxId = item;
                Session["FinalAppxId"] = RepositryManager.EncryptionManager.Encryption(model.FinalAppxId.ToString());
                var editdata = con.UpdateAppxEPerFormence(2, model);
                model = editdata[0];

                model.FinalAppxId = item;
                var data = con.EditUpdateGEB(1, model);
                model.finalAppx = data[0];
                ViewBag.Validation = editdata[0].CounterValidation;

            }
            return View(model);
        }
        [HttpPost]
        public ActionResult AppxEPerformance(AppxEPerformance model)
        {
            var data = con.UpdateAppxEPerFormence(1, model);
            if (data[0].IsSuccess == true || data[0].IsExist == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
            }
            return RedirectToAction("GEBDetailsForGSO", new { id = Session["id"].ToString(), uid = Session["uid"].ToString(), type = Session["type"].ToString() });

        }


        [HttpGet]
        public ActionResult AppxF(string apid)
        {

            FinalAppxF model = new FinalAppxF();

            if (apid != string.Empty && apid != null)
            {
                Session["apid"] = apid;
               
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(apid));
                model.appxF = new AppxF();
                model.appxF.FinalAppxId = item;
                var editdata = con.UpdateAppxF(2, model.appxF);

                model.appxFFlgHrs = new AppxFFlgHrs();
                model.appxFFlgHrs.AppxFId = editdata[0].FinalAppxId;
                model.ILAppxFFlgHrs = con.AppxFFlgHrs(2, model.appxFFlgHrs);
                

                model.appxFIntsrExp = new AppxFIntsrExp();
                model.appxFIntsrExp.AppxFId = editdata[0].FinalAppxId;
                model.ILAppxFIntsrExp = con.AppxFIntsrExp(2, model.appxFIntsrExp);               
                model.appxF = editdata[0];
                
                if(editdata[0].AHI_QFICourseNo!=string.Empty && editdata[0].AHI_QFICourseNo !=null )
                {
                    model.appxF.CourseType = editdata[0].AHI_QFICourseNo.Substring(0, 5);
                    var arr = editdata[0].AHI_QFICourseNo.Split('-');
                    model.appxF.AHI_QFICourseNo = arr[1];
                }
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult AppxF(FinalAppxF model)
        {

            string setCourseName = model.appxF.CourseType + model.appxF.AHI_QFICourseNo;
            model.appxF.AHI_QFICourseNo = setCourseName;

            int procid = 1;

            if (SessionManager.Role == "FlightCommander" && SessionManager.UnitType == "INDEPENDENT" || SessionManager.Role == "SquadronCommander")
            { procid = 4; }

            var data = con.UpdateAppxF(procid, model.appxF);
            if (data[0].IsSuccess == true || data[0].IsExist == true)
            {
                
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
            }
            return RedirectToAction("GenrateAppx", new { type = Convert.ToString(Session["type"]), fid = Convert.ToString(Session["fid"]), unit = Convert.ToString(Session["unit"]) });


        }


        public ActionResult AppxG(string apid)
        {
            FinalAppxG model = new FinalAppxG();

            if (apid != string.Empty && apid != null)
            {
                Session["apid"] = apid;
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(apid));


                model.AppxG = new AppxG();
                model.AppxG.FinalAppxId = item;
                var editdata = con.UpdateAppxG(2, model.AppxG);
                model.AppxG = editdata[0];

                model.AppxGFlgHrs = new AppxGFlgHrs();
                model.AppxGFlgHrs.AppxGId = item;
                model.ILAppxGFlgHrs = con.AppxGFlgHrs(2, model.AppxGFlgHrs);
             


            }
            return View(model);
        }
        [HttpPost]
        public ActionResult AppxG(FinalAppxG model)
        {
            int procid = 1;
            if (SessionManager.Role == "BrigAvn")
            {
                procid = 3;
            }
            if (SessionManager.Role == "GSO1AA7")
            {
                procid = 4;
            }
            if (SessionManager.Role == "FlightCommander" && SessionManager.UnitType == "INDEPENDENT" || SessionManager.Role == "SquadronCommander")
            { procid = 5; }
            var data = con.UpdateAppxG(procid, model.AppxG);
            if (data[0].IsSuccess == true || data[0].IsExist == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
            }
            if (data[0].Msg == "Updated Successfully")
            {
                return RedirectToAction("GenrateAppx", new { type = Convert.ToString(Session["type"]), fid = Convert.ToString(Session["fid"]), unit = Convert.ToString(Session["unit"]) });


            }

               
            if (SessionManager.Role == "BrigAvn" || SessionManager.Role == "GSO1AA7")
            {
                return RedirectToAction("GEBDetailsForGSO", new { id = Session["id"].ToString(), uid = Session["uid"].ToString(), type = Session["type"].ToString() });
            }

            return RedirectToAction("GenrateAppx", new { type = Convert.ToString(Session["type"]), fid = Convert.ToString(Session["fid"]), unit = Convert.ToString(Session["unit"]) });



        }


        [HttpGet]
        public ActionResult SubmitAppx(string fid, string submit)
        {
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(fid));         
            var data = con.SubmitAppx(submit, item);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
            }
            if(SessionManager.Role=="BrigAvn" || SessionManager.Role == "GSO1AA7" || Convert.ToString(SessionManager.Role) == "DirAA7")
            {

                return RedirectToAction("GEBDetailsForGSO", new {id = Session["id"].ToString(), uid = Session["uid"].ToString(), type = Session["type"].ToString() });
            }

            if(submit== "RejectForAppxF"|| submit == "RejectForAppxG" || submit == "SelectForAppxF" || submit == "SelectForAppxG")
            {
                return RedirectToAction("GenrateAppx", new { type = Session["type"].ToString(), fid = Session["fid"].ToString(), unit = Session["unit"].ToString() });
            }
            return RedirectToAction("UserGEBList");
        }

        [HttpGet]
        public ActionResult GenrateAppx(string  type,string fid,string unit)
        {
            LetterForwardedGEB model = new LetterForwardedGEB();
            if (type == "AppxC")
            {
                if (fid != string.Empty && fid != null)
                {
                    Session["type"] = type;
                    Session["fid"] = fid;
                    Session["unit"] = unit;
                    int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(fid));
                    string unitname = Convert.ToString(RepositryManager.EncryptionManager.Decryption(unit));
                    int userid = 0;
                    if (SessionManager.Role == "SecondInCommand" || SessionManager.Role == "FlightCommander")
                        userid = 1;
                    if (SessionManager.Role == "SquadronCommander" || Convert.ToString(SessionManager.Role) == "GSO1AA7" || SessionManager.Role == "BrigAvn" || Convert.ToString(SessionManager.Role) == "DirAA7")
                        userid = 2;
                    var data = con.GenrateAppx(1, item,unitname, userid);
                    model.ILLetterForwardedGEB = data;
                }
             
            }
            ViewBag.count = model.ILLetterForwardedGEB.Count();
            return View(model);
    }

        [HttpGet]
        public ActionResult AviatorListForNotifyUnit(string id)
        {
            AviatorCRUD model = new AviatorCRUD();
            model.Aviator_ID = 0;
            var data = con.AviatorListNotifyUnit("GEBAviatorListForNotifyUnit",Convert.ToInt32(id));            
            model.ILAviatorCRUD = data;
            ViewBag.count = model.ILAviatorCRUD.Count();
            ///Session["LetterForwordedId"]=data[0].
            return View(model);
        }

        public ActionResult CreateGEB(string id,string type)
        {
            int itemA = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            int LetterForwordedId = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(Convert.ToString(Session["LetterForwordedId"])));

            int procid = 1;
            if (type != string.Empty && type != null)
            {
               string t= Convert.ToString(RepositryManager.EncryptionManager.Decryption(type));
                if (t == "Reject")
                    procid = 2;
            }
            
          

            var result = con.CreateGEBForNotifyUnit(procid,itemA, LetterForwordedId).ToList();
            if (result != null)
            {
                DisplayMessage(result[0].Msg, result[0].MidMsg, result[0].MsgStatus);
            }
            return RedirectToAction("AviatorListForNotifyUnit");
        }


        [HttpGet]
        public ActionResult AppxFList(string type, string fid, string unit)
        {
            LetterForwardedGEB model = new LetterForwardedGEB();
            if (type == "AppxC")
            {
                if (fid != string.Empty && fid != null)
                {
                    Session["type"] = type;
                    Session["fid"] = fid;
                    Session["unit"] = unit;
                    int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(fid));
                    string unitname = Convert.ToString(RepositryManager.EncryptionManager.Decryption(unit));
                    int userid = 0;
                    if (SessionManager.Role == "SecondInCommand" || SessionManager.Role == "FlightCommander")
                        userid = 1;
                    if (SessionManager.Role == "SquadronCommander" || Convert.ToString(SessionManager.Role) == "GSO1AA7" || SessionManager.Role == "BrigAvn" || Convert.ToString(SessionManager.Role) == "DirAA7")
                        userid = 2;
                    var data = con.GenrateAppx(1, item, unitname, userid);
                    model.ILLetterForwardedGEB = data;
                }
            }
            ViewBag.count = model.ILLetterForwardedGEB.Count();
            return View(model);
        }

        #region Appx Flg Hrs
        // GET: Appx Flg Hrs
        [HttpGet]
        public ActionResult AddAppxFFlgHrs(string id, string fid)
        {
            ViewBag.ButtonName = "Add";
            AppxFFlgHrs model = new AppxFFlgHrs();
            //if (id != null && id != string.Empty)
            //{
            //    ViewBag.ButtonName = "Update";
            //    int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            //    model.AppxF_FlyingDetailId = item;
            //    var editdata = con.AppxFFlgHrs(2, model);
            //    model = editdata[0];
            //}
            //model.AppxF_FlyingDetailId = 0;
            //var data = con.AppxFFlgHrs(2, model);
            //model.ILAppxFFlgHrs  = data;
            //ViewBag.count = model.ILAppxFFlgHrs.Count();
            if (id != string.Empty && id != null)
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.AppxF_FlyingDetailId = item;
                model.AppxFId = (Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(fid)));
                var data = con.AppxFFlgHrs(2, model);
                model = data[0];
                ViewBag.ButtonName = "Update";
            }
            if (fid != string.Empty && fid != null)
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(fid));
                model.AppxFId = item;

            }
                 return View(model);
         }


        [HttpPost]
        public ActionResult AddAppxFFlgHrs(string id, AppxFFlgHrs model, string btnval)
        {
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            if (btnval == "Add")
            {
               // model.AppxFId = Convert.ToInt16(Session["appxFFlgHrs"]);
                var data = con.AppxFFlgHrs(1, model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
                if (data[0].IsExist == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
            }
            if (btnval == "Update")
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.AppxF_FlyingDetailId = item;
                var data = con.AppxFFlgHrs(3, model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AppxF", new { apid = Session["apid"].ToString() });
        }

        public ActionResult DeleteAppxFFlgHrs(string id)
        {
            AppxFFlgHrs model = new AppxFFlgHrs();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.AppxF_FlyingDetailId = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.AppxFFlgHrs(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Comd Deleted Successfully", " ", "s");
            }

            return RedirectToAction("appxf", new { apid = Convert.ToString(Session["apid"]) });
        }

        [HttpGet]
        public ActionResult AppxFInstrExp(string id, string Iid)
        {
            ViewBag.ButtonName = "Add";
            AppxFIntsrExp model = new AppxFIntsrExp();
            if (id != string.Empty && id != null)
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.AppxF_InstrExpId = item;
                model.AppxFId = (Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(Iid)));
                var data = con.AppxFIntsrExp(2, model);
                model = data[0];
                ViewBag.ButtonName = "Update";
            }
            if (Iid != string.Empty && Iid != null)
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(Iid));
                model.AppxFId = item;

            }
            return View(model);
        }


        [HttpPost]
        public ActionResult AppxFInstrExp(string id, AppxFIntsrExp model, string btnval)
        {
           // model.AppxFId = Convert.ToInt16(Session["appxFFlgHrs"]);
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            if (btnval == "Add")
            {

                var data = con.AppxFIntsrExp(1, model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
                if (data[0].IsExist == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
            }
            if (btnval == "Update")
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.AppxF_InstrExpId = item;
                var data = con.AppxFIntsrExp(3, model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AppxF", new { apid = Session["apid"].ToString() });
        }

        public ActionResult DeletAppxFIntsrExp(string id)
        {
            AppxFIntsrExp model = new AppxFIntsrExp();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.AppxF_InstrExpId = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.AppxFIntsrExp(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Comd Deleted Successfully", " ", "s");
            }

            return RedirectToAction("appxf", new { apid = Convert.ToString(Session["apid"]) });
        }


        [HttpGet]
        public ActionResult AddAppxGFlgHrs(string id, string fid)
        {
            ViewBag.ButtonName = "Add";
            AppxGFlgHrs model = new AppxGFlgHrs();
            
            if (id != string.Empty && id != null)
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.AppxG_FlyingDetailId = item;
                model.AppxGId = (Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(fid)));
                var data = con.AppxGFlgHrs(2, model);              
                model = data[0];
                ViewBag.ButtonName = "Update";
              
            }
            if (fid != string.Empty && fid != null)
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(fid));
                model.AppxGId = item;

            }
            return View(model);
        }


        [HttpPost]
        public ActionResult AddAppxGFlgHrs(string id, AppxGFlgHrs model, string btnval)
        {
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            if (btnval == "Add")
            {

                var data = con.AppxGFlgHrs(1, model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
                if (data[0].IsExist == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
            }
            if (btnval == "Update")
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.AppxG_FlyingDetailId = item;
                var data = con.AppxGFlgHrs(3, model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AppxG", new { apid = Session["apid"].ToString() });
        }

        public ActionResult DeleteAppxGFlgHrs(string id)
        {
            AppxGFlgHrs model = new AppxGFlgHrs();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.AppxG_FlyingDetailId = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.AppxGFlgHrs(4,model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Comd Deleted Successfully", " ", "s");
            }

            return RedirectToAction("AppxG", new { apid = Convert.ToString(Session["apid"]) });
        }

        #endregion


        [HttpGet]
        public ActionResult NominalRollForGEB(string gid)
        {
            NominalRollForGEB model = new NominalRollForGEB();
           int Letterid = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(gid));
            var data = con.GenrateNominalRoll(1,Letterid,string.Empty);          
            var Units = data.GroupBy(product => product.UnitName).Select(grp => grp.First()).Select(x => x.UnitName).ToList();
            ViewBag.Units = Units;
            model.ILLetterForwardedGEB = data;
            return View(model);
        }

        [HttpGet]        
       public ActionResult CancelGEBLetter(string gid)
        {
            int GEBLetterid = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(gid));
            var data = con.CancelGEBLetter(GEBLetterid);
            if(data[0].IsSuccess==true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
            }


            return RedirectToAction("GEBLetter", new { id = string.Empty, ComdId = string.Empty, Gid = string.Empty });
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