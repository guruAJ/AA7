using System;
using System.Linq;
using System.Web.Mvc;
using IHSDC.WebApp.Models;
using IHSDC.WebApp.Connection;
using static IHSDC.WebApp.Filters.CustomFilters;

namespace IHSDC.WebApp.Controllers
{
    [SessionTimeoutAttribute]
    public class MasterController : Controller
    {
        readonly Connection.DBConnection con = new Connection.DBConnection();
        #region Comd
        // GET: Comd
        [HttpGet]
        public ActionResult AddComd(string id)
        {

            ViewBag.ButtonName = "Add";
            ComdCRUD model = new ComdCRUD();
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.ComdId = item;
                var editdata = con.ComdCRUD(2, model);
                model = editdata[0];
            }
            model.ComdId = 0;
            var data = con.ComdCRUD(2, model);
            model.ILComdCRUD = data;
            ViewBag.count = model.ILComdCRUD.Count();
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddComd(string id, ComdCRUD model, string btnval)
        {
            if (ModelState.IsValid)
            {
                model.UserId = Convert.ToInt32(SessionManager.UserIntId);
                if (btnval == "Add")
                {

                    var data = con.ComdCRUD(1, model);
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
                    model.ComdId = item;
                    var data = con.ComdCRUD(3, model);
                    if (data[0].IsSuccess == true)
                    {
                        DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                    }
                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddComd", new { id = string.Empty });
        }

        public ActionResult DeleteComd(string id)
        {
            ComdCRUD model = new ComdCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.ComdId = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.ComdCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Comd Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddComd", new { id = string.Empty });
        }
        #endregion




        #region Rank
        // GET: Comd
        [HttpGet]
        public ActionResult AddRank(string id)
        {

            ViewBag.ButtonName = "Add";
            RankCRUD model = new RankCRUD();
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.RankId = item;
                var editdata = con.RankCRUD(2, model);
                model = editdata[0];
            }
            model.RankId = 0;
            var data = con.RankCRUD(2, model);
            model.ILRankCRUD = data;
            ViewBag.count = model.ILRankCRUD.Count();
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddRank(string id, RankCRUD model, string btnval)
        {
            if (ModelState.IsValid)
            {
                model.UserId = Convert.ToInt32(SessionManager.UserIntId);
                if (btnval == "Add")
                {

                    var data = con.RankCRUD(1, model);
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
                    model.RankId = item;
                    var data = con.RankCRUD(3, model);
                    if (data[0].IsSuccess == true)
                    {
                        DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                    }
                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddRank", new { id = string.Empty });
        }

        public ActionResult DeleteRank(string id)
        {
            RankCRUD model = new RankCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.RankId = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.RankCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Comd Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddRank", new { id = string.Empty });
        }
        #endregion


        #region Corps
        // GET: Corps
        [HttpGet]
        public ActionResult AddCorps(string id)
        {
            ViewBag.ButtonName = "Add";
            CorpsCRUD model = new CorpsCRUD();
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.CorpsId = item;
                var editdata = con.CorpsCRUD(2, model);
                model = editdata[0];
            }
            model.CorpsId = 0;
            var data = con.CorpsCRUD(2, model);
            model.ILCorpsCRUD = data;
            ViewBag.count = model.ILCorpsCRUD.Count();
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCorps(string id, CorpsCRUD model, string btnval)
        {
            if (ModelState.IsValid)
            {
                model.UserId = Convert.ToInt32(SessionManager.UserIntId);
                if (btnval == "Add")
                {

                    var data = con.CorpsCRUD(1, model);
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
                    model.CorpsId = item;
                    var data = con.CorpsCRUD(3, model);
                    if (data[0].IsSuccess == true)
                    {
                        DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                    }
                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddCorps", new { id = string.Empty });
        }

        public ActionResult DeleteCorps(string id)
        {
            CorpsCRUD model = new CorpsCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.CorpsId = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.CorpsCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Corps Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddCorps", new { id = string.Empty });
        }
        #endregion

        #region Unit
        // GET: Corps
        [HttpGet]
        public ActionResult AddUnit(string id)
        {
            ViewBag.ButtonName = "Add";
            UnitCRUD model = new UnitCRUD();
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.Unit_ID = item;
                var editdata = con.UnitCRUD(2, model);
                model = editdata[0];
            }
            model.Unit_ID = 0;
            var data = con.UnitCRUD(2, model);
            model.ILUnitCRUD = data;
            ViewBag.count = model.ILUnitCRUD.Count();
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddUnit(string id, UnitCRUD model, string btnval)
        {
            if (ModelState.IsValid)
            {
                model.UserId = Convert.ToInt32(SessionManager.UserIntId);
                if (btnval == "Add")
                {

                    var data = con.UnitCRUD(1, model);
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
                    model.Unit_ID = item;
                    var data = con.UnitCRUD(3, model);
                    if (data[0].IsSuccess == true)
                    {
                        DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                    }
                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddUnit", new { id = string.Empty });
        }

        public ActionResult DeleteUnit(string id)
        {
            UnitCRUD model = new UnitCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.Unit_ID = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.UnitCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Corps Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddUnit", new { id = string.Empty });
        }
        #endregion

        #region Course
        // GET: Course
        [HttpGet]
        public ActionResult AddCourse(string id)
        {
            ViewBag.ButtonName = "Add";
            CoursesCRUD model = new CoursesCRUD();
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.Course_ID = item;
                var editdata = con.CoursesCRUD(2, model);
                model = editdata[0];
            }
            model.Course_ID = 0;
            var data = con.CoursesCRUD(2, model);
            model.ILCoursesCRUD = data;
            ViewBag.count = model.ILCoursesCRUD.Count();
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCourse(string id, CoursesCRUD model, string btnval)
        {
            if (ModelState.IsValid)
            {
                model.UserId = Convert.ToInt32(SessionManager.UserIntId);
                if (btnval == "Add")
                {

                    var data = con.CoursesCRUD(1, model);
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
                    model.Course_ID = item;
                    var data = con.CoursesCRUD(3, model);
                    if (data[0].IsSuccess == true)
                    {
                        DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                    }
                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddCourse", new { id = string.Empty });
        }

        public ActionResult DeleteCourse(string id)
        {
            CoursesCRUD model = new CoursesCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.Course_ID = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.CoursesCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Corps Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddCourse", new { id = string.Empty });
        }
        #endregion



        #region Special Eqpt
        // GET: Corps
        [HttpGet]
        public ActionResult AddSpecialEqpt(string id)
        {
            ViewBag.ButtonName = "Add";
            SpecialEqptCRUD model = new SpecialEqptCRUD();
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.SpecialEqpt_ID = item;
                var editdata = con.SpecialEqptCRUD(2, model);
                model = editdata[0];
            }
            model.SpecialEqpt_ID = 0;
            var data = con.SpecialEqptCRUD(2, model);
            model.ILSpecialEqptCRUD = data;
            ViewBag.count = model.ILSpecialEqptCRUD.Count();
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddSpecialEqpt(string id, SpecialEqptCRUD model, string btnval)
        {
            if (ModelState.IsValid)
            {
                model.UserId = Convert.ToInt32(SessionManager.UserIntId);
                if (btnval == "Add")
                {

                    var data = con.SpecialEqptCRUD(1, model);
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
                    model.SpecialEqpt_ID = item;
                    var data = con.SpecialEqptCRUD(3, model);
                    if (data[0].IsSuccess == true)
                    {
                        DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                    }
                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddSpecialEqpt", new { id = string.Empty });
        }

        public ActionResult DeleteSpecialEqpt(string id)
        {
            SpecialEqptCRUD model = new SpecialEqptCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.SpecialEqpt_ID = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.SpecialEqptCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Corps Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddSpecialEqpt", new { id = string.Empty });
        }
        #endregion

        #region Special Qual
        // GET: Corps
        [HttpGet]
        public ActionResult AddSpecialQual(string id)
        {
            ViewBag.ButtonName = "Add";
            SpecialQualCRUD model = new SpecialQualCRUD();
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.SpecialQual_ID = item;
                var editdata = con.SpecialQualCRUD(2, model);
                model = editdata[0];
            }
            model.SpecialQual_ID = 0;
            var data = con.SpecialQualCRUD(2, model);
            model.ILSpecialQualCRUD = data;
            ViewBag.count = model.ILSpecialQualCRUD.Count();
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddSpecialQual(string id, SpecialQualCRUD model, string btnval)
        {
            if (ModelState.IsValid)
            {
                model.UserId = Convert.ToInt32(SessionManager.UserIntId);
                if (btnval == "Add")
                {

                    var data = con.SpecialQualCRUD(1, model);
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
                    model.SpecialQual_ID = item;
                    var data = con.SpecialQualCRUD(3, model);
                    if (data[0].IsSuccess == true)
                    {
                        DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                    }
                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddSpecialQual", new { id = string.Empty });
        }

        public ActionResult DeleteSpecialQual(string id)
        {
            SpecialQualCRUD model = new SpecialQualCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.SpecialQual_ID = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.SpecialQualCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Corps Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddSpecialQual", new { id = string.Empty });
        }
        #endregion

        #region HonourAward
        // GET: Corps
        [HttpGet]
        public ActionResult AddHonourAward(string id)
        {
            ViewBag.ButtonName = "Add";
            HonourAwardCRUD model = new HonourAwardCRUD();
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.HonourAward_ID = item;
                var editdata = con.HonourAwardCRUD(2, model);
                model = editdata[0];
            }
            model.HonourAward_ID = 0;
            var data = con.HonourAwardCRUD(2, model);
            model.ILHonourAwardCRUD = data;
            ViewBag.count = model.ILHonourAwardCRUD.Count();
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddHonourAward(string id, HonourAwardCRUD model, string btnval)
        {
            if (ModelState.IsValid)
            {
                model.UserId = Convert.ToInt32(SessionManager.UserIntId);
                if (btnval == "Add")
                {

                    var data = con.HonourAwardCRUD(1, model);
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
                    model.HonourAward_ID = item;
                    var data = con.HonourAwardCRUD(3, model);
                    if (data[0].IsSuccess == true)
                    {
                        DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                    }
                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddHonourAward", new { id = string.Empty });
        }

        public ActionResult DeleteHonourAward(string id)
        {
            HonourAwardCRUD model = new HonourAwardCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.HonourAward_ID = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.HonourAwardCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Corps Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddHonourAward", new { id = string.Empty });
        }
        #endregion


        #region Aircraft
        // GET: Corps
        [HttpGet]
        public ActionResult AddAircraft(string id)
        {
            ViewBag.ButtonName = "Add";
            AircraftCRUD model = new AircraftCRUD();
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.Aircraft_ID = item;
                var editdata = con.AircraftCRUD(2, model);
                model = editdata[0];
            }
            model.Aircraft_ID = 0;
            var data = con.AircraftCRUD(2, model);
            model.ILAircraftCRUD = data;
            ViewBag.count = model.ILAircraftCRUD.Count();
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddAircraft(string id, AircraftCRUD model, string btnval)
        {
            if (ModelState.IsValid)
            {
                model.UserId = Convert.ToInt32(SessionManager.UserIntId);
                if (btnval == "Add")
                {

                    var data = con.AircraftCRUD(1, model);
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
                    model.Aircraft_ID = item;
                    var data = con.AircraftCRUD(3, model);
                    if (data[0].IsSuccess == true)
                    {
                        DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                    }
                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddAircraft", new { id = string.Empty });
        }

        public ActionResult DeleteAircraft(string id)
        {
            AircraftCRUD model = new AircraftCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.Aircraft_ID = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.AircraftCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Corps Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddAircraft", new { id = string.Empty });
        }
        #endregion


        #region ArmService
        // GET: ArmService
        [HttpGet]
        public ActionResult AddArmService(string id)
        {
            ViewBag.ButtonName = "Add";
            ArmServiceCRUD model = new ArmServiceCRUD();
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.ArmService_ID = item;
                var editdata = con.ArmServiceCRUD(2, model);
                model = editdata[0];
            }
            model.ArmService_ID = 0;
            var data = con.ArmServiceCRUD(2, model);
            model.ILArmServiceCRUD = data;
            ViewBag.count = model.ILArmServiceCRUD.Count();
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddArmService(string id, ArmServiceCRUD model, string btnval)
        {
            if (ModelState.IsValid)
            {
                model.UserId = Convert.ToInt32(SessionManager.UserIntId);
                if (btnval == "Add")
                {

                    var data = con.ArmServiceCRUD(1, model);
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
                    model.ArmService_ID = item;
                    var data = con.ArmServiceCRUD(3, model);
                    if (data[0].IsSuccess == true)
                    {
                        DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                    }
                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddArmService", new { id = string.Empty });
        }

        public ActionResult DeleteArmService(string id)
        {
            ArmServiceCRUD model = new ArmServiceCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.ArmService_ID = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.ArmServiceCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Corps Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddArmService", new { id = string.Empty });
        }
        #endregion

        #region Accident Cat
        // GET: Accident Cat
        [HttpGet]
        public ActionResult AddAccidentCat(string id)
        {
            ViewBag.ButtonName = "Add";
            AccidentCatCRUD model = new AccidentCatCRUD();
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.AccidentCat_ID = item;
                var editdata = con.AccidentCatCRUD(2, model);
                model = editdata[0];
            }
            model.AccidentCat_ID = 0;
            var data = con.AccidentCatCRUD(2, model);
            model.ILAccidentCatCRUD = data;
            ViewBag.count = model.ILAccidentCatCRUD.Count();
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddAccidentCat(string id, AccidentCatCRUD model, string btnval)

        {
            if (ModelState.IsValid)
            {

                model.UserId = Convert.ToInt32(SessionManager.UserIntId);
                if (btnval == "Add")
                {

                    var data = con.AccidentCatCRUD(1, model);
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
                    model.AccidentCat_ID = item;
                    var data = con.AccidentCatCRUD(3, model);
                    if (data[0].IsSuccess == true)
                    {
                        DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                    }
                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddAccidentCat", new { id = string.Empty });
        }

        public ActionResult DeleteAccidentCat(string id)
        {
            AccidentCatCRUD model = new AccidentCatCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.AccidentCat_ID = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.AccidentCatCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Corps Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddAccidentCat", new { id = string.Empty });
        }
        #endregion

        #region FlgWithAppt
        // GET: Comd
        [HttpGet]
        public ActionResult AddFlgWithAppt(string id)
        {
            ViewBag.ButtonName = "Add";
            FlgWithApptCRUD model = new FlgWithApptCRUD();
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.FlgWithApptId = item;
                var editdata = con.FlgWithApptCRUD(2, model);
                model = editdata[0];
            }
            model.FlgWithApptId = 0;
            var data = con.FlgWithApptCRUD(2, model);
            model.ILFlgWithApptCRUD = data;
            ViewBag.count = model.ILFlgWithApptCRUD.Count();
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddFlgWithAppt(string id, FlgWithApptCRUD model, string btnval)
        {
            if (ModelState.IsValid)
            {
                model.UserId = Convert.ToInt32(SessionManager.UserIntId);
                if (btnval == "Add")
                {

                    var data = con.FlgWithApptCRUD(1, model);
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
                    model.FlgWithApptId = item;
                    var data = con.FlgWithApptCRUD(3, model);
                    if (data[0].IsSuccess == true)
                    {
                        DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                    }
                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddFlgWithAppt", new { id = string.Empty });
        }

        public ActionResult DeleteFlgWithAppt(string id)
        {
            FlgWithApptCRUD model = new FlgWithApptCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.FlgWithApptId = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.FlgWithApptCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Comd Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddFlgWithAppt", new { id = string.Empty });
        }
        #endregion


        #region CourseGrading
        // GET: Comd
        [HttpGet]
        public ActionResult AddCourseGrading(string id)
        {
            ViewBag.ButtonName = "Add";
            CourseGradingCRUD model = new CourseGradingCRUD();
            if (id != null && id != string.Empty)
            {
                ViewBag.ButtonName = "Update";
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
                model.CourseGradingId = item;
                var editdata = con.CourseGradingCRUD(2, model);
                model = editdata[0];
            }
            model.CourseGradingId = 0;
            var data = con.CourseGradingCRUD(2, model);
            model.ILCourseGradingCRUD = data;
            ViewBag.count = model.ILCourseGradingCRUD.Count();
            return View(model);
        }


        [HttpPost]
        public ActionResult AddCourseGrading(string id, CourseGradingCRUD model, string btnval)
        {
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            if (btnval == "Add")
            {

                var data = con.CourseGradingCRUD(1, model);
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
                model.CourseGradingId = item;
                var data = con.CourseGradingCRUD(3, model);
                if (data[0].IsSuccess == true)
                {
                    DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);

                }
            }
            ViewBag.ButtonName = "Add";

            return RedirectToAction("AddCourseGrading", new { id = string.Empty });
        }

        public ActionResult DeleteCourseGrading(string id)
        {
            CourseGradingCRUD model = new CourseGradingCRUD();
            int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(id));
            model.CourseGradingId = item;
            model.UserId = Convert.ToInt32(SessionManager.UserIntId);
            var data = con.CourseGradingCRUD(4, model);
            if (data[0].IsSuccess == true)
            {
                DisplayMessage(data[0].Msg, data[0].MidMsg, data[0].MsgStatus);
                //DisplayMessage("Comd Deleted Successfully", " ", "s");
            }
            return RedirectToAction("AddCourseGrading", new { id = string.Empty });
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
