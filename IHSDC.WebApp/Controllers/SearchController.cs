using System;
using System.Linq;
using System.Web.Mvc;
using IHSDC.WebApp.Models;
using IHSDC.WebApp.Connection;
using static IHSDC.WebApp.Filters.CustomFilters;

namespace IHSDC.WebApp.Controllers
{
    [SessionTimeoutAttribute]
    public class SearchController : Controller
    {
        readonly SearchDBConnection con = new SearchDBConnection();
        readonly DBConnection dbcon = new DBConnection();
        string sqlQuery = string.Empty;
        string Avid = string.Empty;
        [HttpGet]
        public ActionResult AviatorList()
        {
            AviatorCRUD model = new AviatorCRUD();
            model.Aviator_ID = 0;


            var data = dbcon.AviatorCRUD(7, model);
            if (data != null && data.Count != 0)
            {
                foreach (var d in data)
                {
                    Avid += d.Aviator_ID + ",";

                }
                SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
            }
            model.ILAviatorCRUD = data;

            ViewBag.count = model.ILAviatorCRUD.Count();
            return View(model);
        }
        [HttpPost]
        public ActionResult AviatorList(AviatorCRUD model)
        {
            sqlQuery = GetQueryForSearchModule("AviatorList", model.Col1, model.ColContains1, model.ColVal1, model.Col2, model.ColContains2, model.ColVal2, model.Col3, model.ColContains3, model.ColVal3, model.Col4, model.ColContains4, model.ColVal4).ToString();

            
            string str = GetWhereQuery(sqlQuery).ToString();
            if (str != String.Empty && str != null)
            {
                var result = con.AviatorSearch(1, str);
                if (result != null && result.Count != 0)
                {
                    foreach (var d in result)
                    {
                        Avid += d.Aviator_ID + ",";

                    }
                    SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
                }
                model.ILAviatorCRUD = result;
                ViewBag.count = model.ILAviatorCRUD.Count();
            }
            else
            {

                return RedirectToAction("AviatorList");
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult AviatorCourseList()
        {

            AviatorCoursesCRUD model = new AviatorCoursesCRUD();
            if (SessionManager.AviatorIds != null && SessionManager.AviatorIds != string.Empty)
            {
                var result = con.AviatorCourseList(1);
                model.ILAviatorCoursesCRUD = result;
            }
            else
            {
                var data = dbcon.AviatorCoursesCRUD(7, model);
                model.ILAviatorCoursesCRUD = data;
                if (data != null && data.Count != 0)
                {
                    foreach (var d in data)
                    {
                        Avid += d.Aviator_ID + ",";

                    }
                    SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
                }
            }
            ViewBag.count = model.ILAviatorCoursesCRUD.Count();
            return View(model);
        }
        [HttpPost]
        public ActionResult AviatorCourseList(AviatorCoursesCRUD model)
        {

            sqlQuery = GetQueryForSearchModule("AviatorCourseList", model.Col1, model.ColContains1, model.ColVal1, model.Col2, model.ColContains2, model.ColVal2, model.Col3, model.ColContains3, model.ColVal3, model.Col4, model.ColContains4, model.ColVal4).ToString();
            string str = GetWhereQuery(sqlQuery).ToString();
            if (str != String.Empty && str != null)
            {
                var result = con.AviatorCourseSearch(2, str);
                if (result != null && result.Count != 0)
                {
                    foreach (var d in result)
                    {
                        Avid += d.Aviator_ID + ",";

                    }
                    SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
                }

                model.ILAviatorCoursesCRUD = result;
                ViewBag.count = model.ILAviatorCoursesCRUD.Count();
            }
            else
            {

                return RedirectToAction("AviatorCourseList");
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult AviatorMedicalList()
        {

            AviatorMedicalCRUD model = new AviatorMedicalCRUD();
            model.AviatorMedical_ID = 0;

            if (SessionManager.AviatorIds != null && SessionManager.AviatorIds != string.Empty)
            {
                var result = con.AviatorMedicalList(2);
                model.ILAviatorMedicalCRUD = result;
            }
            else
            {
                var data = dbcon.AviatorMedicalCRUD(7, model);
                if (data != null && data.Count != 0)
                {
                    foreach (var d in data)
                    {
                        Avid += d.Aviator_ID + ",";

                    }
                    SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
                }
                model.ILAviatorMedicalCRUD = data;
            }

            ViewBag.count = model.ILAviatorMedicalCRUD.Count();
            return View(model);
        }
        [HttpPost]
        public ActionResult AviatorMedicalList(AviatorMedicalCRUD model)
        {
            sqlQuery = GetQueryForSearchModule("AviatorMedicalList", model.Col1, model.ColContains1, model.ColVal1, model.Col2, model.ColContains2, model.ColVal2, model.Col3, model.ColContains3, model.ColVal3, model.Col4, model.ColContains4, model.ColVal4).ToString();
            string str = GetWhereQuery(sqlQuery).ToString();
            if (str != String.Empty && str != null)
            {
                var result = con.AviatorMedicalSearch(3, str);
                if (result != null && result.Count != 0)
                {
                    foreach (var d in result)
                    {
                        Avid += d.Aviator_ID + ",";

                    }
                    SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
                }
                model.ILAviatorMedicalCRUD = result;
                ViewBag.count = model.ILAviatorMedicalCRUD.Count();
            }
            else
            {

                return RedirectToAction("AviatorMedicalList");
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult AviatorHonourAwardsList()
        {

            AviatorHonourAwardsCRUD model = new AviatorHonourAwardsCRUD();
            model.AviatorHonourAwards_ID = 0;

            if (SessionManager.AviatorIds != null && SessionManager.AviatorIds != string.Empty)
            {
                var result = con.AviatorHonourAwardsSearchList();
                model.ILAviatorHonourAwardsCRUD = result;
            }
            else
            {
                var data = dbcon.AviatorHonourAwardsCRUD(7, model);
                if (data != null && data.Count != 0)
                {
                    foreach (var d in data)
                    {
                        Avid += d.Aviator_ID + ",";

                    }
                    SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
                }
                model.ILAviatorHonourAwardsCRUD = data;
            }
            ViewBag.count = model.ILAviatorHonourAwardsCRUD.Count();
            return View(model);
        }
        [HttpPost]
        public ActionResult AviatorHonourAwardsList(AviatorHonourAwardsCRUD model)
        {
            sqlQuery = GetQueryForSearchModule("AviatorHonourList", model.Col1, model.ColContains1, model.ColVal1, model.Col2, model.ColContains2, model.ColVal2, model.Col3, model.ColContains3, model.ColVal3, model.Col4, model.ColContains4, model.ColVal4).ToString();
            string str = GetWhereQuery(sqlQuery).ToString();
            if (str != String.Empty && str != null)
            {

                var result = con.AviatorHonourAwardsSearch(str);
                if (result != null && result.Count != 0)
                {
                    foreach (var d in result)
                    {
                        Avid += d.Aviator_ID + ",";

                    }
                    SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
                }
                model.ILAviatorHonourAwardsCRUD = result;
                ViewBag.count = model.ILAviatorHonourAwardsCRUD.Count();
            }
            else
            {

                return RedirectToAction("AviatorHonourAwardsList");
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult AviatorSpecialEqptList()
        {
            AviatorSpecialEqptCRUD model = new AviatorSpecialEqptCRUD();
            model.AviatorSpecialEqpt_ID = 0;

            if (SessionManager.AviatorIds != null && SessionManager.AviatorIds != string.Empty)
            {
                var result = con.AviatorEQPTSearchList();
                model.ILAviatorSpecialEqptCRUD = result;
            }
            else
            {
                var data = dbcon.AviatorSpecialEqptCRUD(7, model);
                if (data != null && data.Count != 0)
                {
                    foreach (var d in data)
                    {
                        Avid += d.Aviator_ID + ",";

                    }
                    SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
                }
                model.ILAviatorSpecialEqptCRUD = data;
            }


            ViewBag.count = model.ILAviatorSpecialEqptCRUD.Count();
            return View(model);
        }
        [HttpPost]
        public ActionResult AviatorSpecialEqptList(AviatorSpecialEqptCRUD model)
        {

            sqlQuery = GetQueryForSearchModule("AviatorEQPTList", model.Col1, model.ColContains1, model.ColVal1, model.Col2, model.ColContains2, model.ColVal2, model.Col3, model.ColContains3, model.ColVal3, model.Col4, model.ColContains4, model.ColVal4).ToString();
            string str = GetWhereQuery(sqlQuery).ToString();
            if (str != String.Empty && str != null)
            {

                var result = con.AviatorEQPTSearch(str);
                if (result != null && result.Count != 0)
                {
                    foreach (var d in result)
                    {
                        Avid += d.Aviator_ID + ",";

                    }
                    SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
                }
                model.ILAviatorSpecialEqptCRUD = result;
                ViewBag.count = model.ILAviatorSpecialEqptCRUD.Count();
            }
            else {
                return RedirectToAction("AviatorSpecialEqptList");
            }
            return View(model);


        }
        [HttpGet]
        public ActionResult AviatorAccidentList()
        {
            AviatorAccidentCRUD model = new AviatorAccidentCRUD();
            model.AviatorAccidentIncident_ID = 0;

            if (SessionManager.AviatorIds != null && SessionManager.AviatorIds != string.Empty)
            {
                var result = con.AviatorAccidentSearchList();
                model.ILAviatorAccidentCRUD = result;
            }
            else
            {
                var data = dbcon.AviatorAccidentCRUD(7, model);
                if (data != null && data.Count != 0)
                {
                    foreach (var d in data)
                    {
                        Avid += d.Aviator_ID + ",";

                    }
                    SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
                }
                model.ILAviatorAccidentCRUD = data;
            }


            ViewBag.count = model.ILAviatorAccidentCRUD.Count();
            return View(model);

        }
        [HttpPost]
        public ActionResult AviatorAccidentList(AviatorAccidentCRUD model)
        {

            sqlQuery = GetQueryForSearchModule("AviatorAccidentList", model.Col1, model.ColContains1, model.ColVal1, model.Col2, model.ColContains2, model.ColVal2, model.Col3, model.ColContains3, model.ColVal3, model.Col4, model.ColContains4, model.ColVal4).ToString();
            string str = GetWhereQuery(sqlQuery).ToString();
            if (str != String.Empty && str != null)
            {

                var result = con.AviatorAccidentSearch(str);
                if (result != null && result.Count != 0)
                {
                    foreach (var d in result)
                    {
                        Avid += d.Aviator_ID + ",";

                    }
                    SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
                }
                model.ILAviatorAccidentCRUD = result;
                ViewBag.count = model.ILAviatorAccidentCRUD.Count();
            }
            else
            {
                return RedirectToAction("AviatorAccidentList");
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult AviatorQualificationList()
        {
            AviatorSpecialQualCRUD model = new AviatorSpecialQualCRUD();
            model.AviatorSpecialQual_ID = 0;

            if (SessionManager.AviatorIds != null && SessionManager.AviatorIds != string.Empty)
            {
                var result = con.AviatorQUALList();
                model.ILAviatorSpecialQualCRUD = result;
            }
            else
            {
                var data = dbcon.AviatorSpecialQualification(7, model);
                if (data != null && data.Count != 0)
                {
                    foreach (var d in data)
                    {
                        Avid += d.Aviator_ID + ",";

                    }
                    SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
                }
                model.ILAviatorSpecialQualCRUD = data;
            }


            ViewBag.count = model.ILAviatorSpecialQualCRUD.Count();
            return View(model);


        }
        [HttpPost]
        public ActionResult AviatorQualificationList(AviatorSpecialQualCRUD model)
        {
            sqlQuery = GetQueryForSearchModule("AviatorQUALList", model.Col1, model.ColContains1, model.ColVal1, model.Col2, model.ColContains2, model.ColVal2, model.Col3, model.ColContains3, model.ColVal3, model.Col4, model.ColContains4, model.ColVal4).ToString();
            string str = GetWhereQuery(sqlQuery).ToString();
            if (str != String.Empty && str != null)
            {
                var result = con.AviatorQUALSearch(str);
                if (result != null && result.Count != 0)
                {
                    foreach (var d in result)
                    {
                        Avid += d.Aviator_ID + ",";

                    }
                    SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
                }
                model.ILAviatorSpecialQualCRUD = result;
                ViewBag.count = model.ILAviatorSpecialQualCRUD.Count();
            }
            else
            {
                return RedirectToAction("AviatorQualificationList");
            }
            return View(model);

        }
        [HttpGet]
        public ActionResult AviatorRankList()
        {
            AviatorRankCRUD model = new AviatorRankCRUD();
            model.AviatorRank_ID = 0;

            if (SessionManager.AviatorIds != null && SessionManager.AviatorIds != string.Empty)
            {
                var result = con.AviatorRankSearchList();
                model.ILAviatorRankCRUD = result;
            }
            else
            {
                var data = dbcon.AviatorRankCRUD(2, model);
                if (data != null && data.Count != 0)
                {
                    foreach (var d in data)
                    {
                        Avid += d.Aviator_ID + ",";

                    }
                    SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
                }
                model.ILAviatorRankCRUD = data;
            }
            ViewBag.count = model.ILAviatorRankCRUD.Count();
            return View(model);

        }
        [HttpPost]
        public ActionResult AviatorRankList(AviatorRankCRUD model)
        {
            sqlQuery = GetQueryForSearchModule("AviatorRankList", model.Col1, model.ColContains1, model.ColVal1, model.Col2, model.ColContains2, model.ColVal2, model.Col3, model.ColContains3, model.ColVal3, model.Col4, model.ColContains4, model.ColVal4).ToString();
            string str = GetWhereQuery(sqlQuery).ToString();

            if (str != String.Empty && str != null)
            {
                var result = con.AviatorRankSearch(str);
            if (result != null && result.Count != 0)
            {
                foreach (var d in result)
                {
                    Avid += d.Aviator_ID + ",";

                }
                SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
            }
            model.ILAviatorRankCRUD = result;
            ViewBag.count = model.ILAviatorRankCRUD.Count();
            
                }
            else
            {
                return RedirectToAction("AviatorRankList");
    }
            return View(model);
        }
        [HttpGet]
        public ActionResult AviatorApptList()
        {
            AviatorApptCRUD model = new AviatorApptCRUD();
            model.AviatorAppointment_ID = 0;

            if (SessionManager.AviatorIds != null && SessionManager.AviatorIds != string.Empty)
            {
                var result = con.AviatorAPPSearchList();
                model.ILAviatorApptCRUD = result;
            }
            else
            {
                var data = dbcon.AviatorApptCRUD(2, model);
                if (data != null && data.Count != 0)
                {
                    foreach (var d in data)
                    {
                        Avid += d.Aviator_ID + ",";

                    }
                    SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
                }
                model.ILAviatorApptCRUD = data;
            }


            ViewBag.count = model.ILAviatorApptCRUD.Count();
            return View(model);
        }
        [HttpPost]
        public ActionResult AviatorApptList(AviatorApptCRUD model)
        {

            sqlQuery = GetQueryForSearchModule("AviatorAPPList", model.Col1, model.ColContains1, model.ColVal1, model.Col2, model.ColContains2, model.ColVal2, model.Col3, model.ColContains3, model.ColVal3, model.Col4, model.ColContains4, model.ColVal4).ToString();
            string str = GetWhereQuery(sqlQuery).ToString();

            if (str != String.Empty && str != null)
            {
                var result = con.AviatorAPPSearch(str);
                if (result != null && result.Count != 0)
                {
                    foreach (var d in result)
                    {
                        Avid += d.Aviator_ID + ",";

                    }
                    SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
                }
                model.ILAviatorApptCRUD = result;
                ViewBag.count = model.ILAviatorApptCRUD.Count();
            }
            else
            {
                return RedirectToAction("AviatorApptList");
            }
            return View(model);

        }
        [HttpGet]
        public ActionResult AviatorContactDetailsList()
        {
            AviatorContactDetailsCRUD model = new AviatorContactDetailsCRUD();
            model.AviatorDetailID = 0;

            if (SessionManager.AviatorIds != null && SessionManager.AviatorIds != string.Empty)
            {
                var result = con.AviatorContactDetailsSearchList();
                model.ILAviatorContactDetailsCRUD = result;
            }
            else
            {
                var data = dbcon.AviatorContactDetailsCRUD(7, model);
                if (data != null && data.Count != 0)
                {
                    foreach (var d in data)
                    {
                        Avid += d.Aviator_ID + ",";

                    }
                    SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
                }
                model.ILAviatorContactDetailsCRUD = data;
            }


            ViewBag.count = model.ILAviatorContactDetailsCRUD.Count();

            return View(model);
        }
        [HttpPost]
        public ActionResult AviatorContactDetailsList(AviatorContactDetailsCRUD model)
        {


            sqlQuery = GetQueryForSearchModule("AviatorContactDetails", model.Col1, model.ColContains1, model.ColVal1, model.Col2, model.ColContains2, model.ColVal2, model.Col3, model.ColContains3, model.ColVal3, model.Col4, model.ColContains4, model.ColVal4).ToString();
            string str = GetWhereQuery(sqlQuery).ToString();
            if (str != String.Empty && str != null)
            {
                var result = con.AviatorContactDetailsSearch(str);
                if (result != null && result.Count != 0)
                {
                    foreach (var d in result)
                    {
                        Avid += d.Aviator_ID + ",";

                    }
                    SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
                }
                model.ILAviatorContactDetailsCRUD = result;
                ViewBag.count = model.ILAviatorContactDetailsCRUD.Count();
            }
            else
            {
                return RedirectToAction("AviatorContactDetailsList");
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult AviatorFlyingHrsList()
        {
            AviatorFlyingHrsCRUD model = new AviatorFlyingHrsCRUD();
            model.AviatorFlyingHrs_ID = 0;
            if (SessionManager.AviatorIds != null && SessionManager.AviatorIds != string.Empty)
            {
                var result = con.AviatorFlyingSearchList();
                model.ILAviatorFlyingHrsCRUD = result;
            }
            else
            {
                var data = dbcon.AviatorFlyingHrsCRUD(7, model);
                if (data != null && data.Count != 0)
                {
                    foreach (var d in data)
                    {
                        Avid += d.Aviator_ID + ",";

                    }
                    SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
                }
                model.ILAviatorFlyingHrsCRUD = data;
            }
            ViewBag.count = model.ILAviatorFlyingHrsCRUD.Count();
            return View(model);
        }
        [HttpPost]
        public ActionResult AviatorFlyingHrsList(AviatorFlyingHrsCRUD model)
        {
            sqlQuery = GetQueryForSearchModule("AviatorFlyingHrs", model.Col1, model.ColContains1, model.ColVal1, model.Col2, model.ColContains2, model.ColVal2, model.Col3, model.ColContains3, model.ColVal3, model.Col4, model.ColContains4, model.ColVal4).ToString();            
            string str = GetWhereQuery(sqlQuery).ToString();
            if (str != String.Empty && str != null)
            {
                var result = con.AviatorFlyingSearch(str);
                if (result != null && result.Count != 0)
                {
                    foreach (var d in result)
                    {
                        Avid += d.Aviator_ID + ",";

                    }
                    SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
                }
                model.ILAviatorFlyingHrsCRUD = result;
                ViewBag.count = model.ILAviatorFlyingHrsCRUD.Count();
            }
            else
            {
                return RedirectToAction("AviatorFlyingHrsList");
            }
            return View(model);



          
        }


        [HttpGet]
        public ActionResult AviatorPostingList()
        {
            PostingAviator model = new PostingAviator();
            model.AviatorPosting_ID = 0;
            if (SessionManager.AviatorIds != null && SessionManager.AviatorIds != string.Empty)
            {
                var result = con.AviatorPostingSearchList();
                model.ILPostingAviator = result;
            }
            else
            {
                var data = dbcon.PostingAviatorCRUD(7, model);
                if (data != null && data.Count != 0)
                {
                    foreach (var d in data)
                    {
                        Avid += d.Aviator_ID + ",";

                    }
                    SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
                }
                model.ILPostingAviator = data;
            }
            ViewBag.count = model.ILPostingAviator.Count();
            return View(model);
        }


        [HttpPost]
        public ActionResult AviatorPostingList(PostingAviator model)
        {
            sqlQuery = GetQueryForSearchModule("PostingAviator", model.Col1, model.ColContains1, model.ColVal1, model.Col2, model.ColContains2, model.ColVal2, model.Col3, model.ColContains3, model.ColVal3, model.Col4, model.ColContains4, model.ColVal4).ToString();
            string str = GetWhereQuery(sqlQuery).ToString();
            if (str != String.Empty && str != null)
            {
                var result = con.AviatorPostingSearch(str);
                if (result != null && result.Count != 0)
                {
                    foreach (var d in result)
                    {
                        Avid += d.Aviator_ID + ",";

                    }
                    SessionManager.AviatorIds = Avid.TrimEnd(',').ToString();
                }
                model.ILPostingAviator = result;
                ViewBag.count = model.ILPostingAviator.Count();
            }
            else
            {
                return RedirectToAction("AviatorPostingList");
            }
            return View(model);
        }



        #region For Get Dynamic Query  For Condition Every Page
        public string GetQueryForSearchModule(string Query, string col1, string colContains1, string colVal1, string col2, string colContains2, string colVal2, string col3, string colContains3, string colVal3, string col4, string colContains4, string colVal4)
        {
            if (Query == "AviatorList")
            {
                if (colVal1 != string.Empty && colVal1 != null)
                {


                    if (colContains1 == "Contains")
                    {
                        sqlQuery += col1 + " Like ''%" + colVal1 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col1 == "DateOfBirth" || col1 == "DateOfSeniority" || col1 == "DateOfWings" || col1 == "DateOfRank" && colContains1 != "Contains")
                        {
                            sqlQuery += col1 + colContains1 + "CAST(" + "''" + colVal1 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col1 + colContains1 + "''" + colVal1 + "''" + " AND ";
                        }

                    }

                }
                if (colVal2 != string.Empty && colVal2 != null)
                {
                    if (colContains2 == "Contains")
                    {
                        sqlQuery += col2 + " Like ''%" + colVal2 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col2 == "DateOfBirth" || col2 == "DateOfSeniority" || col2 == "DateOfWings" || col2 == "DateOfRank" && colContains2 != "Contains")
                        {
                            sqlQuery += col2 + colContains2 + "CAST(" + "''" + colVal2 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col2 + colContains2 + "''" + colVal2 + "''" + " AND ";
                        }

                    }



                }
                if (colVal3 != string.Empty && colVal3 != null)
                {
                    if (colContains3 == "Contains")
                    {
                        sqlQuery += col3 + " Like ''%" + colVal3 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col3 == "DateOfBirth" || col3 == "DateOfSeniority" || col3 == "DateOfWings" || col3 == "DateOfRank" && colContains3 != "Contains")
                        {
                            sqlQuery += col3 + colContains3 + "CAST(" + "''" + colVal3 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col3 + colContains3 + "''" + colVal3 + "''" + " AND ";
                        }

                    }

                }
                if (colVal4 != string.Empty && colVal4 != null)
                {
                    if (colContains4 == "Contains")
                    {
                        sqlQuery += col4 + " Like ''%" + colVal4 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col4 == "DateOfBirth" || col4 == "DateOfSeniority" || col4 == "DateOfWings" || col4 == "DateOfRank" && colContains4 != "Contains")
                        {
                            sqlQuery += col4 + colContains4 + "CAST(" + "''" + colVal4 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col4 + colContains4 + "''" + colVal4 + "''" + " AND ";
                        }

                    }


                }
            }
            if (Query == "AviatorCourseList")
            {
                if (colVal1 != string.Empty && colVal1 != null)
                {
                    if (colContains1 == "Contains")
                    {
                        sqlQuery += col1 + " Like ''%" + colVal1 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col1 == "CourseStartDate" || col1 == "CourseEndDate" && colContains1 != "Contains")
                        {
                            sqlQuery += col1 + colContains1 + "CAST(" + "''" + colVal1 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col1 + colContains1 + "''" + colVal1 + "''" + " AND ";
                        }

                    }

                }
                if (colVal2 != string.Empty && colVal2 != null)
                {
                    if (colContains2 == "Contains")
                    {
                        sqlQuery += col2 + " Like ''%" + colVal2 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col2 == "CourseStartDate" || col2 == "CourseEndDate" && colContains2 != "Contains")
                        {
                            sqlQuery += col2 + colContains2 + "CAST(" + "''" + colVal2 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col2 + colContains2 + "''" + colVal2 + "''" + " AND ";
                        }

                    }
                }
                if (colVal3 != string.Empty && colVal3 != null)
                {
                    if (colContains3 == "Contains")
                    {
                        sqlQuery += col3 + " Like ''%" + colVal3 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col3 == "CourseStartDate" || col3 == "CourseEndDate" && colContains3 != "Contains")
                        {
                            sqlQuery += col3 + colContains3 + "CAST(" + "''" + colVal3 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col3 + colContains3 + "''" + colVal3 + "''" + " AND ";
                        }

                    }

                }
                if (colVal4 != string.Empty && colVal4 != null)
                {
                    if (colContains4 == "Contains")
                    {
                        sqlQuery += col4 + " Like ''%" + colVal4 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col4 == "CourseStartDate" || col4 == "CourseEndDate" && colContains4 != "Contains")
                        {
                            sqlQuery += col4 + colContains4 + "CAST(" + "''" + colVal4 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col4 + colContains4 + "''" + colVal4 + "''" + " AND ";
                        }

                    }


                }
            }
            if (Query == "AviatorMedicalList")
            {
                if (colVal1 != string.Empty && colVal1 != null)
                {
                    if (colContains1 == "Contains")
                    {
                        sqlQuery += col1 + " Like ''%" + colVal1 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col1 == "MedicalStartDate" || col1 == "MedicalEndDate" || col1 == "MedicalCatDate" || col1 == "ReCatDueDate" && colContains1 != "Contains")
                        {
                            sqlQuery += col1 + colContains1 + "CAST(" + "''" + colVal1 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col1 + colContains1 + "''" + colVal1 + "''" + " AND ";
                        }

                    }
                }
                if (colVal2 != string.Empty && colVal2 != null)
                {
                    if (colContains2 == "Contains")
                    {
                        sqlQuery += col2 + " Like ''%" + colVal2 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col2 == "MedicalStartDate" || col2 == "MedicalEndDate" || col2 == "MedicalCatDate" || col2 == "ReCatDueDate" && colContains2 != "Contains")
                        {
                            sqlQuery += col2 + colContains2 + "CAST(" + "''" + colVal2 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col2 + colContains2 + "''" + colVal2 + "''" + " AND ";
                        }

                    }
                }
                if (colVal3 != string.Empty && colVal3 != null)
                {
                    if (colContains3 == "Contains")
                    {
                        sqlQuery += col3 + " Like ''%" + colVal3 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col3 == "MedicalStartDate" || col3 == "MedicalEndDate" || col3 == "MedicalCatDate" || col3 == "ReCatDueDate" && colContains3 != "Contains")
                        {
                            sqlQuery += col3 + colContains3 + "CAST(" + "''" + colVal3 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col3 + colContains3 + "''" + colVal3 + "''" + " AND ";
                        }

                    }

                }
                if (colVal4 != string.Empty && colVal4 != null)
                {
                    if (colContains4 == "Contains")
                    {
                        sqlQuery += col4 + " Like ''%" + colVal4 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col4 == "MedicalStartDate" || col4 == "MedicalEndDate" || col4 == "MedicalCatDate" || col4 == "ReCatDueDate" && colContains4 != "Contains")
                        {
                            sqlQuery += col4 + colContains4 + "CAST(" + "''" + colVal4 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col4 + colContains4 + "''" + colVal4 + "''" + " AND ";
                        }

                    }


                }
            }
            if (Query == "AviatorHonourList")
            {
                if (colVal1 != string.Empty && colVal1 != null)
                {
                    if (colContains1 == "Contains")
                    {
                        sqlQuery += col1 + " Like ''%" + colVal1 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col1 == "HonourAwardsDate" && colContains1 != "Contains")
                        {
                            sqlQuery += col1 + colContains1 + "CAST(" + "''" + colVal1 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col1 + colContains1 + "''" + colVal1 + "''" + " AND ";
                        }

                    }
                }
                if (colVal2 != string.Empty && colVal2 != null)
                {
                    if (colContains2 == "Contains")
                    {
                        sqlQuery += col2 + " Like ''%" + colVal2 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col2 == "HonourAwardsDate" && colContains2 != "Contains")
                        {
                            sqlQuery += col2 + colContains2 + "CAST(" + "''" + colVal2 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col2 + colContains2 + "''" + colVal2 + "''" + " AND ";
                        }

                    }
                }
                if (colVal3 != string.Empty && colVal3 != null)
                {
                    if (colContains3 == "Contains")
                    {
                        sqlQuery += col3 + " Like ''%" + colVal3 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col3 == "HonourAwardsDate" && colContains3 != "Contains")
                        {
                            sqlQuery += col3 + colContains3 + "CAST(" + "''" + colVal3 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col3 + colContains3 + "''" + colVal3 + "''" + " AND ";
                        }

                    }

                }

            }
            if (Query == "AviatorEQPTList")
            {
                if (colVal1 != string.Empty && colVal1 != null)
                {
                    if (colContains1 == "Contains")
                    {
                        sqlQuery += col1 + " Like ''%" + colVal1 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col1 == "SpecialEqptDate" && colContains1 != "Contains")
                        {
                            sqlQuery += col1 + colContains1 + "CAST(" + "''" + colVal1 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col1 + colContains1 + "''" + colVal1 + "''" + " AND ";
                        }

                    }
                }
                if (colVal2 != string.Empty && colVal2 != null)
                {
                    if (colContains2 == "Contains")
                    {
                        sqlQuery += col2 + " Like ''%" + colVal2 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col2 == "SpecialEqptDate" && colContains2 != "Contains")
                        {
                            sqlQuery += col2 + colContains2 + "CAST(" + "''" + colVal2 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col2 + colContains2 + "''" + colVal2 + "''" + " AND ";
                        }

                    }
                }


            }
            if (Query == "AviatorAccidentList")
            {
                if (colVal1 != string.Empty && colVal1 != null)
                {
                    if (colContains1 == "Contains")
                    {
                        sqlQuery += col1 + " Like ''%" + colVal1 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col1 == "DateOfAccidentIncident" && colContains1 != "Contains")
                        {
                            sqlQuery += col1 + colContains1 + "CAST(" + "''" + colVal1 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col1 + colContains1 + "''" + colVal1 + "''" + " AND ";
                        }

                    }

                }
                if (colVal2 != string.Empty && colVal2 != null)
                {
                    if (colContains2 == "Contains")
                    {
                        sqlQuery += col2 + " Like ''%" + colVal2 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col2 == "DateOfAccidentIncident" && colContains2 != "Contains")
                        {
                            sqlQuery += col2 + colContains2 + "CAST(" + "''" + colVal2 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col2 + colContains2 + "''" + colVal2 + "''" + " AND ";
                        }

                    }
                }
                if (colVal3 != string.Empty && colVal3 != null)
                {
                    if (colContains3 == "Contains")
                    {
                        sqlQuery += col3 + " Like ''%" + colVal3 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col3 == "DateOfAccidentIncident" && colContains3 != "Contains")
                        {
                            sqlQuery += col3 + colContains3 + "CAST(" + "''" + colVal3 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col3 + colContains3 + "''" + colVal3 + "''" + " AND ";
                        }

                    }

                }
                if (colVal4 != string.Empty && colVal4 != null)
                {
                    if (colContains4 == "Contains")
                    {
                        sqlQuery += col4 + " Like ''%" + colVal4 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col4 == "DateOfAccidentIncident" && colContains4 != "Contains")
                        {
                            sqlQuery += col4 + colContains4 + "CAST(" + "''" + colVal4 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col4 + colContains4 + "''" + colVal4 + "''" + " AND ";
                        }

                    }


                }
            }
            if (Query == "AviatorQUALList")
            {
                if (colVal1 != string.Empty && colVal1 != null)
                {
                    if (colContains1 == "Contains")
                    {
                        sqlQuery += col1 + " Like ''%" + colVal1 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col1 == "SpecialQualDate" && colContains1 != "Contains")
                        {
                            sqlQuery += col1 + colContains1 + "CAST(" + "''" + colVal1 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col1 + colContains1 + "''" + colVal1 + "''" + " AND ";
                        }

                    }
                }
                if (colVal2 != string.Empty && colVal2 != null)
                {
                    if (colContains2 == "Contains")
                    {
                        sqlQuery += col2 + " Like ''%" + colVal2 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col2 == "SpecialQualDate" && colContains2 != "Contains")
                        {
                            sqlQuery += col2 + colContains2 + "CAST(" + "''" + colVal2 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col2 + colContains2 + "''" + colVal2 + "''" + " AND ";
                        }

                    }
                }


            }
            if (Query == "AviatorRankList")
            {
                if (colVal1 != string.Empty && colVal1 != null)
                {
                    if (colContains1 == "Contains")
                    {
                        sqlQuery += col1 + " Like ''%" + colVal1 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col1 == "RankDate" && colContains1 != "Contains")
                        {
                            sqlQuery += col1 + colContains1 + "CAST(" + "''" + colVal1 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col1 + colContains1 + "''" + colVal1 + "''" + " AND ";
                        }

                    }
                }
                if (colVal2 != string.Empty && colVal2 != null)
                {
                    if (colContains2 == "Contains")
                    {
                        sqlQuery += col2 + " Like ''%" + colVal2 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col2 == "RankDate" && colContains2 != "Contains")
                        {
                            sqlQuery += col2 + colContains2 + "CAST(" + "''" + colVal2 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col2 + colContains2 + "''" + colVal2 + "''" + " AND ";
                        }

                    }
                }


            }
            if (Query == "AviatorAPPList")
            {
                if (colVal1 != string.Empty && colVal1 != null)
                {
                    if (colContains1 == "Contains")
                    {
                        sqlQuery += col1 + " Like ''%" + colVal1 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col1 == "ApptDate" && colContains1 != "Contains")
                        {
                            sqlQuery += col1 + colContains1 + "CAST(" + "''" + colVal1 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col1 + colContains1 + "''" + colVal1 + "''" + " AND ";
                        }

                    }
                }
                if (colVal2 != string.Empty && colVal2 != null)
                {
                    if (colContains2 == "Contains")
                    {
                        sqlQuery += col2 + " Like ''%" + colVal2 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col2 == "ApptDate" && colContains2 != "Contains")
                        {
                            sqlQuery += col2 + colContains2 + "CAST(" + "''" + colVal2 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col2 + colContains2 + "''" + colVal2 + "''" + " AND ";
                        }

                    }
                }


            }
            if (Query == "AviatorContactDetails")
            {
                if (colVal1 != string.Empty && colVal1 != null)
                {


                    if (colContains1 == "Contains")
                    {
                        sqlQuery += col1 + " Like ''%" + colVal1 + "%''" + " AND  ";
                    }
                    else
                    {
                        sqlQuery += col1 + colContains1 + "''" + colVal1 + "''" + " AND ";
                    }

                }
                if (colVal2 != string.Empty && colVal2 != null)
                {
                    if (colContains2 == "Contains")
                    {
                        sqlQuery += col2 + " Like ''%" + colVal2 + "%''" + " AND  ";
                    }
                    else
                    {

                        sqlQuery += col2 + colContains2 + "''" + colVal2 + "''" + " AND ";


                    }



                }
                if (colVal3 != string.Empty && colVal3 != null)
                {
                    if (colContains3 == "Contains")
                    {
                        sqlQuery += col3 + " Like ''%" + colVal3 + "%''" + " AND  ";
                    }
                    else
                    {
                        sqlQuery += col3 + colContains3 + "''" + colVal3 + "''" + " AND ";

                    }

                }
                if (colVal4 != string.Empty && colVal4 != null)
                {
                    if (colContains4 == "Contains")
                    {
                        sqlQuery += col4 + " Like ''%" + colVal4 + "%''" + " AND  ";
                    }
                    else
                    {
                        sqlQuery += col4 + colContains4 + "''" + colVal4 + "''" + " AND ";
                    }


                }


            }            
            if (Query == "AviatorFlyingHrs")
            {
                if (colVal1 != string.Empty && colVal1 != null)
                {
                    if (col1 == "[Month]" || col1 == "[Year]")
                    {
                        if (col1 == "[Month]" && colContains1 == "Contains")
                        {
                            sqlQuery += "SUBSTRING([f]." + col1 + ", 0, 4)" + "Like ''%" + colVal1 + "%''" + "  AND ";

                        }
                        if (col1 == "[Month]" && colContains1 != "Contains")
                        {
                            sqlQuery += "SUBSTRING([f]." + col1 + ", 0, 4)" + colContains1 + "''" + colVal1 + "''" + "  AND ";

                        }
                        if (col1 == "[Year]" && colContains1 == "Contains")
                        {
                            sqlQuery += "SUBSTRING([f].[Month],4, 9)" + "Like ''%" + colVal1 + "%''" + "  AND ";

                        }
                        if (col1 == "[Year]" && colContains1 != "Contains")
                        {
                            sqlQuery += "SUBSTRING([f].[Month],4,9)" + colContains1 + "'' " + colVal1 + "''" + " AND ";

                        }
                    }
                    else {
                        if (col1 == "AircraftName" && colContains1 == "Contains")
                        {
                            sqlQuery += col1 + " Like ''%" + colVal1 + "%''" + " AND  ";
                        }
                        if (col1 == "AircraftName" && colContains1 != "Contains")
                        {
                            sqlQuery += col1 + colContains1 + "''" + colVal1 + "''" + " AND ";                        }

                        if (col1 == "DayDualHrs" || col1 == "DaySoloHrs" || col1 == "DayCopilotHrs" || col1 == "NightDualHrs" || col1 == "NightSoloHrs" || col1 == "NightCopilotHrs" || col1 == "NVGExp" || col1 == "WSOExp" || col1 == "IF_Actual" || col1 == "InstrDayHrs" || col1== "IMCHrs" || col1 == "SIFHrs" || col1 == "ALHSmlHrs" ||col1== "ALHSmlHrs"  && colContains1!= "Contains")
                        {
                            sqlQuery += "ISNULL(" + col1 + ", 0)" + colContains1 + "  " + colVal1 + " AND ";
                        }
                    }
                   
                }


                if (colVal2 != string.Empty && colVal2 != null)
                {
                    if (col2 == "[Month]" || col2 == "[Year]")
                    {
                        if (col2 == "[Month]" && colContains2 == "Contains")
                        {
                            sqlQuery += "SUBSTRING([f]." + col2 + ", 0, 4)" + "Like ''%" + colVal2 + "%''" + "  AND ";

                        }
                        if (col2 == "[Month]" && colContains2 != "Contains")
                        {
                            sqlQuery += "SUBSTRING([f]." + col2 + ", 0, 4)" + colContains2 + "''" + colVal2 + "''" + "  AND ";

                        }
                        if (col2 == "[Year]" && colContains2 == "Contains")
                        {
                            sqlQuery += "SUBSTRING([f].[Month],4, 9)" + "Like ''%" + colVal2 + "%''" + "  AND ";

                        }
                        if (col2 == "[Year]" && colContains2 != "Contains")
                        {
                            sqlQuery += "SUBSTRING([f].[Month],4,9)" + colContains2 + "'' " + colVal2 + "''" + " AND ";

                        }
                    }
                    else
                    {
                        if (col2 == "AircraftName" && colContains2 == "Contains")
                        {
                            sqlQuery += col2 + " Like ''%" + colVal2 + "%''" + " AND  ";
                        }
                        if (col2 == "AircraftName" && colContains2 != "Contains")
                        {
                            sqlQuery += col2 + colContains2 + "''" + colVal2 + "''" + " AND ";
                        }

                        if (col2 == "DayDualHrs" || col2 == "DaySoloHrs" || col2 == "DayCopilotHrs" || col2 == "NightDualHrs" || col2 == "NightSoloHrs" || col2 == "NightCopilotHrs" || col2 == "NVGExp" || col2 == "WSOExp" || col2 == "IF_Actual" || col2 == "InstrDayHrs" || col2 == "IMCHrs" || col2 == "SIFHrs" || col2 == "ALHSmlHrs" || col2 == "ALHSmlHrs" && colContains2 != "Contains")
                        {
                            sqlQuery += "ISNULL(" + col2 + ", 0)" + colContains2 + "  " + colVal2 + " AND ";
                        }
                    }

                }

                if (colVal3 != string.Empty && colVal3 != null)
                {
                    if (col3 == "[Month]" || col3 == "[Year]")
                    {
                        if (col3 == "[Month]" && colContains3 == "Contains")
                        {
                            sqlQuery += "SUBSTRING([f]." + col3 + ", 0, 4)" + "Like ''%" + colVal3 + "%''" + "  AND ";

                        }
                        if (col3 == "[Month]" && colContains3 != "Contains")
                        {
                            sqlQuery += "SUBSTRING([f]." + col3 + ", 0, 4)" + colContains3 + "''" + colVal3 + "''" + "  AND ";

                        }
                        if (col3 == "[Year]" && colContains3 == "Contains")
                        {
                            sqlQuery += "SUBSTRING([f].[Month],4, 9)" + "Like ''%" + colVal3 + "%''" + "  AND ";

                        }
                        if (col3 == "[Year]" && colContains3 != "Contains")
                        {
                            sqlQuery += "SUBSTRING([f].[Month],4,9)" + colContains3 + "'' " + colVal3 + "''" + " AND ";

                        }
                    }
                    else
                    {
                        if (col3 == "AircraftName" && colContains3 == "Contains")
                        {
                            sqlQuery += col3 + " Like ''%" + colVal3 + "%''" + " AND  ";
                        }
                        if (col3 == "AircraftName" && colContains3 != "Contains")
                        {
                            sqlQuery += col3 + colContains3 + "''" + colVal3 + "''" + " AND ";
                        }

                        if (col3 == "DayDualHrs" || col3 == "DaySoloHrs" || col3 == "DayCopilotHrs" || col3 == "NightDualHrs" || col3 == "NightSoloHrs" || col3 == "NightCopilotHrs" || col3 == "NVGExp" || col3 == "WSOExp" || col3 == "IF_Actual" || col3 == "InstrDayHrs" || col3 == "IMCHrs" || col3 == "SIFHrs" || col3 == "ALHSmlHrs" || col3 == "ALHSmlHrs" && colContains3 != "Contains")
                        {
                            sqlQuery += "ISNULL(" + col3 + ", 0)" + colContains3 + "  " + colVal3 + " AND ";
                        }
                    }

                }

                if (colVal4 != string.Empty && colVal4 != null)
                {
                    if (col4 == "[Month]" || col4 == "[Year]")
                    {
                        if (col4 == "[Month]" && colContains4 == "Contains")
                        {
                            sqlQuery += "SUBSTRING([f]." + col4 + ", 0, 4)" + "Like ''%" + colVal4 + "%''" + "  AND ";

                        }
                        if (col4 == "[Month]" && colContains1 != "Contains")
                        {
                            sqlQuery += "SUBSTRING([f]." + col4 + ", 0, 4)" + colContains4 + "''" + colVal4 + "''" + "  AND ";

                        }
                        if (col4 == "[Year]" && colContains4 == "Contains")
                        {
                            sqlQuery += "SUBSTRING([f].[Month],4, 9)" + "Like ''%" + colVal4 + "%''" + "  AND ";

                        }
                        if (col4 == "[Year]" && colContains4 != "Contains")
                        {
                            sqlQuery += "SUBSTRING([f].[Month],4,9)" + colContains4 + "'' " + colVal4 + "''" + " AND ";

                        }
                    }
                    else
                    {
                        if (col4 == "AircraftName" && colContains4 == "Contains")
                        {
                            sqlQuery += col4 + " Like ''%" + colVal4 + "%''" + " AND  ";
                        }
                        if (col4 == "AircraftName" && colContains4 != "Contains")
                        {
                            sqlQuery += col4 + colContains4 + "''" + colVal4 + "''" + " AND ";
                        }

                        if (col4 == "DayDualHrs" || col4 == "DaySoloHrs" || col4 == "DayCopilotHrs" || col4 == "NightDualHrs" || col4 == "NightSoloHrs" || col4 == "NightCopilotHrs" || col4 == "NVGExp" || col4 == "WSOExp" || col4 == "IF_Actual" || col4 == "InstrDayHrs" || col4 == "IMCHrs" || col4 == "SIFHrs" || col4 == "ALHSmlHrs" || col4 == "ALHSmlHrs" && colContains4 != "Contains")
                        {
                            sqlQuery += "ISNULL(" + col4 + ", 0)" + colContains4 + "  " + colVal4 + " AND ";
                        }
                    }

                }

            }

            if (Query == "PostingAviator")
            {
                if (colVal1 != string.Empty && colVal1 != null)
                {


                    if (colContains1 == "Contains")
                    {
                        sqlQuery += col1 + " Like ''%" + colVal1 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col1 == "SOS" || col1 == "SORS" || col1 == "TOS" || col1 == "TORS" || col1== "PostingInDate" && colContains1 != "Contains")
                        {
                            sqlQuery += col1 + colContains1 + "CAST(" + "''" + colVal1 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col1 + colContains1 + "''" + colVal1 + "''" + " AND ";
                        }

                    }

                }
                if (colVal2 != string.Empty && colVal2 != null)
                {
                    if (colContains2 == "Contains")
                    {
                        sqlQuery += col2 + " Like ''%" + colVal2 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col2 == "SOS" || col2 == "SORS" || col2 == "TOS" || col2 == "TORS" || col2 == "PostingInDate" && colContains2 != "Contains")
                        {
                            sqlQuery += col2 + colContains2 + "CAST(" + "''" + colVal2 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col2 + colContains2 + "''" + colVal2 + "''" + " AND ";
                        }

                    }



                }
                if (colVal3 != string.Empty && colVal3 != null)
                {
                    if (colContains3 == "Contains")
                    {
                        sqlQuery += col3 + " Like ''%" + colVal3 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col3 == "SOS" || col3 == "SORS" || col3 == "TOS" || col3== "TORS" || col3 == "PostingInDate" && colContains3 != "Contains")
                        {
                            sqlQuery += col3 + colContains3 + "CAST(" + "''" + colVal3 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col3 + colContains3 + "''" + colVal3 + "''" + " AND ";
                        }

                    }

                }
                if (colVal4 != string.Empty && colVal4 != null)
                {
                    if (colContains4 == "Contains")
                    {
                        sqlQuery += col4 + " Like ''%" + colVal4 + "%''" + " AND  ";
                    }
                    else
                    {
                        if (col4 == "SOS" || col4 == "SORS" || col4 == "TOS" || col4 == "TORS" || col4 == "PostingInDate" && colContains4 != "Contains")
                        {
                            sqlQuery += col4 + colContains4 + "CAST(" + "''" + colVal4 + "''" + " AS Date" + ")" + " AND ";
                        }
                        else
                        {
                            sqlQuery += col4 + colContains4 + "''" + colVal4 + "''" + " AND ";
                        }

                    }


                }
            }




            return sqlQuery.ToString();
        }       

        public string GetWhereQuery(string str)
        {
            string Query = string.Empty;
            if (str != String.Empty && str != null)
            {
                Query = "And " + str.Remove(str.Length - 5);
              
            }
            return Query.ToString();

        }
        #endregion
    }
}