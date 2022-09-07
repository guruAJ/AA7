using AA7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IHSDC.WebApp.Controllers
{
    public class MessageController : Controller
    {
        private IHSDCAA7DBDBContext db = new IHSDCAA7DBDBContext();

        // GET: Session Time Out

        public ActionResult SessionTimeOut()
        {


            return View();

        }
        // GET: Blank

        public ActionResult Blank()
        {


            return View();

        }
        // GET: Not Auth for view this Record

        public ActionResult NoAuth()
        {


            return View();

        }



        // GET: Message
        public ActionResult Index()
        {
            if (Session["UserIntId"] == null)
            {
                return View("SessionTimeOut");
            }

            //Posting Out Message
            int SessionUserID = Convert.ToInt32(Session["UserIntId"].ToString());
            string role = db.dbo_FullHierarchy.Where(x => x.ChildId == SessionUserID).FirstOrDefault().RoleName;
            var childunit = db.dbo_FullHierarchy.Where(x => x.ChildId == SessionUserID).Select(x => x.EstablishmentFull).ToList();
            var aviator = db.dbo_tbl_Aviator.Where(x => childunit.Contains(x.Unit_ID)).Select(x => x.Aviator_ID).ToList();
            string unit = db.dbo_FullHierarchy.Where(x => x.ChildId == SessionUserID).FirstOrDefault().EstablishmentFull;
            if (role == "FlightCommander")
            {               
                var PostingOut = db.dbo_tbl_AviatorPosting.Where(x => x.Validation == "Submitted to flt Cdr" || x.Validation == "Validated by Flt Cdr"
                  || x.CounterValidation == "Submitted to Flt Cdr Posted Unit" || x.Validation != "Rejected by Flt Cdr").
                      Where(x => x.CounterValidation != "Validated by Flt Cdr Posted Unit").Where(x => aviator.Contains(x.Aviator_ID)).Count();

                var Aviator = db.dbo_tbl_Aviator.Where(x => x.CounterValidation == "Submitted to flt Cdr").Where(x => aviator.Contains(x.Aviator_ID)).Count();
                var Course = db.dbo_tbl_AviatorCourses.Where(x => x.CounterValidation == "Submitted to flt Cdr").Where(x => aviator.Contains(x.Aviator_ID)).Count();
                var FlyingHrs = db.dbo_tbl_AviatorFlyingHrs.Where(x => x.CounterValidation == "Submitted to flt Cdr").Where(x => aviator.Contains(x.Aviator_ID)).Count();
                var HonoursAwards = db.dbo_tbl_AviatorHonourAwards.Where(x => x.CounterValidation == "Submitted to flt Cdr").Where(x => aviator.Contains(x.Aviator_ID)).Count();
                var Medical = db.dbo_tbl_AviatorMedical.Where(x => x.CounterValidation == "Submitted to flt Cdr").Where(x => aviator.Contains(x.Aviator_ID)).Count();
                var SpecialEqpt = db.dbo_tbl_AviatorSpecialEqpt.Where(x => x.CounterValidation == "Submitted to flt Cdr").Where(x => aviator.Contains(x.Aviator_ID)).Count();
                var SpecialQual = db.dbo_tbl_AviatorSpecialQual.Where(x => x.CounterValidation == "Submitted to flt Cdr").Where(x => aviator.Contains(x.Aviator_ID)).Count();
                var PostingIn = db.dbo_tbl_AviatorPosting.Where(x => x.CounterValidation == "Submitted to Flt Cdr Posted Unit" && x.PostingToUnit == unit).Count();

                ViewBag.Aviator = Aviator;
                ViewBag.Course = Course;
                ViewBag.FlyingHrs = FlyingHrs;
                ViewBag.HonoursAwards = HonoursAwards;
                ViewBag.Medical = Medical;
                ViewBag.SpecialEqpt = SpecialEqpt;
                ViewBag.SpecialQual = SpecialQual;
                ViewBag.PostingOut = PostingOut;
                ViewBag.PostingIn = PostingIn;
                return View();
            }

            if (role == "SecondInCommand")
            {
                var Aviator = db.dbo_tbl_Aviator.Where(x => x.Validation == "Submit to 2IC" || x.CounterValidation == "Submitted to flt Cdr").Where(x => aviator.Contains(x.Aviator_ID)).Count();
                var Course = db.dbo_tbl_AviatorCourses.Where(x => x.Validation == "Submit to 2IC" || x.CounterValidation == "Submitted to flt Cdr").Where(x => aviator.Contains(x.Aviator_ID)).Count();
                var FlyingHrs = db.dbo_tbl_AviatorFlyingHrs.Where(x => x.Validation == "Submit to 2IC" || x.CounterValidation == "Submitted to flt Cdr").Where(x => aviator.Contains(x.Aviator_ID)).Count();
                var HonoursAwards = db.dbo_tbl_AviatorHonourAwards.Where(x => x.Validation == "Submit to 2IC" || x.CounterValidation == "Submitted to flt Cdr").Where(x => aviator.Contains(x.Aviator_ID)).Count();
                var Medical = db.dbo_tbl_AviatorMedical.Where(x => x.Validation == "Submit to 2IC" || x.CounterValidation == "Submitted to flt Cdr").Where(x => aviator.Contains(x.Aviator_ID)).Count();
                var SpecialEqpt = db.dbo_tbl_AviatorSpecialEqpt.Where(x => x.Validation == "Submit to 2IC" || x.CounterValidation == "Submitted to flt Cdr").Where(x => aviator.Contains(x.Aviator_ID)).Count();
                var SpecialQual = db.dbo_tbl_AviatorSpecialQual.Where(x => x.Validation == "Submit to 2IC" || x.CounterValidation == "Submitted to flt Cdr").Where(x => aviator.Contains(x.Aviator_ID)).Count();


                ViewBag.Aviator = Aviator;
                ViewBag.Course = Course;
                ViewBag.FlyingHrs = FlyingHrs;
                ViewBag.HonoursAwards = HonoursAwards;
                ViewBag.Medical = Medical;
                ViewBag.SpecialEqpt = SpecialEqpt;
                ViewBag.SpecialQual = SpecialQual;
               
                return View();
            }


            if (role == "Unit")// Work Bal
            {
                
                var Course = db.dbo_tbl_AviatorCourses.
                    Where(x => x.CounterValidation == "Rejected by Flt Cdr" ||
                    x.Validation == "Submit to 2IC" ||
                    x.Validation == "Rejected by 2IC" ||
                    x.CounterValidation == "Submitted to Flt Cdr" ||
                    x.Validation == null)
                    .Where(x => aviator.Contains(x.Aviator_ID)).Count();

                var HonoursAwards = db.dbo_tbl_AviatorHonourAwards.
                   Where(x => x.CounterValidation == "Rejected by Flt Cdr" ||
                   x.Validation == "Submit to 2IC" ||
                   x.Validation == "Rejected by 2IC" ||
                   x.CounterValidation == "Submitted to Flt Cdr" ||
                   x.Validation == null)
                   .Where(x => aviator.Contains(x.Aviator_ID)).Count();

                var Medical = db.dbo_tbl_AviatorMedical.
                  Where(x => x.CounterValidation == "Rejected by Flt Cdr" ||
                  x.Validation == "Submit to 2IC" ||
                  x.Validation == "Rejected by 2IC" ||
                  x.CounterValidation == "Submitted to Flt Cdr" ||
                  x.Validation == null)
                  .Where(x => aviator.Contains(x.Aviator_ID)).Count();

                var SpecialEqpt = db.dbo_tbl_AviatorSpecialEqpt.
                  Where(x => x.CounterValidation == "Rejected by Flt Cdr" ||
                  x.Validation == "Submit to 2IC" ||
                  x.Validation == "Rejected by 2IC" ||
                  x.CounterValidation == "Submitted to Flt Cdr" ||
                  x.Validation == null)
                  .Where(x => aviator.Contains(x.Aviator_ID)).Count();

                var SpecialQual = db.dbo_tbl_AviatorSpecialQual.
                 Where(x => x.CounterValidation == "Rejected by Flt Cdr" ||
                 x.Validation == "Submit to 2IC" ||
                 x.Validation == "Rejected by 2IC" ||
                 x.CounterValidation == "Submitted to Flt Cdr" ||
                 x.Validation == null)
                 .Where(x => aviator.Contains(x.Aviator_ID)).Count();


                var FlyingHrs = db.dbo_tbl_AviatorFlyingHrs.
                 Where(x => x.CounterValidation == "Rejected by Flt Cdr" ||
                 x.Validation == "Submit to 2IC" ||
                 x.Validation == "Rejected by 2IC" ||
                 x.CounterValidation == "Submitted to Flt Cdr" ||
                 x.Validation == null)
                 .Where(x => aviator.Contains(x.Aviator_ID)).Count();

                var Aviator = db.dbo_tbl_Aviator.
                 Where(x => x.CounterValidation == "Rejected by Flt Cdr" ||
                 x.Validation == "Submit to 2IC" ||
                 x.Validation == "Rejected by 2IC" ||
                 x.CounterValidation == "Submitted to Flt Cdr" ||
                 x.Validation == null)
                 .Where(x => aviator.Contains(x.Aviator_ID)).Count();

                var PostingOut = db.dbo_tbl_AviatorPosting.Where(x => x.CounterValidation != "Validated by Flt Cdr Posted Unit")
                    .Where(x => x.PostingFromUnit == unit).Count();

                var PostingIn = db.dbo_tbl_AviatorPosting.Where(x => x.PostingToUnit == unit && x.Validation == "Validated by Flt Cdr").Where(x => x.CounterValidation != "Validated by Flt Cdr Posted Unit").Count();

                ViewBag.Aviator = Aviator;
                ViewBag.Course = Course;
                ViewBag.FlyingHrs = FlyingHrs;
                ViewBag.HonoursAwards = HonoursAwards;
                ViewBag.Medical = Medical;
                ViewBag.SpecialEqpt = SpecialEqpt;
               ViewBag.SpecialQual = SpecialQual;
                ViewBag.PostingOut = PostingOut;
                ViewBag.PostingIn = PostingIn;
                return View();
            }

            else
            return View("Blank"); 
        }
    }
}