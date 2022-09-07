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
    [SessionTimeoutAttribute]
    public class AA7Controller : Controller
    {   
        readonly Connection.DBConnection con = new Connection.DBConnection();

        #region Aviator 
        // GET: Aviator 

            
        [HttpGet]
        public ActionResult AddAviator(string id)
        {
            ViewBag.ButtonName = "Add";
            AviatorCRUD model = new AviatorCRUD();
            int procid = 0;
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.Aviator_ID = item;

                if (Convert.ToString(SessionManager.Role) == "Unit")
                    procid = 2;
                if (Convert.ToString(SessionManager.Role) == "SecondInCommand")
                    procid = 5;
                if (Convert.ToString(SessionManager.Role) == "FlightCommander")
                    procid = 6;
               
                var editdata = con.AviatorCRUD(procid, model);
                model = editdata[0];
            }
           
            model.Aviator_ID = 0;
            if (Convert.ToString(SessionManager.Role) == "Unit")
                procid = 2;
            if (Convert.ToString(SessionManager.Role) == "SecondInCommand")
                procid = 5;
            if (Convert.ToString(SessionManager.Role) == "FlightCommander")
                procid = 6;
            if (Convert.ToString(SessionManager.Role) == "SquadronCommander" ||
                Convert.ToString(SessionManager.Role) == "BrigAvn")
                procid = 7;
            if (Convert.ToString(SessionManager.Role) == "GSO1AA7" || Convert.ToString(SessionManager.Role) == "DirAA7" || Convert.ToString(SessionManager.Role) == "ClkAA7" || Convert.ToString(SessionManager.Role) == "DGAvn")
                procid = 8;
            var data = con.AviatorCRUD(procid ,model);
            model.ILAviatorCRUD = data;
            ViewBag.count = model.ILAviatorCRUD.Count();
            return View(model);
        }


        [HttpPost]
        public ActionResult AddAviator(string id, AviatorCRUD model, string btnval)
        {
               model.ArmyNumber = model.PrefixLetter + model.ANumber + model.SuffixLetter.ToString();
            if (btnval == "Add")
            {

                var data = con.AviatorCRUD(1, model);
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
                model.Aviator_ID = item;
                var data = con.AviatorCRUD(3, model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddAviator", new { id = string.Empty });
        }

        public ActionResult DeleteAviator(string id)
        {
            AviatorCRUD model = new AviatorCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.Aviator_ID = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.AviatorCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);          
            }
            return RedirectToAction("AddAviator", new { id = string.Empty });
        }

        [HttpGet]
        public ActionResult SubmitAviator(string id, string submit)
        {
                        
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                int Aviator_ID = item;
                var data = con.AviatorSubmit(submit, Aviator_ID);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                }
           
            return RedirectToAction("AddAviator", new { id = string.Empty });
        }




        #endregion

        #region Aviator Contact Details
        // GET: Aviator Contact Details
        [HttpGet]
        public ActionResult AddAviatorContactDetails(string id)
        {
            ViewBag.ButtonName = "Add";
            AviatorContactDetailsCRUD model = new AviatorContactDetailsCRUD();
            int procid = 0;
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.AviatorDetailID = item;
                var editdata = con.AviatorContactDetailsCRUD(2, model);
                model = editdata[0];
            }

            if (Convert.ToString(SessionManager.Role) == "Unit")
                procid = 2;
            if (Convert.ToString(SessionManager.Role) == "SecondInCommand")
                procid = 5;
            if (Convert.ToString(SessionManager.Role) == "FlightCommander")
                procid = 6;
            if (Convert.ToString(SessionManager.Role) == "SquadronCommander" ||
                Convert.ToString(SessionManager.Role) == "BrigAvn")
                procid = 7;
            if (Convert.ToString(SessionManager.Role) == "GSO1AA7" || Convert.ToString(SessionManager.Role) == "DirAA7" || Convert.ToString(SessionManager.Role) == "ClkAA7" || Convert.ToString(SessionManager.Role) == "DGAvn")
                procid = 8;
            model.AviatorDetailID = 0;
            var data = con.AviatorContactDetailsCRUD(procid, model);
            model.ILAviatorContactDetailsCRUD = data;
            ViewBag.count = model.ILAviatorContactDetailsCRUD.Count();
            return View(model);
        }


        [HttpPost]
        public ActionResult AddAviatorContactDetails(string id, AviatorContactDetailsCRUD model, string btnval)
        {
           
            if (btnval == "Add")
            {

                var data = con.AviatorContactDetailsCRUD(1, model);
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
                model.AviatorDetailID = item;
                var data = con.AviatorContactDetailsCRUD(3, model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddAviatorContactDetails", new { id = string.Empty });
        }

        public ActionResult DeleteAviatorContactDetails(string id)
        {
            AviatorContactDetailsCRUD model = new AviatorContactDetailsCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.AviatorDetailID = item;
           
            var data = con.AviatorContactDetailsCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Comd Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddAviatorContactDetails", new { id = string.Empty });
        }

        [HttpGet]
        public ActionResult SubmitAviatorContactDetails(string id, string submit)
        {
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            string Query = GetCommonSubmitQuery(submit, "tbl_AviatorContactDetails", "AviatorDetailID", item).ToString();
            var mod = con.SubmitAviatorContactDetails(submit, Query).ToList();
            DisplayMessage(mod[0].Msg, mod[0].MidMsg, mod[0].MsgStatus);
            return RedirectToAction("AddAviatorContactDetails", new { id = string.Empty });

        }




        #endregion

        #region Aviator Courses
        // GET: Aviator Courses
        [HttpGet]
        public ActionResult AddAviatorCourses(string id)
        {
            int procid = 0;
            ViewBag.ButtonName = "Add";
            AviatorCoursesCRUD model = new AviatorCoursesCRUD();
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.AviatorCourses_ID = item;
                var editdata = con.AviatorCoursesCRUD(2, model);
                model = editdata[0];
            }
           
            if (Convert.ToString(SessionManager.Role) == "Unit")
                procid = 2;
            if (Convert.ToString(SessionManager.Role) == "SecondInCommand")
                procid = 5;
            if (Convert.ToString(SessionManager.Role) == "FlightCommander")
                procid = 6;
            if (Convert.ToString(SessionManager.Role) == "SquadronCommander" ||
                Convert.ToString(SessionManager.Role) == "BrigAvn")
                procid = 7;
            if ( Convert.ToString(SessionManager.Role) ==  "GSO1AA7" || Convert.ToString(SessionManager.Role) == "DirAA7" || Convert.ToString(SessionManager.Role) == "ClkAA7" || Convert.ToString(SessionManager.Role) == "DGAvn")
                procid = 8;
            model.AviatorCourses_ID = 0;
            var data = con.AviatorCoursesCRUD(procid, model);
            model.ILAviatorCoursesCRUD = data;
            ViewBag.count = model.ILAviatorCoursesCRUD.Count();
            return View(model);
        }
        [HttpPost]
        public ActionResult AddAviatorCourses(string id, AviatorCoursesCRUD model, string btnval)
        {
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            if (btnval == "Add")
            {

                var data = con.AviatorCoursesCRUD(1, model);
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
                model.AviatorCourses_ID = item;
                var data = con.AviatorCoursesCRUD(3, model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddAviatorCourses", new { id = string.Empty });
        }
        public ActionResult DeleteAviatorCourses(string id)
        {
            AviatorCoursesCRUD model = new AviatorCoursesCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.AviatorCourses_ID = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.AviatorCoursesCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Comd Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddAviatorCourses", new { id = string.Empty });
        }
        [HttpGet]
        public  ActionResult SubmitCourses(string id, string submit)
        {
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));           
            string Query = GetCommonSubmitQuery(submit, "tbl_AviatorCourses", "AviatorCourses_ID", item).ToString();
            var mod = con.SubmitCourse(submit, Query).ToList();
            DisplayMessage(mod[0].Msg, mod[0].MidMsg, mod[0].MsgStatus);
            return RedirectToAction("AddAviatorCourses", new { id = string.Empty });

        }
        #endregion

        #region Aviator Medical
        // GET: Aviator Courses
        [HttpGet]
        public ActionResult AddAviatorMedical(string id)
        {
            int procid = 0;
            ViewBag.ButtonName = "Add";
            AviatorMedicalCRUD model = new AviatorMedicalCRUD();
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.AviatorMedical_ID = item;
                var editdata = con.AviatorMedicalCRUD(2, model);
                model = editdata[0];
            }

            if (Convert.ToString(SessionManager.Role) == "Unit")
                procid = 2;
            if (Convert.ToString(SessionManager.Role) == "SecondInCommand")
                procid = 5;
            if (Convert.ToString(SessionManager.Role) == "FlightCommander")
                procid = 6;
            if (Convert.ToString(SessionManager.Role) == "SquadronCommander" ||
                Convert.ToString(SessionManager.Role) == "BrigAvn")
                procid = 7;
            if (Convert.ToString(SessionManager.Role) == "GSO1AA7" || Convert.ToString(SessionManager.Role) == "DirAA7" || Convert.ToString(SessionManager.Role) == "ClkAA7" || Convert.ToString(SessionManager.Role) == "DGAvn")
                procid = 8;
            model.AviatorMedical_ID = 0;
            var data = con.AviatorMedicalCRUD(procid, model);
            model.ILAviatorMedicalCRUD = data;
            ViewBag.count = model.ILAviatorMedicalCRUD.Count();
            return View(model);
        }
        [HttpPost]
        public ActionResult AddAviatorMedical(string id, AviatorMedicalCRUD model, string btnval)
        {
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            if (btnval == "Add")
            {

                var data = con.AviatorMedicalCRUD(1, model);
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
                model.AviatorMedical_ID = item;
                var data = con.AviatorMedicalCRUD(3, model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddAviatorMedical", new { id = string.Empty });
        }
        public ActionResult DeleteAviatorMedical(string id)
        {
            AviatorMedicalCRUD model = new AviatorMedicalCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.AviatorMedical_ID = item;
            var data = con.AviatorMedicalCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Comd Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddAviatorMedical", new { id = string.Empty });
        }
        [HttpGet]
        public ActionResult SubmitAviatorMedical(string id, string submit)
        {
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            string Query = GetCommonSubmitQuery(submit, "tbl_AviatorMedical", "AviatorMedical_ID", item).ToString();
            var mod = con.SubmitAviatorMedical(submit, Query).ToList();
            DisplayMessage(mod[0].Msg, mod[0].MidMsg, mod[0].MsgStatus);
            return RedirectToAction("AddAviatorMedical", new { id = string.Empty });

        }
        #endregion

        #region Aviator Honour Awards
        // GET: Aviator Courses
        [HttpGet]
        public ActionResult AddAviatorHonourAwards(string id)
        {
            int procid = 0;
            ViewBag.ButtonName = "Add";
            AviatorHonourAwardsCRUD model = new AviatorHonourAwardsCRUD();
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.AviatorHonourAwards_ID = item;
                var editdata = con.AviatorHonourAwardsCRUD(2, model);
                model = editdata[0];
            }
            if (Convert.ToString(SessionManager.Role) == "Unit")
                procid = 2;
            if (Convert.ToString(SessionManager.Role) == "SecondInCommand")
                procid = 5;
            if (Convert.ToString(SessionManager.Role) == "FlightCommander")
                procid = 6;
            if (Convert.ToString(SessionManager.Role) == "SquadronCommander" ||
                Convert.ToString(SessionManager.Role) == "BrigAvn")
                procid = 7;
            if (Convert.ToString(SessionManager.Role) == "GSO1AA7" || Convert.ToString(SessionManager.Role) == "DirAA7" || Convert.ToString(SessionManager.Role) == "ClkAA7" || Convert.ToString(SessionManager.Role) == "DGAvn")
                procid = 8;
            model.AviatorHonourAwards_ID = 0;
            var data = con.AviatorHonourAwardsCRUD(procid, model);
            model.ILAviatorHonourAwardsCRUD = data;
            ViewBag.count = model.ILAviatorHonourAwardsCRUD.Count();
            return View(model);
        }


        [HttpPost]
        public ActionResult AddAviatorHonourAwards(string id, AviatorHonourAwardsCRUD model, string btnval)
        {
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            if (btnval == "Add")
            {

                var data = con.AviatorHonourAwardsCRUD(1, model);
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
                model.AviatorHonourAwards_ID = item;
                var data = con.AviatorHonourAwardsCRUD(3, model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddAviatorHonourAwards", new { id = string.Empty });
        }

        public ActionResult DeleteAviatorHonourAwards(string id)
        {
            AviatorHonourAwardsCRUD model = new AviatorHonourAwardsCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.AviatorHonourAwards_ID = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.AviatorHonourAwardsCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Comd Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddAviatorHonourAwards", new { id = string.Empty });
        }

        [HttpGet]
        public ActionResult SubmitAviatorHonourAwards(string id, string submit)
        {
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            string Query = GetCommonSubmitQuery(submit, "tbl_AviatorHonourAwards", "AviatorHonourAwards_ID", item).ToString();
            var mod = con.SubmitCourse(submit, Query).ToList();
            DisplayMessage(mod[0].Msg, mod[0].MidMsg, mod[0].MsgStatus);
            return RedirectToAction("AddAviatorHonourAwards", new { id = string.Empty });
        }
        #endregion

        #region Aviator Special Eqpt
        // GET: Aviator Courses
        [HttpGet]
        public ActionResult AddAviatorSpecialEqpt(string id)
        {
            int procid = 0;
            ViewBag.ButtonName = "Add";
            AviatorSpecialEqptCRUD model = new AviatorSpecialEqptCRUD();
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.AviatorSpecialEqpt_ID = item;
                var editdata = con.AviatorSpecialEqptCRUD(2, model);
                model = editdata[0];
            }
            if (Convert.ToString(SessionManager.Role) == "Unit")
                procid = 2;
            if (Convert.ToString(SessionManager.Role) == "SecondInCommand")
                procid = 5;
            if (Convert.ToString(SessionManager.Role) == "FlightCommander")
                procid = 6;
            if (Convert.ToString(SessionManager.Role) == "SquadronCommander" ||
                Convert.ToString(SessionManager.Role) == "BrigAvn")
                procid = 7;
            if (Convert.ToString(SessionManager.Role) == "GSO1AA7" || Convert.ToString(SessionManager.Role) == "DirAA7" || Convert.ToString(SessionManager.Role) == "ClkAA7" || Convert.ToString(SessionManager.Role) == "DGAvn")
                procid = 8;
            model.AviatorSpecialEqpt_ID = 0;
            var data = con.AviatorSpecialEqptCRUD(procid, model);
            model.ILAviatorSpecialEqptCRUD = data;
            ViewBag.count = model.ILAviatorSpecialEqptCRUD.Count();
            return View(model);
        }


        [HttpPost]
        public ActionResult AddAviatorSpecialEqpt(string id, AviatorSpecialEqptCRUD model, string btnval)
        {
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            if (btnval == "Add")
            {

                var data = con.AviatorSpecialEqptCRUD(1, model);
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
                model.AviatorSpecialEqpt_ID = item;
                var data = con.AviatorSpecialEqptCRUD(3, model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddAviatorSpecialEqpt", new { id = string.Empty });
        }

        public ActionResult DeleteAviatorSpecialEqpt(string id)
        {
            AviatorSpecialEqptCRUD model = new AviatorSpecialEqptCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.AviatorSpecialEqpt_ID = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.AviatorSpecialEqptCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Comd Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddAviatorSpecialEqpt", new { id = string.Empty });
        }

        [HttpGet]
        public ActionResult SubmitAviatorSpecialEqpt(string id, string submit)
        {
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            string Query = GetCommonSubmitQuery(submit, "tbl_AviatorSpecialEqpt", "AviatorSpecialEqpt_ID", item).ToString();
            var mod = con.SubmitCourse(submit, Query).ToList();
            DisplayMessage(mod[0].Msg, mod[0].MidMsg, mod[0].MsgStatus);
            return RedirectToAction("AddAviatorSpecialEqpt", new { id = string.Empty });
        }
        #endregion

        #region   AviatorFlyingHrs
        [HttpGet]
        public ActionResult AddAviatorFlyingHrs(string id)
        {
            int procid = 0;
            ViewBag.ButtonName = "Add";
            AviatorFlyingHrsCRUD model = new AviatorFlyingHrsCRUD();
            model.UnitName = Convert.ToString(SessionManager.UnitName);
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.AviatorFlyingHrs_ID = item;
                var editdata = con.AviatorFlyingHrsCRUD(2, model);
                model = editdata[0];
            }
            if (Convert.ToString(SessionManager.Role) == "Unit")
                procid = 2;
            if (Convert.ToString(SessionManager.Role) == "SecondInCommand")
                procid = 5;
            if (Convert.ToString(SessionManager.Role) == "FlightCommander")
                procid = 6;
            if (Convert.ToString(SessionManager.Role) == "SquadronCommander" ||
                Convert.ToString(SessionManager.Role) == "BrigAvn")
                procid = 7;
            if (Convert.ToString(SessionManager.Role) == "GSO1AA7" || Convert.ToString(SessionManager.Role) == "DirAA7" || Convert.ToString(SessionManager.Role) == "ClkAA7" || Convert.ToString(SessionManager.Role) == "DGAvn")
                procid = 8;
            model.AviatorFlyingHrs_ID = 0;
            var data = con.AviatorFlyingHrsCRUD(procid, model);
            model.ILAviatorFlyingHrsCRUD = data;
            ViewBag.count = model.ILAviatorFlyingHrsCRUD.Count();
            return View(model);
        }


        [HttpPost]
        public ActionResult AddAviatorFlyingHrs(string id, AviatorFlyingHrsCRUD model, string btnval)
        {
            model.UnitName = Convert.ToString(SessionManager.UnitName);
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            model.Month = model.Month + " " + model.Year;
            if (btnval == "Add")
            {

                var data = con.AviatorFlyingHrsCRUD(1, model);
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
                model.AviatorFlyingHrs_ID = item;
                var data = con.AviatorFlyingHrsCRUD(3, model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddAviatorFlyingHrs", new { id = string.Empty });
        }

        public ActionResult DeleteAviatorFlyingHrs(string id)
        {
            AviatorFlyingHrsCRUD model = new AviatorFlyingHrsCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.AviatorFlyingHrs_ID = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.AviatorFlyingHrsCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);                
            }
            return RedirectToAction("AddAviatorFlyingHrs", new { id = string.Empty });
        }
        [HttpGet]
        public ActionResult SubmitAviatorFlyingHrs(string id, string submit)
        {
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            string Query = GetCommonSubmitQuery(submit, "tbl_AviatorFlyingHrs", "AviatorFlyingHrs_ID", item).ToString();
            var mod = con.SubmitCourse(submit, Query).ToList();
            DisplayMessage(mod[0].Msg, mod[0].MidMsg, mod[0].MsgStatus);
            return RedirectToAction("AddAviatorFlyingHrs", new { id = string.Empty });
        }

        #endregion

        #region   Aviator Accident
        [HttpGet]
        public ActionResult AddAviatorAccident(string id)
        {
            int procid = 0;
            ViewBag.ButtonName = "Add";
            AviatorAccidentCRUD model = new AviatorAccidentCRUD();
            model.UnitName = Convert.ToString(SessionManager.UnitName);
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.AviatorAccidentIncident_ID = item;
                model.UnitName = SessionManager.UnitName;
                var editdata = con.AviatorAccidentCRUD(2, model);
                model = editdata[0];
            }
            if (Convert.ToString(SessionManager.Role) == "Unit")
                procid = 2;
            if (Convert.ToString(SessionManager.Role) == "SecondInCommand")
                procid = 5;
            if (Convert.ToString(SessionManager.Role) == "FlightCommander")
                procid = 6;
            if (Convert.ToString(SessionManager.Role) == "SquadronCommander" ||
                Convert.ToString(SessionManager.Role) == "BrigAvn")
                procid = 7;
            if (Convert.ToString(SessionManager.Role) == "GSO1AA7" || Convert.ToString(SessionManager.Role) == "DirAA7" || Convert.ToString(SessionManager.Role) == "ClkAA7" || Convert.ToString(SessionManager.Role) == "DGAvn")
                procid = 8;
            model.AviatorAccidentIncident_ID = 0;
            var data = con.AviatorAccidentCRUD(procid, model);
            model.ILAviatorAccidentCRUD = data;
            ViewBag.count = model.ILAviatorAccidentCRUD.Count();
            return View(model);
        }
        [HttpPost]
        public ActionResult AddAviatorAccident(string id, AviatorAccidentCRUD model, string btnval)
        {
            
            if (btnval == "Add")
            {

                var data = con.AviatorAccidentCRUD(1, model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }               
            }
            if (btnval == "Update")
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.AviatorAccidentIncident_ID = item;
                var data = con.AviatorAccidentCRUD(3, model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddAviatorAccident", new { id = string.Empty });
        }
        public ActionResult DeleteAviatorAccident(string id)
        {
            AviatorAccidentCRUD model = new AviatorAccidentCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.AviatorAccidentIncident_ID = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.AviatorAccidentCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
            }
            return RedirectToAction("AddAviatorAccident", new { id = string.Empty });
        }
        [HttpGet]
        public ActionResult SubmitAviatorAccident(string id, string submit)
        {

            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            //int Aviator_ID = item;
            var data = con.AviatorAccidentSubmit(submit, item);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
            }

            return RedirectToAction("AddAviatorAccident", new { id = string.Empty });
        }

        #endregion
        
        #region GetUpdateQuery
        public string GetCommonSubmitQuery( string procid ,string TableName,string ColName,int ColValue)
        {
            string CurrentTime = ",ValidationDate =GETDATE()";
            string CounterValidationDate = ",CounterValidationDate =GETDATE()";
            string ValidateMSg = string.Empty;
            string CounterValidateMSg = string.Empty;
            string Query = string.Empty;
            string RejectFltCdrCounter = ",CounterValidation = NULL";


            switch (procid)
            {
                case "SubmitClk":
                    ValidateMSg = "'Submitted to 2IC'";
                    break;
                case "ReSubmitClk":
                    CounterValidateMSg = "'Submitted to Flt Cdr'";
                    break;
                    ///////////////
                case "Validate2IC":
                    ValidateMSg = "'Validated by 2IC'";
                    CounterValidateMSg = "'Submitted to Flt Cdr'";                 
                    break;
                case "Reject2IC":
                    ValidateMSg = "'Rejected by 2IC'";
                    break;
                case "ValidateFltCdr":
                    CounterValidateMSg = "'Validated by Flt Cdr'";
                    break;
                //case "RejectFltCdr":
                //    CounterValidateMSg = "'Rejected by Flt Cdr'";
                //    break;
                case "RejectFltCdr":
                    ValidateMSg = "'Rejected by Flt Cdr'";
                   
                    break;
            }
            if (procid == "SubmitClk" || procid== "Reject2IC")
            {
                Query = " UPDATE " + TableName + "   Set [Validation] =  '" + ValidateMSg + "' " + CurrentTime + " Where " + ColName + "=" + Convert.ToInt16(ColValue) + " ";
            }
            if(procid == "ValidateFltCdr" || procid == "ReSubmitClk" /*|| procid == "RejectFltCdr"*/)
            {
                Query = " UPDATE " + @TableName + "   Set [CounterValidation] =  '" + CounterValidateMSg + "' " + CounterValidationDate + " Where " + ColName + "=" + Convert.ToInt16(ColValue) + " ";
            }
            //string str = "\"" + Query + "\"";
            //Query = "" + Query + "".ToString();
            if (procid == "Validate2IC" )
            {
                Query = "Update  " + TableName + "  Set [Validation] ='" + ValidateMSg + "' " + CurrentTime + " ,[CounterValidation]='" + CounterValidateMSg + "'" + CounterValidationDate + " Where " + ColName + "=" + Convert.ToInt16(ColValue);
            }
            if (procid == "RejectFltCdr")
            {
                Query = "Update  " + TableName + "  Set [Validation] ='" + ValidateMSg + "' " + CurrentTime + RejectFltCdrCounter  + CounterValidationDate + " Where " + ColName + "=" + Convert.ToInt16(ColValue);
            }

            return Query.ToString();
        }

        #endregion

        #region Aviator  QUalification
        // GET: Aviator Courses
        [HttpGet]
        public ActionResult AddAviatorQualification(string id)
        {
            int procid = 0;
            ViewBag.ButtonName = "Add";
            AviatorSpecialQualCRUD model = new AviatorSpecialQualCRUD();
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.AviatorSpecialQual_ID = item;
                var editdata = con.AviatorSpecialQualification(2, model);
                model = editdata[0];
            }
           
            if (Convert.ToString(SessionManager.Role) == "Unit")
                procid = 2;
            if (Convert.ToString(SessionManager.Role) == "SecondInCommand")
                procid = 5;
            if (Convert.ToString(SessionManager.Role) == "FlightCommander")
                procid = 6;
            if (Convert.ToString(SessionManager.Role) == "SquadronCommander" ||
                Convert.ToString(SessionManager.Role) == "BrigAvn")
                procid = 7;
            if (Convert.ToString(SessionManager.Role) == "GSO1AA7" || Convert.ToString(SessionManager.Role) == "DirAA7" || Convert.ToString(SessionManager.Role) == "ClkAA7" || Convert.ToString(SessionManager.Role) == "DGAvn")
                procid = 8;
            model.AviatorSpecialQual_ID = 0;
            var data = con.AviatorSpecialQualification(procid, model);
            model.ILAviatorSpecialQualCRUD = data;
            ViewBag.count = model.ILAviatorSpecialQualCRUD.Count();
            return View(model);
        }
        [HttpPost]
        public ActionResult AddAviatorQualification(string id, AviatorSpecialQualCRUD model, string btnval)
        {
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            if (btnval == "Add")
            {

                var data = con.AviatorSpecialQualification(1, model);
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
                model.AviatorSpecialQual_ID = item;
                var data = con.AviatorSpecialQualification(3, model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddAviatorQualification", new { id = string.Empty });
        }
        public ActionResult DeleteAviatorQualification(string id)
        {
            AviatorSpecialQualCRUD model = new AviatorSpecialQualCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.AviatorSpecialQual_ID = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.AviatorSpecialQualification(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Comd Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddAviatorQualification", new { id = string.Empty });
        }
        [HttpGet]
        public ActionResult SubmitAviatorQualification(string id, string submit)
        {
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            string Query = GetCommonSubmitQuery(submit, "tbl_AviatorSpecialQual", "AviatorSpecialQual_ID", item).ToString();
            var mod = con.SubmitCourse(submit, Query).ToList();
            DisplayMessage(mod[0].Msg, mod[0].MidMsg, mod[0].MsgStatus);
            return RedirectToAction("AddAviatorQualification", new { id = string.Empty });

        }

        #endregion

        #region Aviator  Eqpt
        // GET: Aviator Courses
        [HttpGet]
        public ActionResult AddAviatorEqpt(string id)
        {
            int procid = 0;
            ViewBag.ButtonName = "Add";
            AviatorSpecialEqptCRUD model = new AviatorSpecialEqptCRUD();
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.AviatorSpecialEqpt_ID = item;
                var editdata = con.AviatorSpecialEqptCRUD(2, model);
                model = editdata[0];
            }
           
            if (Convert.ToString(SessionManager.Role) == "Unit")
                procid = 2;
            if (Convert.ToString(SessionManager.Role) == "SecondInCommand")
                procid = 5;
            if (Convert.ToString(SessionManager.Role) == "FlightCommander")
                procid = 6;
            if (Convert.ToString(SessionManager.Role) == "SquadronCommander" ||
                Convert.ToString(SessionManager.Role) == "BrigAvn")
                procid = 7;
            if (Convert.ToString(SessionManager.Role) == "GSO1AA7" || Convert.ToString(SessionManager.Role) == "DirAA7" || Convert.ToString(SessionManager.Role) == "ClkAA7" || Convert.ToString(SessionManager.Role) == "DGAvn")
                procid = 8;
            model.AviatorSpecialEqpt_ID = 0;
            var data = con.AviatorSpecialEqptCRUD(procid, model);
            model.ILAviatorSpecialEqptCRUD = data;
            ViewBag.count = model.ILAviatorSpecialEqptCRUD.Count();
            return View(model);
        }
        [HttpPost]
        public ActionResult AddAviatorEqpt(string id, AviatorSpecialEqptCRUD model, string btnval)
        {
           
            if (btnval == "Add")
            {

                var data = con.AviatorSpecialEqptCRUD(1, model);
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
                model.AviatorSpecialEqpt_ID = item;
                var data = con.AviatorSpecialEqptCRUD(3, model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddAviatorEqpt", new { id = string.Empty });
        }
        public ActionResult DeleteAviatorEqpt(string id)
        {
            AviatorSpecialEqptCRUD model = new AviatorSpecialEqptCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.AviatorSpecialEqpt_ID = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.AviatorSpecialEqptCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Comd Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddAviatorEqpt", new { id = string.Empty });
        }
        [HttpGet]
        public ActionResult SubmitAviatorEqpt(string id, string submit)
        {
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            string Query = GetCommonSubmitQuery(submit, "tbl_AviatorSpecialEqpt", "AviatorSpecialEqpt_ID", item).ToString();
            var mod = con.SubmitCourse(submit, Query).ToList();
            DisplayMessage(mod[0].Msg, mod[0].MidMsg, mod[0].MsgStatus);
            return RedirectToAction("AddAviatorEqpt", new { id = string.Empty });

        }

        #endregion

        #region Aviator  Appt
        // GET: Aviator Appt
        [HttpGet]
        public ActionResult AddAviatorAppt(string id)
        {            
            ViewBag.ButtonName = "Add";
            AviatorApptCRUD model = new AviatorApptCRUD();
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.AviatorAppointment_ID = item;
                var editdata = con.AviatorApptCRUD(2, model);
                model = editdata[0];
            }
            model.AviatorAppointment_ID = 0;
            var data = con.AviatorApptCRUD(2, model);
            model.ILAviatorApptCRUD = data;
            ViewBag.count = model.ILAviatorApptCRUD.Count();
            return View(model);
        }
        [HttpPost]
        public ActionResult AddAviatorAppt(string id, AviatorApptCRUD model, string btnval)
        {
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            if (btnval == "Add")
            {

                var data = con.AviatorApptCRUD(1, model);
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
                model.AviatorAppointment_ID = item;
                var data = con.AviatorApptCRUD(3, model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddAviatorAppt", new { id = string.Empty });
        }
        public ActionResult DeleteAviatorAppt(string id)
        {
            AviatorApptCRUD model = new AviatorApptCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.AviatorAppointment_ID = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.AviatorApptCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Comd Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddAviatorAppt", new { id = string.Empty });
        }

        #endregion

        #region Aviator  Rank
        // GET: Aviator Appt
        [HttpGet]
        public ActionResult AddAviatorRank(string id)
        {
            ViewBag.ButtonName = "Add";
            AviatorRankCRUD model = new AviatorRankCRUD();
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.AviatorRank_ID = item;
                var editdata = con.AviatorRankCRUD(2, model);
                model = editdata[0];
            }
            model.AviatorRank_ID = 0;
            var data = con.AviatorRankCRUD(2, model);
            model.ILAviatorRankCRUD = data;
            ViewBag.count = model.ILAviatorRankCRUD.Count();
            return View(model);
        }
        [HttpPost]
        public ActionResult AddAviatorRank(string id, AviatorRankCRUD model, string btnval)
        {
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            if (btnval == "Add")
            {///

                var data = con.AviatorRankCRUD(1, model);
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
                model.AviatorRank_ID = item;
                var data = con.AviatorRankCRUD(3, model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddAviatorRank", new { id = string.Empty });
        }
        public ActionResult DeleteAviatorRank(string id)
        {
            AviatorRankCRUD model = new AviatorRankCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.AviatorRank_ID = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.AviatorRankCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Comd Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddAviatorRank", new { id = string.Empty });
        }

        #endregion

        #region  AppxC
        // GET:  AppxC
        [HttpGet]
        public ActionResult AddAppxC(string id, string AppxListId)
        {
            string procid = string.Empty;
            ViewBag.ButtonName = "Add";
            AppxCCRUD model = new AppxCCRUD();
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.AppxCId = item;
                var editdata = con.AppxCCRUD("Edit", model);

                model = editdata[0];

            }
            TempData["AppxListId"] = AppxListId;
            int AppxLId = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(Convert.ToString(AppxListId)));
                model.AppxListId = AppxLId;
            if (Convert.ToString(SessionManager.Role) == "Unit")
                procid = "Unit";
            if (Convert.ToString(SessionManager.Role) == "SecondInCommand")
                procid = "2IC";
            if (Convert.ToString(SessionManager.Role) == "FlightCommander")
                procid = "FltCdr";
            if (Convert.ToString(SessionManager.Role) == "SquadronCommander" ||
                Convert.ToString(SessionManager.Role) == "BrigAvn")
                procid = "SqnCdr";
            if (Convert.ToString(SessionManager.Role) == "GSO1AA7" || Convert.ToString(SessionManager.Role) == "DirAA7" || Convert.ToString(SessionManager.Role) == "ClkAA7" || Convert.ToString(SessionManager.Role) == "DGAvn")
                procid = "All";
            model.AppxCId = 0;
            var data = con.AppxCCRUD(procid, model);
            model.ILAppxCCRUD = data;
            ViewBag.count = model.ILAppxCCRUD.Count();
            return View(model);
        }
        [HttpPost]
        public ActionResult AddAppxC(string id, AppxCCRUD model, string btnval, string AppxListId)
        {
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            if (btnval == "Add")
            {

                var data = con.AppxCCRUD("Add", model);
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
                model.AppxCId = item;                                  
                var data = con.AppxCCRUD("Update", model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddAppxC", new { id = string.Empty, AppxListId = TempData["AppxListId"].ToString() });
        }
        public ActionResult DeleteAppxC(string id)
        {
            AppxCCRUD model = new AppxCCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.AppxCId = item;
            var data = con.AppxCCRUD("Delete", model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Comd Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddAppxC", new { id = string.Empty });
        }
       
        #endregion

        #region Appx List
        // GET: Aviator 
        [HttpGet]
        public ActionResult AddAppxList(string id)
        {
            ViewBag.ButtonName = "Add";
            AppxListCRUD model = new AppxListCRUD();
            string procid = string.Empty;
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.AppxListId = item;
                if (Convert.ToString(SessionManager.Role) == "Unit")
                    procid = "Unit";
                if (Convert.ToString(SessionManager.Role) == "SecondInCommand")
                    procid = "2IC";
                if (Convert.ToString(SessionManager.Role) == "FlightCommander")
                    procid = "FltCdr";
                var editdata = con.AppxListCRUD(procid, model);
                model = editdata[0];
            }

            model.AppxListId = 0;
            if (Convert.ToString(SessionManager.Role) == "Unit")
                procid = "Unit";
            if (Convert.ToString(SessionManager.Role) == "SecondInCommand")
                procid = "2IC";
            if (Convert.ToString(SessionManager.Role) == "FlightCommander")
                procid = "FltCdr";
            if (Convert.ToString(SessionManager.Role) == "SquadronCommander" ||
                Convert.ToString(SessionManager.Role) == "BrigAvn")
                procid = "SqnCdr";
            if (Convert.ToString(SessionManager.Role) == "GSO1AA7" || Convert.ToString(SessionManager.Role) == "DirAA7" || Convert.ToString(SessionManager.Role) == "ClkAA7" || Convert.ToString(SessionManager.Role) == "DGAvn")
                procid = "All Data";
            var data = con.AppxListCRUD(procid, model);
            model.ILAppxListCRUD = data;
            ViewBag.count = model.ILAppxListCRUD.Count();
            return View(model);
        }


        [HttpPost]
        public ActionResult AddAppxList(string id, AppxListCRUD model, string btnval)
        {
            
            if (btnval == "Add")
            {

                var data = con.AppxListCRUD("Add", model);
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
                model.AppxListId = item;
                var data = con.AppxListCRUD("Update", model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddAppxList", new { id = string.Empty });
        }

        public ActionResult DeleteAppxList(string id)
        {
            AppxListCRUD model = new AppxListCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.AppxListId = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.AppxListCRUD("Delete", model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Comd Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddAppxLIst", new { id = string.Empty });
        }

        [HttpGet]
        public ActionResult SubmitAppxList(string id, string submit)
        {

            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            int AppxListId = item;
            var data = con.AppxListSubmit(submit, AppxListId);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
            }

            return RedirectToAction("AddAppxList", new { id = string.Empty });
        }




        #endregion

        #region   posting 
        [HttpGet]
        public ActionResult PostingAviatorOut(string id)
        {
            ViewBag.Button = "Add";
           PostingAviator model = new PostingAviator();
            if (id != null && id != string.Empty)
            {
                ViewBag.Button = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.AviatorPosting_ID = item;
                var editdata = con.PostingAviatorCRUD(2, model);
                model = editdata[0];
            }       
            model.AviatorPosting_ID = 0;
            var data = con.PostingAviatorCRUD(2, model);
            model.ILPostingAviator = data;
            ViewBag.count = model.ILPostingAviator.Count();
            return View(model);
        }
        [HttpPost]
        public ActionResult PostingAviatorOut(string id,string btnval,PostingAviator model)
        {
            if (btnval == "Add")
            {
                var data = con.PostingAviatorCRUD(1, model);
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
                model.AviatorPosting_ID = item;
                var data = con.PostingAviatorCRUD(3, model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                }
            }
            ViewBag.Button = "Add";
            return RedirectToAction("PostingAviatorOut", new { id = string.Empty });
        }

        
        public ActionResult DeletePostingAviator(string id)
        {
            PostingAviator model = new PostingAviator();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.AviatorPosting_ID = item;
            var data = con.PostingAviatorCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);                
            }
            return RedirectToAction("PostingAviatorOut", new { id = string.Empty });
        }



    

        public ActionResult SubmitPostingAviatorOut(string id, string submit)
        {

            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            int AviatorPosting_ID = item;
            var data = con.AviatorPostingSubmit(submit, AviatorPosting_ID);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
            }

            return RedirectToAction("PostingAviatorOut", new { id = string.Empty });
        }



        [HttpGet]
        public ActionResult PostingAviatorIn(string id)
        {
            ViewBag.Button = "Update";
            PostingAviator model = new PostingAviator();
            if (id != null && id != string.Empty)
            {
                ViewBag.Button = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.AviatorPosting_ID = item;
                var editdata = con.AviatorPostingIn(3, model);
                model = editdata[0];
            }
            int procid = 0;
            if (SessionManager.Role == "Unit")
                procid = 1;
                if (SessionManager.Role == "FlightCommander")
                procid = 2;            
            var data = con.AviatorPostingIn(procid, model);
            model.ILPostingAviator = data;
            ViewBag.count = model.ILPostingAviator.Count();
            return View(model);
        }



        [HttpPost]
        public ActionResult PostingAviatorIn(string id, string btnval, PostingAviator model)
        {
         
            if(id!=null && id != "")
            {
                if (btnval == "Update")
                {
                    int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                    model.AviatorPosting_ID = item;
                    var data = con.PostingAviatorCRUD(6, model);


                    if (data[0].IsSuccess == true)
                    {
                        DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                    }
                }
            }
            else
            {
                DisplayMessage("Can not be update user","","w");
            }
            ViewBag.Button = "Update";
            return RedirectToAction("PostingAviatorIn", new { id = string.Empty });
        }
        [HttpGet]
        public ActionResult SubmitPostingAviatorIn(string id, string submit)
        {

            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            int AviatorPosting_ID = item;
            var data = con.AviatorPostingSubmit(submit, AviatorPosting_ID);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
            }

            return RedirectToAction("PostingAviatorIn", new { id = string.Empty });
        }


        #endregion


        /// <summary>
        /// New Work
        /// </summary>
        /// <returns></returns>
        /// 
        #region

        [HttpGet]
        public ActionResult  ViewAviatorDetails(string id)
        {
            VieViewAviatorDetails model = new VieViewAviatorDetails();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
           
            var data = con.VieViewAviatorDetails(item);


            model.ILAviatorCRUD = data.ILAviatorCRUD;
            ViewBag.ILAviatorCRUDCount = model.ILAviatorCRUD.Count();
            
            model.ILAviatorContactDetailsCRUD = data.ILAviatorContactDetailsCRUD;
            ViewBag.ILAviatorContactDetailsCount = model.ILAviatorContactDetailsCRUD.Count();

            model.ILAviatorCoursesCRUD = data.ILAviatorCoursesCRUD;
            ViewBag.ILAviatorCoursesCount = model.ILAviatorCoursesCRUD.Count();

            model.ILAviatorHonourAwardsCRUD = data.ILAviatorHonourAwardsCRUD;
            ViewBag.ILAviatorHonourAwardsCount = model.ILAviatorHonourAwardsCRUD.Count();

            model.ILAviatorFlyingHrsCRUD = data.ILAviatorFlyingHrsCRUD;
            ViewBag.ILAviatorFlyingHrsCount = model.ILAviatorFlyingHrsCRUD.Count();

            model.ILAviatorSpecialEqptCRUD = data.ILAviatorSpecialEqptCRUD;
            ViewBag.ILAviatorSpecialEqptCount = model.ILAviatorSpecialEqptCRUD.Count();

            model.ILAviatorSpecialQualCRUD = data.ILAviatorSpecialQualCRUD;
            ViewBag.ILAviatorSpecialQualCount = model.ILAviatorSpecialQualCRUD.Count();

            model.ILAviatorMedicalCRUD = data.ILAviatorMedicalCRUD;
            ViewBag.ILAviatorMedicalCRUDCount = model.ILAviatorMedicalCRUD.Count();


            ViewBag.AviatorName = model.ILAviatorCRUD[0].AviatorName;
            ViewBag.UnitName = model.ILAviatorCRUD[0].UnitName;


            return View(model);
        }


        #endregion

        #region List


        public ActionResult AppxC()
        {


            ViewBag.ButtonName = "Add";
            AviatorCRUD model = new AviatorCRUD();
            int procid = 0;
            //if (id != null && id != string.Empty)
            //{
            //    ViewBag.ButtonName = "Update";
            //    int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            //    model.Aviator_ID = item;
            //    if (Convert.ToString(SessionManager.Role) == "Unit")
            //        procid = 2;
            //    if (Convert.ToString(SessionManager.Role) == "SecondInCommand")
            //        procid = 5;
            //    if (Convert.ToString(SessionManager.Role) == "FlightCommander")
            //        procid = 6;

            //    var editdata = con.AviatorCRUD(procid, model);
            //    model = editdata[0];
            //}

            model.Aviator_ID = 0;
            if (Convert.ToString(SessionManager.Role) == "Unit")
                procid = 2;
            if (Convert.ToString(SessionManager.Role) == "SecondInCommand")
                procid = 5;
            if (Convert.ToString(SessionManager.Role) == "FlightCommander")
                procid = 6;
            if (Convert.ToString(SessionManager.Role) == "SquadronCommander" ||
                Convert.ToString(SessionManager.Role) == "BrigAvn")
                procid = 7;
            if (Convert.ToString(SessionManager.Role) == "GSO1AA7" || Convert.ToString(SessionManager.Role) == "DirAA7" || Convert.ToString(SessionManager.Role) == "ClkAA7" || Convert.ToString(SessionManager.Role) == "DGAvn")
                procid = 8;
            var data = con.AviatorCRUD(procid, model);
            model.ILAviatorCRUD = data;
            ViewBag.count = model.ILAviatorCRUD.Count();
            return View(model);
        }


        #endregion 

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