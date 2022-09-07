using IHSDC.WebApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IHSDC.WebApp.Controllers
{
    public class TokenController : Controller
    {
        readonly Connection.DBConnection con = new Connection.DBConnection();
        // GET: Token
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddCert()
        {
            return View("AddUserCertificate");
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult AddUserCertificate(HttpPostedFileWrapper cert, user model)
        {
            BinaryReader b = new BinaryReader(cert.InputStream);
            byte[] binData = b.ReadBytes(cert.ContentLength);

            var data = con.insertUserCert(model, binData);

            return View();
        }
    }
}