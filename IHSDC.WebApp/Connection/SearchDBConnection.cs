using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using IHSDC.WebApp.Models;
using IHSDC.WebApp.Connection;

namespace IHSDC.WebApp.Connection
{
    public class SearchDBConnection : DbContext 
    {
        public SearchDBConnection() : base("IHSDCAA7DBConnectionString")
        {

        }

        #region  Get Data in DB 
        public IList<AviatorCRUD> AviatorSearch(int id, string str)
        {
            var data = GetDataInList<AviatorCRUD>(" proc_SearchingProcess @procId ='" + id + "', @str ='" + str + "',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName.ToString() + "' ,@Aid='" + SessionManager.AviatorIds.ToString() + "'").ToList();
            return data;
        }
        public IList<AviatorCoursesCRUD> AviatorCourseList(int id)
        {
            var data = GetDataInList<AviatorCoursesCRUD>("proc_Search @procId ='" + id + "',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName.ToString() + "' , @str ='" + SessionManager.AviatorIds.ToString() + "'").ToList();
            return data;
        }
        public IList<AviatorMedicalCRUD> AviatorMedicalList(int id)
        {
            var data = GetDataInList<AviatorMedicalCRUD>(" proc_Search @procId ='" + id + "',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName.ToString() + "' , @str ='" + SessionManager.AviatorIds.ToString() + "'").ToList();
            return data;
        }
        public IList<AviatorCoursesCRUD> AviatorCourseSearch(int id, string str)
        {
            var data = GetDataInList<AviatorCoursesCRUD>(" proc_SearchingProcess @procId ='" + id + "', @str ='" + str + "',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName.ToString() + "' ,@Aid='" + SessionManager.AviatorIds.ToString() + "'").ToList();
            return data;
        }
        public IList<AviatorMedicalCRUD> AviatorMedicalSearch(int id, string str)
        {
            var data = GetDataInList<AviatorMedicalCRUD>(" proc_SearchingProcess @procId ='" + id + "', @str ='" + str + "',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName.ToString() + "' ,@Aid='" + SessionManager.AviatorIds.ToString() + "'").ToList();
            return data;
        }
        public IList<AviatorHonourAwardsCRUD> AviatorHonourAwardsSearchList()
        {
            var data = GetDataInList<AviatorHonourAwardsCRUD>(" proc_Search @procId ='" + 3 + "',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName.ToString() + "' , @str ='" + SessionManager.AviatorIds.ToString() + "'").ToList();
            return data;
        }
        public IList<AviatorHonourAwardsCRUD> AviatorHonourAwardsSearch(string str)
        {
            var data = GetDataInList<AviatorHonourAwardsCRUD>(" proc_SearchingProcess @procId ='" + 4 + "', @str ='" + str + "',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName.ToString() + "' ,@Aid='" + SessionManager.AviatorIds.ToString() + "'").ToList();
            return data;
        }        
        public IList<AviatorSpecialEqptCRUD> AviatorEQPTSearchList()
        {
            var data = GetDataInList<AviatorSpecialEqptCRUD>(" proc_Search @procId ='" + 4 + "',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName.ToString() + "' , @str ='" + SessionManager.AviatorIds.ToString() + "'").ToList();
            return data;
        }
        public IList<AviatorSpecialEqptCRUD> AviatorEQPTSearch(string str)
        {
            var data = GetDataInList<AviatorSpecialEqptCRUD>(" proc_SearchingProcess @procId ='" + 5 + "', @str ='" + str + "',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName.ToString() + "' ,@Aid='" + SessionManager.AviatorIds.ToString() + "'").ToList();
            return data;
        }        
        public IList<AviatorAccidentCRUD> AviatorAccidentSearchList()
        {
            var data = GetDataInList<AviatorAccidentCRUD>(" proc_Search @procId ='" + 5 + "',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName.ToString() + "' , @str ='" + SessionManager.AviatorIds.ToString() + "'").ToList();
            return data;
        }
        public IList<AviatorAccidentCRUD> AviatorAccidentSearch(string str)
        {
            var data = GetDataInList<AviatorAccidentCRUD>(" proc_SearchingProcess @procId ='" + 6 + "', @str ='" + str + "',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName.ToString() + "' ,@Aid='" + SessionManager.AviatorIds.ToString() + "'").ToList();
            return data;
        }        
        public IList<AviatorSpecialQualCRUD> AviatorQUALList()
        {
            var data = GetDataInList<AviatorSpecialQualCRUD>(" proc_Search @procId ='" + 6 + "',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName.ToString() + "' , @str ='" + SessionManager.AviatorIds.ToString() + "'").ToList();
            return data;
        }
        public IList<AviatorSpecialQualCRUD> AviatorQUALSearch(string str)
        {
            var data = GetDataInList<AviatorSpecialQualCRUD>(" proc_SearchingProcess @procId ='" + 7 + "', @str ='" + str + "',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName.ToString() + "' ,@Aid='" + SessionManager.AviatorIds.ToString() + "'").ToList();
            return data;
        }        
        public IList<AviatorRankCRUD> AviatorRankSearchList()
        {
            var data = GetDataInList<AviatorRankCRUD>(" proc_Search @procId ='" + 7 + "',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName.ToString() + "' , @str ='" + SessionManager.AviatorIds.ToString() + "'").ToList();
            return data;
        }
        public IList<AviatorRankCRUD> AviatorRankSearch(string str)
        {
            var data = GetDataInList<AviatorRankCRUD>(" proc_SearchingProcess @procId ='" + 8 + "', @str ='" + str + "',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName.ToString() + "' ,@Aid='" + SessionManager.AviatorIds.ToString() + "'").ToList();
            return data;
        }     
        public IList<AviatorApptCRUD> AviatorAPPSearchList()
        {
            var data = GetDataInList<AviatorApptCRUD>(" proc_Search @procId ='" + 8 + "',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName.ToString() + "' , @str ='" + SessionManager.AviatorIds.ToString() + "'").ToList();
            return data;
        }
        public IList<AviatorApptCRUD> AviatorAPPSearch(string str)
        {
            var data = GetDataInList<AviatorApptCRUD>(" proc_SearchingProcess @procId ='" + 9 + "', @str ='" + str + "',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName.ToString() + "' ,@Aid='" + SessionManager.AviatorIds.ToString() + "'").ToList();
            return data;
        }
        public IList<AviatorContactDetailsCRUD> AviatorContactDetailsSearchList()
        {
            var data = GetDataInList<AviatorContactDetailsCRUD>(" proc_Search @procId ='" + 9 + "',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName.ToString() + "' , @str ='" + SessionManager.AviatorIds.ToString() + "'").ToList();
            return data;
        }
        public IList<AviatorContactDetailsCRUD> AviatorContactDetailsSearch(string str)
        {
            var data = GetDataInList<AviatorContactDetailsCRUD>(" proc_SearchingProcess @procId ='" + 10 + "', @str ='" + str + "',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName.ToString() + "' ,@Aid='" + SessionManager.AviatorIds.ToString() + "'").ToList();
            return data;
        }
        public IList<AviatorFlyingHrsCRUD> AviatorFlyingSearchList()
        {
            var data = GetDataInList<AviatorFlyingHrsCRUD>(" proc_Search @procId ='" + 10 + "',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName.ToString() + "' , @str ='" + SessionManager.AviatorIds.ToString() + "'").ToList();
            return data;
        }
        public IList<AviatorFlyingHrsCRUD> AviatorFlyingSearch(string str)
        {
            var data = GetDataInList<AviatorFlyingHrsCRUD>(" proc_SearchingProcess @procId ='" + 11 + "', @str ='" + str + "',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName.ToString() + "' ,@Aid='" + SessionManager.AviatorIds.ToString() + "'").ToList();
            return data;
        }



        public IList<PostingAviator> AviatorPostingSearchList()
        {
            var data = GetDataInList<PostingAviator>(" proc_Search @procId ='" + 11 + "',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName.ToString() + "' , @str ='" + SessionManager.AviatorIds.ToString() + "'").ToList();
            return data;
        }
        public IList<PostingAviator> AviatorPostingSearch(string str)
        {
            var data = GetDataInList<PostingAviator>(" proc_SearchingProcess @procId ='" + 12 + "', @str ='" + str + "',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName.ToString() + "' ,@Aid='" + SessionManager.AviatorIds.ToString() + "'").ToList();
            return data;
        }


        #endregion
        #region Execute Query In DB  
        public List<T> GetDataInList<T>(String Query)
        {
            try
            {
                IList<T> sqlList = this.Database.SqlQuery<T>(Query).ToList();
                return sqlList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}