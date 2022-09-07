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
    public class GEBExamController : Controller
    {
        readonly Connection.DBConnection con = new Connection.DBConnection();

        public ActionResult GEBList()
        {
            GEBLetter model = new GEBLetter();
            var result = con.GEBLetterList(1, 0, string.Empty);
            model.ILGEBLetter = result;
            ViewBag.count = model.ILGEBLetter.Count();
            return View(model);
        }



        public ActionResult AppxEReport(string fid)
        {
            AppxEPerformance model = new AppxEPerformance();

            if (fid != string.Empty && fid != null)
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(fid));
                model.FinalAppxId = item;
                Session["FinalAppxId"] = RepositryManager.EncryptionManager.Encryption(model.FinalAppxId.ToString());
                var editdata = con.UpdateAppxEPerFormence(2, model);
                model = editdata[0];

                model.FinalAppxId = item;
                var data = con.EditUpdateGEB(5, model);
                model.finalAppx = data[0];
             

            }
            return View(model);
        }


        public ActionResult AppxFReport(string fid)
        {
            AppxFPerformance model = new AppxFPerformance();

            if (fid != string.Empty && fid != null)
            {
                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(fid));
                model.FinalAppxId = item;
                var editdata = con.UpdateAppxFPerFormence(2, model);
                model = editdata[0];

                model.appxF = new AppxF();
                model.appxF.FinalAppxId = item;
                var AppxF = con.UpdateAppxF(3, model.appxF);
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


        public ActionResult AppxGReport(string fid)
        {
            AppxGPerformance model = new AppxGPerformance();

            if (fid != string.Empty && fid != null)
            {


                int item = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(fid));
                model.FinalAppxId = item;
                var editdata = con.UpdateAppxGPerFormence(3, model);
                model = editdata[0];

                model.AppxG = new AppxG();
                model.AppxG.FinalAppxId = item;
                var UpdateAppxG = con.UpdateAppxG(6, model.AppxG);
                model.AppxG = UpdateAppxG[0];

                model.AppxGFlgHrs = new AppxGFlgHrs();
                model.AppxGFlgHrs.AppxGId = item;
                model.ILAppxGFlgHrs = con.AppxGFlgHrs(2, model.AppxGFlgHrs);

            }
            return View(model);
        }

        [HttpGet]
        public ActionResult AppxDReport(string gid)
        {
            NominalRollForGEB model = new NominalRollForGEB();
            int Letterid = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(gid));
            var data = con.GenrateNominalRoll(7,Letterid,string.Empty);
            var Units = data.GroupBy(product => product.UnitName).Select(grp => grp.First()).Select(x => x.UnitName).ToList();
            ViewBag.Units = Units;
            model.ILLetterForwardedGEB = data;
            return View(model);
        }
        [HttpGet]
        public ActionResult AppxCReport(string gid)
        {
            NominalRollForGEB model = new NominalRollForGEB();
            int Letterid = Convert.ToInt32(RepositryManager.EncryptionManager.Decryption(gid));
            Session["Letterid"] = Letterid;

            var data = con.GenrateNominalRoll(2, Letterid,string.Empty);
            var Units = data.GroupBy(product => product.UnitName).Select(grp => grp.First()).Select(x => x.UnitName).ToList();
            ViewBag.Units = Units;
            ViewBag.GEBMonth = data[0].FromDate.ToString();
            model.ILLetterForwardedGEB = data;
            return View(model);
        }

        [HttpPost]
        public ActionResult AppxCReport(NominalRollForGEB model)
        {
            string sqlQuery = string.Empty;

           
            if(model.aviator.ColContains1!=string.Empty  && model.aviator.ColContains1 !=null)
            {
                 sqlQuery = model.aviator.ColContains1.ToString();
               var data = con.GenrateNominalRoll(3, Convert.ToInt32(Session["Letterid"]), sqlQuery);
                model.ILLetterForwardedGEB = data;

            }
            else if(model.aviator.ColContains2 != string.Empty && model.aviator.ColContains2 != null)
            {
                sqlQuery = model.aviator.ColContains2.ToString();
                var data = con.GenrateNominalRoll(4, Convert.ToInt32(Session["Letterid"]), sqlQuery);
                model.ILLetterForwardedGEB = data;

            }
            else if (model.aviator.ColContains3 != string.Empty && model.aviator.ColContains3!= null)
            {
                sqlQuery = model.aviator.ColContains3.ToString();
                var data = con.GenrateNominalRoll(5, Convert.ToInt32(Session["Letterid"]), sqlQuery);
                model.ILLetterForwardedGEB = data;
            }
            else if (model.aviator.ColContains4 != string.Empty && model.aviator.ColContains4 != null)
            {
                sqlQuery = model.aviator.ColContains4.ToString();
                var data = con.GenrateNominalRoll(6, Convert.ToInt32(Session["Letterid"]), sqlQuery);
                model.ILLetterForwardedGEB = data;
            }
            else
            {
                var data = con.GenrateNominalRoll(2, Convert.ToInt32(Session["Letterid"]), string.Empty);
                model.ILLetterForwardedGEB = data;
            }   
         

            return View(model);
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

    }
}