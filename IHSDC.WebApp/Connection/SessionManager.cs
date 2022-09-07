using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IHSDC.WebApp.Connection
{
    public class SessionManager
    {

        public static string UserIntId
        {
            get
            {
                if (HttpContext.Current.Session["UserIntId"] != null)
                {
                    return (HttpContext.Current.Session["UserIntId"].ToString());
                }
                else
                {
                    return null;
                }
            }
            set
            {
                HttpContext.Current.Session["UserIntId"] = value;
            }
        }

        public static string UserEmail
        {
            get
            {
                if (HttpContext.Current.Session["UserEmail"] != null)
                {
                    return (HttpContext.Current.Session["UserEmail"].ToString());
                }
                else
                {
                    return null;
                }
            }
            set
            {
                HttpContext.Current.Session["UserEmail"] = value;
            }
        }
        public static string UserName
        {
            get
            {
                if (HttpContext.Current.Session["UserName"] != null)
                {
                    return (HttpContext.Current.Session["UserName"].ToString());
                }
                else
                {
                    return null;
                }
            }
            set
            {
                HttpContext.Current.Session["UserName"] = value;
            }
        }

        public static string UnitName
        {
            get
            {
                if (HttpContext.Current.Session["UnitName"] != null)
                {
                    return (HttpContext.Current.Session["UnitName"].ToString());
                }
                else
                {
                    return null;
                }
            }
            set
            {
                HttpContext.Current.Session["UnitName"] = value;
            }
        }
        public static string UserMobile
        {
            get
            {
                if (HttpContext.Current.Session["UserMobile"] != null)
                {
                    return (HttpContext.Current.Session["UserMobile"].ToString());
                }
                else
                {
                    return null;
                }
            }
            set
            {
                HttpContext.Current.Session["UserMobile"] = value;
            }
        }

        public static string UserRole
        {
            get
            {
                if (HttpContext.Current.Session["UserRole"] != null)
                {
                    return (HttpContext.Current.Session["UserRole"].ToString());
                }
                else
                {
                    return null;
                }
            }
            set
            {
                HttpContext.Current.Session["UserRole"] = value;
            }
        }
        public static string UserId
        {
            get
            {
                if (HttpContext.Current.Session["UserId"] != null)
                {
                    return (HttpContext.Current.Session["UserId"].ToString());
                }
                else
                {
                    return null;
                }
            }
            set
            {
                HttpContext.Current.Session["UserId"] = value;
            }
        }

        public static string Role
        {
            get
            {
                if (HttpContext.Current.Session["Role"] != null)
                {
                    return (HttpContext.Current.Session["Role"].ToString());
                }
                else
                {
                    return null;
                }
            }
            set
            {
                HttpContext.Current.Session["Role"] = value;
            }
        }
        public static string GEBLetterId
        {
            get
            {
                if (HttpContext.Current.Session["GEBLetterId"] != null)
                {
                    return (HttpContext.Current.Session["GEBLetterId"].ToString());
                }
                else
                {
                    return null;
                }
            }
            set
            {
                HttpContext.Current.Session["GEBLetterId"] = value;
            }
        }

        public static string UnitType
        {
            get
            {
                if (HttpContext.Current.Session["UnitType"] != null)
                {
                    return (HttpContext.Current.Session["UnitType"].ToString());
                }
                else
                {
                    return null;
                }
            }
            set
            {
                HttpContext.Current.Session["UnitType"] = value;
            }
        }
        public static string AviatorIds
        {
            get
            {
                if (HttpContext.Current.Session["AviatorIds"] != null)
                {
                    return (HttpContext.Current.Session["AviatorIds"].ToString());
                }
                else
                {
                    return null;
                }
            }
            set
            {
                HttpContext.Current.Session["AviatorIds"] = value;
            }
        }


        public static string AppxC
        {
            get
            {
                if (HttpContext.Current.Session["AppxC"] != null)
                {
                    return (HttpContext.Current.Session["AppxC"].ToString());
                }
                else
                {
                    return null;
                }
            }
            set
            {
                HttpContext.Current.Session["AppxC"] = value;
            }
        }

        public static string GEBType
        {
            get
            {
                if (HttpContext.Current.Session["GEBType"] != null)
                {
                    return (HttpContext.Current.Session["GEBType"].ToString());
                }
                else
                {
                    return null;
                }
            }
            set
            {
                HttpContext.Current.Session["GEBType"] = value;
            }
        }
        //
    }
}