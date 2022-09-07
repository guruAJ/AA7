using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using IHSDC.WebApp.Models;
using IHSDC.WebApp.Connection;
using System.Text;
using System.Web.Mvc;

namespace IHSDC.WebApp.Connection
{
    public class DBConnection:DbContext
    {
        public DBConnection():base("IHSDCAA7DBConnectionString")
        {

        }

        #region Master

        #region Comd
        public IList<ComdCRUD> ComdCRUD(int procid, ComdCRUD model)
        {
            var data = GetDataInList<ComdCRUD>("proc_Comd_CRUD @procId='" + procid + "',@ComdId='" + model.ComdId + "',@ComdName='" + model.ComdName + "' ,@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "'").ToList();
            return data;
        }
        #endregion



        #region Rank
        public IList<RankCRUD> RankCRUD(int procid, RankCRUD model)
        {
            var data = GetDataInList<RankCRUD>("proc_Rank_CRUD @procId='" + procid + "',@RankId='" + model.RankId + "',@RankName='" + model.RankName + "' ,@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "'").ToList();
            return data;
        }
        #endregion

        #region Corps

        public IList<CorpsCRUD> CorpsCRUD(int procid, CorpsCRUD model)
        {
            var data = GetDataInList<CorpsCRUD>("proc_Corps_CRUD @procId='" + procid + "',@CorpsId='" + model.CorpsId + "',@CorpsName='" + model.CorpsName + "' ,@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "'").ToList();
            return data;
        }
        #endregion

        #region Unit
        public IList<UnitCRUD> UnitCRUD(int procid, UnitCRUD model)
        {
            var data = GetDataInList<UnitCRUD>("proc_Unit_CRUD @procId='" + procid + "',@Unit_ID='" + model.Unit_ID + "',@UnitName='" + model.UnitName + "',@Command='" + model.Command + "' ,@Corps='" + model.Corps + "'  ,@TypeOfUnit='" + model.TypeOfUnit + "'  ,@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "'").ToList();
            return data;
        }
        #endregion


        #region Courses
        public IList<CoursesCRUD> CoursesCRUD(int procid, CoursesCRUD model)
        {
            var data = GetDataInList<CoursesCRUD>("proc_Course_CRUD @procId='" + procid + "',@Course_ID='" + model.Course_ID + "',@CourseName='" + model.CourseName + "',@CoursePlace='" + model.CoursePlace + "' ,@CourseInstitute='" + model.CourseInstitute + "'  ,@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "'").ToList();
            return data;
        }
        #endregion
        

        #region SpecialEqpt
        public IList<SpecialEqptCRUD> SpecialEqptCRUD(int procid, SpecialEqptCRUD model)
        {
            var data = GetDataInList<SpecialEqptCRUD>("proc_SpecialEqpt_CRUD @procId='" + procid + "',@SpecialEqpt_ID='" + model.SpecialEqpt_ID + "',@SpecialEqptName='" + model.SpecialEqptName + "' ,@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "'").ToList();
            return data;
        }
        #endregion

        #region SpecialQual
        public IList<SpecialQualCRUD> SpecialQualCRUD(int procid, SpecialQualCRUD model)
        {
            var data = GetDataInList<SpecialQualCRUD>("proc_SpecialQual_CRUD @procId='" + procid + "',@SpecialQual_ID='" + model.SpecialQual_ID + "',@SpecialQualName='" + model.SpecialQualName + "' ,@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "'").ToList();
            return data;
        }
        #endregion

        #region HonourAward
        public IList<HonourAwardCRUD> HonourAwardCRUD(int procid, HonourAwardCRUD model)
        {
            var data = GetDataInList<HonourAwardCRUD>("proc_HonourAward_CRUD @procId='" + procid + "',@HonourAward_ID='" + model.HonourAward_ID + "',@HonourAwardName='" + model.HonourAwardName + "' ,@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "'").ToList();
            return data;
        }
        #endregion

        #region ArmService
        public IList<ArmServiceCRUD> ArmServiceCRUD(int procid, ArmServiceCRUD model)
        {
            var data = GetDataInList<ArmServiceCRUD>("proc_ArmService_CRUD @procId='" + procid + "',@ArmService_ID='" + model.ArmService_ID + "',@ArmServiceName='" + model.ArmServiceName + "' ,@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "'").ToList();
            return data;
        }
        #endregion

        #region Aircraft
        public IList<AircraftCRUD> AircraftCRUD(int procid, AircraftCRUD model)
        {
            var data = GetDataInList<AircraftCRUD>("proc_Aircraft_CRUD @procId='" + procid + "',@Aircraft_ID='" + model.Aircraft_ID + "',@AircraftName='" + model.AircraftName + "' ,@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "'").ToList();
            return data;
        }
        #endregion

        #region Accident Cat CRUD
        public IList<AccidentCatCRUD> AccidentCatCRUD(int procid, AccidentCatCRUD model)
        {
            var data = GetDataInList<AccidentCatCRUD>("proc_Accident_CRUD @procId='" + procid + "',@AccidentCat_ID='" + model.AccidentCat_ID + "',@AccidentCatName='" + model.AccidentCatName + "' ,@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "'").ToList();
            return data;
        }
        #endregion

        #region FlgWithAppt
        public IList<FlgWithApptCRUD> FlgWithApptCRUD(int procid, FlgWithApptCRUD model)
        {
            var data = GetDataInList<FlgWithApptCRUD>("proc_FlgWithAppt_CRUD @procId='" + procid + "',@FlgWithApptId='" + model.FlgWithApptId + "',@ApptName='" + model.ApptName + "' ,@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "'").ToList();
            return data;
        }
        #endregion

        #region CourseGradingCRUD
        public IList<CourseGradingCRUD> CourseGradingCRUD(int procid, CourseGradingCRUD model)
        {
            var data = GetDataInList<CourseGradingCRUD>("proc_CourseGrading_CRUD @procId='" + procid + "',@CourseGradingId='" + model.CourseGradingId + "',@Grading='" + model.Grading + "' ,@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "'").ToList();
            return data;
        }
        #endregion
        #endregion Master
        #region AA7
        #region Aviator Course
        public IList<AviatorCoursesCRUD> AviatorCoursesCRUD(int procid, AviatorCoursesCRUD model)
        {
            var data = GetDataInList<AviatorCoursesCRUD>("proc_AviatorCourses_CRUD @procId='" + procid + "',@AviatorCourses_ID='" + model.AviatorCourses_ID + "',@Aviator_ID='" + model.Aviator_ID + "',@Course_ID='" + model.Course_ID + "' ,@CourseSerialNumber='" + model.CourseSerialNumber + "'  ,@CourseStartDate='" + model.CourseStartDate + "'  ,@CourseEndDate='" + model.CourseEndDate + "'  ,@CourseGrading='" + model.CourseGrading + "'  ,@InstructorGrading='" + model.InstructorGrading + "'  ,@Special_Award='" + model.Special_Award + "'  ,@Notes='" + model.Notes + "'  ,@Validation='" + model.Validation + "'  ,@ValidationDate='" + model.ValidationDate + "'  ,@CounterValidation='" + model.CounterValidation + "'  ,@CounterValidationDate='" + model.CounterValidationDate + "'  ,@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "', @UnitName='" + SessionManager.UnitName.ToString() + "'").ToList();
            return data;
        }

        public IList<AviatorCoursesCRUD> SubmitCourse(string procid, string Query)

        {
          
            var data = GetDataInList<AviatorCoursesCRUD>("proc_Submit @procId='" + procid + "',@Query='"+Query+"'").ToList();
            return data;
        }


        #endregion

        #region Aviator
        public IList<AviatorCRUD> AviatorCRUD(int procid, AviatorCRUD model)
        {
            var data = GetDataInList<AviatorCRUD>("proc_Aviator_CRUD @procId='" + procid + "',@Aviator_ID='" + model.Aviator_ID + "',@ArmyNumber ='" + model.ArmyNumber + "',@AviatorRank='"+model.AviatorRank+"', @FirstName = '" + model.FirstName +"',@MiddleName = '" + model.MiddleName + "', @LastName = '"+ model.LastName + "',@ArmService_ID = '"+ model.ArmService_ID + "',@Aircraft_ID = '" + model.Aircraft_ID + "', @DateOfBirth = '" + model.DateOfBirth + "', @DateOfSeniority = '" + model.DateOfSeniority + "',@DateOfWings = '" + model.DateOfWings + "',@DateOfRank = '" + model.DateofIssueCatCard + "',@DateofIssueCatCard = '" + model.DateOfRank + "',@CatCardNo = '" + model.CatCardNo + "', @Validation = '" + model.Validation + "',@ValidationDate = '" + model.ValidationDate + "', @CounterValidation = '" + model.CounterValidation + "',@CounterValidationDate = '" + model.CounterValidationDate + "',@RoleName  = '" + SessionManager.UserRole + "',@UnitName  = '" +
                SessionManager.UnitName.ToString() + "',@UserId  = '" + Convert.ToInt16(SessionManager.UserIntId) + "',@DateOfCommision='" + model.DateOfCommision + "'").ToList();
                 return data;
        }

        public IList<AviatorCRUD> AviatorSubmit(string submit, int Aviator_ID)
        {
            var data = GetDataInList<AviatorCRUD>(" proc_AviatorSubmit @ProcId ='" + submit + "', @Aviator_ID ='" + Aviator_ID + "' ").ToList();
            return data;

        }

 
        public IList<PostingAviator> AviatorPostingSubmit(string submit, int AviatorPosting_ID)
        {
            var data = GetDataInList<PostingAviator>(" proc_AviatorPostingSubmit @AviatorPosting_ID='"+ AviatorPosting_ID + "' ,@procId ='" + submit + "' ").ToList();
            return data;

        }

        #endregion

        #region Aviator Honour Awards
        public IList<AviatorHonourAwardsCRUD> AviatorHonourAwardsCRUD(int procid, AviatorHonourAwardsCRUD model)
        {
            var data = GetDataInList<AviatorHonourAwardsCRUD>("proc_AviatorHonourAwards_CRUD @procId='" + procid + "',@AviatorHonourAwards_ID='" + model.AviatorHonourAwards_ID + "',@Aviator_ID='" + model.Aviator_ID + "',@HonourAward_ID='" + model.HonourAward_ID + "' ,@HonourAwardsDate='" + model.HonourAwardsDate + "'  ,@HonourAwardsPlace='" + model.HonourAwardsPlace + "'  ,@Validation='" + model.Validation + "'  ,@ValidationDate='" + model.ValidationDate + "'  ,@CounterValidation='" + model.CounterValidation + "'  ,@CounterValidationDate='" + model.CounterValidationDate + "'  ,@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='"+SessionManager.UnitName+"',@Remarks='"+model.Remarks+"'").ToList();
            return data;
        }

        public IList<AviatorHonourAwardsCRUD> SubmitHonourAwards(string procid, string Query)

        {

            var data = GetDataInList<AviatorHonourAwardsCRUD>("proc_Submit @procId='" + procid + "',@Query='" + Query + "'").ToList();
            return data;
        }
        #endregion

        #region Aviator Special Eqpt
        public IList<AviatorSpecialEqptCRUD> AviatorSpecialEqptCRUD(int procid, AviatorSpecialEqptCRUD model)
        {
            var data = GetDataInList<AviatorSpecialEqptCRUD>("proc_AviatorSpecialEqpt_CRUD @procId='" + procid + "',@AviatorSpecialEqpt_ID='" + model.AviatorSpecialEqpt_ID + "',@Aviator_ID='" + model.Aviator_ID + "',@SpecialEqpt_ID='" + model.SpecialEqpt_ID + "' ,@SpecialEqptDate='" + model.SpecialEqptDate + "' ,@Validation='" + model.Validation + "'  ,@ValidationDate='" + model.ValidationDate + "'  ,@CounterValidation='" + model.CounterValidation + "'  ,@CounterValidationDate='" + model.CounterValidationDate + "'  ,@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName + "'").ToList();
            return data;

        }

        public IList<AviatorSpecialEqptCRUD> SubmitSpecialEqpt(string procid, string Query)

        {

            var data = GetDataInList<AviatorSpecialEqptCRUD>("proc_Submit @procId='" + procid + "',@Query='" + Query + "'").ToList();
            return data;
        }
        #endregion


        #region Aviator Flying Hrs 
        public IList<AviatorFlyingHrsCRUD> AviatorFlyingHrsCRUD(int procid, AviatorFlyingHrsCRUD model)
        {
            var data = GetDataInList<AviatorFlyingHrsCRUD>(" proc_AviatorFlyingHrs_CRUD  @ProcId ='" + procid + "',    @AviatorFlyingHrs_ID ='" + model.AviatorFlyingHrs_ID + "',  @Aviator_ID ='" + model.Aviator_ID + "',  @Aircraft_ID               ='" + model.Aircraft_ID + "',    @UnitName = '" + model.UnitName +"', @DayDualHrs='" + model.DayDualHrs +"', @DaySoloHrs='" + model.DaySoloHrs + "', @DayCopilotHrs ='" + model.DayCopilotHrs + "',  @NightDualHrs              ='" + model.NightDualHrs + "', @NightSoloHrs = '"+model.NightSoloHrs +"', @NightCopilotHrs = '"+model.NightCopilotHrs  +"', @NVGExp = '"+model.NVGExp+"',  @WSOExp = '"+model.WSOExp +"', @IF_Actual = '"+model.IF_Actual            +"', @InstrDayHrs = '"+model.InstrDayHrs          +"',  @InstrNightHrs = '"+model.InstrNightHrs+"', @IMCHrs = '"+model.IMCHrs               +"', @SIFHrs = '"+model.SIFHrs               + "', @ALHSmlHrs = '" + model.ALHSmlHrs + "', @Month = '" + model.Month                +"', @Validation = '"+model.Validation +"',@ValidationDate = '"+model.ValidationDate+"', @CounterValidation = '"+model.CounterValidation +"', @CounterValidationDate = '"+model.CounterValidationDate+"', @UserId = '"+ Convert.ToInt16(SessionManager.UserIntId) + "' ").ToList();
            return data;
          

        }
        public IList<AviatorFlyingHrsCRUD> SubmitAviatorFlyingHrs(string procid, string Query)

        {

            var data = GetDataInList<AviatorFlyingHrsCRUD>("proc_Submit @procId='" + procid + "',@Query='" + Query + "'").ToList();
            return data;
        }
        #endregion

        #region Aviator Accident Incident 
        public IList<AviatorAccidentCRUD> AviatorAccidentCRUD(int procid, AviatorAccidentCRUD model)
        {
            var data = GetDataInList<AviatorAccidentCRUD>(" proc_AviatorAccidentIncident_CRUD  @procid ='" + procid + "',    @AviatorAccidentIncident_ID ='" + model.AviatorAccidentIncident_ID + "',  @Aviator_ID ='" + model.Aviator_ID + "',  @Aircraft_ID ='" + model.Aircraft_ID + "',    @UnitName = '" + SessionManager.UnitName+ "', @AccidentCat='" + model.AccidentCat + "', @DateOfAccidentIncident='" + model.DateOfAccidentIncident + "', @PlaceOfAccidentIncident ='" + model.PlaceOfAccidentIncident + "',  @DetailsOfAccidentIncident ='" + model.DetailsOfAccidentIncident + "', @Blameworthy = '" + model.Blameworthy + "', @UserId = '" + Convert.ToInt16(SessionManager.UserIntId) + "' ").ToList();
            return data;
        }


        public IList<AviatorAccidentCRUD> AviatorAccidentSubmit(string submit, int ID)
        {
            var data = GetDataInList<AviatorAccidentCRUD>(" proc_AviatorAccidentSubmit @ProcId ='" + submit + "', @AviatorAccidentIncident_ID='" + ID + "' ").ToList();
            return data;

        }
        #endregion


        #region Aviator Special Qualification
        public IList<AviatorSpecialQualCRUD> AviatorSpecialQualification(int procid, AviatorSpecialQualCRUD model)
        {
            var data = GetDataInList<AviatorSpecialQualCRUD>("proc_AviatorSpecialQual_CRUD @procId='" + procid + "',@AviatorSpecialQual_ID='" + model.AviatorSpecialQual_ID + "',@Aviator_ID='" + model.Aviator_ID + "',@SpecialQual_ID='" + model.SpecialQual_ID + "' ,@SpecialQualDate='"+model.SpecialQualDate+"' ,@Validation='" + model.Validation + "'  ,@ValidationDate='" + model.ValidationDate + "'  ,@CounterValidation='" + model.CounterValidation + "'  ,@CounterValidationDate='" + model.CounterValidationDate + "'  ,@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='"+SessionManager.UnitName+"'").ToList();
            return data;
           
        }
        public IList<AviatorSpecialQualCRUD> SubmitAviatorSpecialQual(string procid, string Query)

        {

            var data = GetDataInList<AviatorSpecialQualCRUD>("proc_Submit @procId='" + procid + "',@Query='" + Query + "'").ToList();
            return data;
        }



        #endregion

        #region Aviator Appt
        public IList<AviatorApptCRUD> AviatorApptCRUD(int procid, AviatorApptCRUD model)
        {
            var data = GetDataInList<AviatorApptCRUD>("proc_AviatorAppt_CRUD @procId='" + procid + "',@AviatorAppointment_ID='" + model.AviatorAppointment_ID + "',@Aviator_ID='" + model.Aviator_ID + "',@ApptDate='" + model.ApptDate + "' ,@ApptName='"+model.ApptName+"' ,@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName + "'").ToList();
            return data;

        }



        #endregion

        #region Aviator Rank
        public IList<AviatorRankCRUD> AviatorRankCRUD(int procid, AviatorRankCRUD model)
        {
            var data = GetDataInList<AviatorRankCRUD>("proc_AviatorRank_CRUD @procId='" + procid + "',@AviatorRank_ID='" + model.AviatorRank_ID + "',@Aviator_ID='" + model.Aviator_ID + "',@RankDate='" + model.RankDate + "' ,@Rank='"+model.Rank+"',@UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName + "'").ToList();
            return data;

        }



        #endregion


        #region Aviator Contact Details
        public IList<AviatorContactDetailsCRUD> AviatorContactDetailsCRUD(int procid, AviatorContactDetailsCRUD model)
        {
            var data = GetDataInList<AviatorContactDetailsCRUD>("proc_AviatorContactDetails_CRUD @procId='" + procid + "',@AviatorDetailID='" + model.AviatorDetailID + "',@Aviator_ID='" + model.Aviator_ID + "',@MobileNo='" + model.MobileNo + "' ,@LandLineNo ='" + model.LandLineNo + "'   ,@NOK   ='" + model.NOK + "',@RelationWithNok = '"+model.RelationWithNok         +"'    ,@MaritalStatus = '"+model.MaritalStatus+"'      ,@NameOfSpouse = '"+model.NameOfSpouse            +"'      ,@ContactNoOfSpouse = '"+model.ContactNoOfSpouse +"'       ,@EmailOfSpouse = '"+model.EmailOfSpouse  +"'      ,@ResidentalHouseNo = '"+model.ResidentalHouseNo       +"' , @ResidentalVillage_Street = '"+model.ResidentalVillage_Street+"',@ResidentalPostOffice = '"+model.ResidentalPostOffice  +"', @ResidentalTehsil = '"+ model.ResidentalTehsil  +"', @ResidentalDistrict = '"+ model.ResidentalDistrict   +"' , @ResidentalState = '"+model.ResidentalState +"',@ResidentalPincode = '"+model.ResidentalPincode       +"' ,@PermanentHouseNo = '"+model.PermanentHouseNo +"' ,@PermanentVillage_Street = '"+model.PermanentVillage_Street +"'    ,@PermanentPostOffice = '"+model.PermanentPostOffice+"' ,@PermanentTehsil = '"+model.PermanentTehsil+"',@PermanentDistrict = '"+model.PermanentDistrict +"',@PermanentState = '"+model.PermanentState +"',@PermanentPincode = '"+model.PermanentPincode +"' ,@UserId ='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName + "'").ToList();
            return data;
        }


         public IList<AviatorContactDetailsCRUD> SubmitAviatorContactDetails(string procid, string Query)

        {

            var data = GetDataInList<AviatorContactDetailsCRUD>("proc_Submit @procId='" + procid + "',@Query='" + Query + "'").ToList();
            return data;
        }


        #endregion


        #region Aviator Medical
        public IList<AviatorMedicalCRUD> AviatorMedicalCRUD(int procid, AviatorMedicalCRUD model)
        {
            var data = GetDataInList<AviatorMedicalCRUD>("proc_AviatorMedical_CRUD @procId='" + procid + "',@AviatorMedical_ID='" + model.AviatorMedical_ID + "',@Aviator_ID='" + model.Aviator_ID + "',@TypeOfMedical='" + model.TypeOfMedical + "' ,@MedicalStartDate ='" + model.MedicalStartDate + "'   ,@MedicalEndDate   ='" + model.MedicalEndDate + "',@MedicalCat='"+model.MedicalCat+ "',@MedicalCatDate = '" + model.MedicalCatDate + "'    ,@DurationInWeeks = '" + model.DurationInWeeks + "'      ,@ReCatDueDate = '" + model.ReCatDueDate + "'      ,@MedicalStatus = '" + model.MedicalStatus + "'       ,@Remarks = '" + model.Remarks + "'      ,@UserId ='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName + "'").ToList();
            return data;
        }


        public IList<AviatorMedicalCRUD> SubmitAviatorMedical(string procid, string Query)

        {

            var data = GetDataInList<AviatorMedicalCRUD>("proc_Submit @procId='" + procid + "',@Query='" + Query + "'").ToList();
            return data;
        }


        #endregion


        #region Appx C
        public IList<AppxCCRUD> AppxCCRUD(string procid, AppxCCRUD model)
        {
            var data = GetDataInList<AppxCCRUD>("proc_AppxC @procId='" + procid + "',@AppxCId='" + model.AppxCId + "',@AppxListId='" + model.AppxListId + "' ,@Aviator_ID='" + model.Aviator_ID + "',@TotalCaptHrs='" + model.TotalCaptHrs + "' ,@OnTypeCaptHrs ='" + model.OnTypeCaptHrs + "'   ,@PresentCat   ='" + model.PresentCat + "',@RecomCat = '" + model.RecomCat + "'   ,@PresentIR   ='" + model.PresentIR + "',@RecomIR = '" + model.RecomIR + "',@UserId ='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName + "'").ToList();
            return data;
        }
       
        #endregion

        #region Appx List
        public IList<AppxListCRUD> AppxListCRUD(string procid, AppxListCRUD model)
        {
            var data = GetDataInList<AppxListCRUD>("proc_AppxList_CRUD @procId='" + procid + "',@AppxListId='" + model.AppxListId + "',@FromDate='" + model.FromDate + "' ,@ToDate ='" + model.ToDate + "'   , @UpToFlyingHrsDate = '" + model.UpToFlyingHrsDate + "'  , @AppxType = '" + model.AppxType + "'     ,@UserId ='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName + "'").ToList();
            return data;
        }


        public IList<AppxListCRUD> AppxListSubmit(string submit, int AppxListId)
        {
            var data = GetDataInList<AppxListCRUD>(" proc_AppxListSubmit @ProcId ='" + submit + "', @AppxListId ='" + AppxListId + "' ").ToList();
            return data;

        }
        #endregion

        #region List
        public IList<AviatorCRUD> GetAviatorList()
        {
            var data = GetDataInList<AviatorCRUD>(" proc_GetDataByRoles  @UserId = '" + Convert.ToInt16(SessionManager.UserIntId) + "' ").ToList();
            return data;
      
        }
        public IList<AviatorCRUD> GetPostingAviatorList()
        {
            var data = GetDataInList<AviatorCRUD>(" proc_GetDataByRolesForPosting  @UserId = '" + Convert.ToInt16(SessionManager.UserIntId) + "',@procid='" + 1+ "' ").ToList();
            return data;

        }

        public IList<UnitCRUD> GetPostingUnitList()
        {
            var data = GetDataInList<UnitCRUD>(" proc_GetDataByRolesForPosting  @UserId = '" + Convert.ToInt16(SessionManager.UserIntId) + "',@procid='"+2+"' ").ToList();
            return data;

        }
        #endregion

        #region

        public IList<PostingAviator> PostingAviatorCRUD (int procid, PostingAviator model)
        {


            var data = GetDataInList<PostingAviator>("proc_AviatorPosting_CRUD @procId='" + procid + "',@AviatorPosting_ID= '"+model.AviatorPosting_ID+"',@Aviator_ID ='"+model.Aviator_ID+"', @PostingAuth='"+model.PostingAuth+"',@PostingFromUnit='"+ (SessionManager.UnitName).ToString()+ "', @SOS='"+ model.SOS+ "',@SORS='"+ model.SORS+ "', @PostingToUnit='"+ model.PostingToUnit+ "', @TOS='"+ model.TOS+ "',@TORS='"+ model.TORS+ "',@PostingType='"+ model.PostingType+ "',    @PostingInDate='"+model.PostingInDate+"',@UserId ='"+ Convert.ToInt16(SessionManager.UserIntId) + "'").ToList();
            return data;
        }

        public IList<PostingAviator> AviatorPostingIn(int procid, PostingAviator model)
        {
 

            var data = GetDataInList<PostingAviator>("porc_PostingInAviator @procId='"+ procid + "',@UnitName='"+SessionManager.UnitName.ToString()+ "',@AviatorPosting_ID='"+model.AviatorPosting_ID+"' ").ToList();
            return data;
        }
        #endregion


        #endregion AA7
        #region     GEB


        public IList<CommandId> CommandId()
        {
            var data = GetDataInList<CommandId>("proc_BrigAvnId").ToList();
            return data;

        }
        public IList<GEBLetter> GEBLetter_CRUD(int procid,GEBLetter model)
        {
            var data = GetDataInList<GEBLetter>("proc_GEBLetter_CRUD @procId='"+procid+ "',@GEBLetterId='"+model.GEBLetterId+"', @FromDate='"+ model.FromDate+ "',@ToDate='"+ model.ToDate+ "',@Comd='"+ model.Comd+ "',@UserId ='" + Convert.ToInt16(SessionManager.UserIntId) + "'").ToList();
            return data;
      
        }

        public IList<LetterForwardedGEB> GEBListForGSO(int id,int userintId)
        {

            var data = GetDataInList<LetterForwardedGEB>(" proc_GEBListForSqn @GEBLetterId ='" + id + "',@userId='" + Convert.ToInt16(userintId) + "' ").ToList();
            return data;

        }

        public IList<GEBLetter> SubmitGEBLetter(string submit, int GEBLetterId,int comdId,string xml)
        {
            var data = GetDataInList<GEBLetter>(" proc_GEBLetterSubmit @GEBLetterId ='" + GEBLetterId + "', @procId ='" + submit + "' ,@ComdId='"+ comdId + "',@UserId='"+Convert.ToInt16(SessionManager.UserIntId)+ "',@xml='"+ xml.ToString()+ "'").ToList();
            return data;

        }

        public IList<LetterForwardedGEB> LetterForwardedListGEB( string procid, int LetterForwardedId)
        {
            var data = GetDataInList<LetterForwardedGEB>("AddAviatorForGEB @procId ='" + procid + "',@LetterForwardedId='" + LetterForwardedId + "',@UnitName='" + SessionManager.UnitName + "',@userId='" + Convert.ToInt16(SessionManager.UserIntId) + "'").ToList();
            return data;

        }

        public IList<AviatorCRUD> AviatorListNotifyUnit(string procid,int id)
        {
            var data = GetDataInList<AviatorCRUD>("AddAviatorForGEB @procId ='" + procid + "',@LetterForwardedId='" + id + "',@UnitName='" + SessionManager.UnitName + "',@userId='" + Convert.ToInt16(SessionManager.UserIntId) + "'").ToList();
            return data;

        }
        public IList<LetterForwardedGEB> UserGEBList(string procid, int LetterForwardedId)
        {
            var data = GetDataInList<LetterForwardedGEB>("proc_LetterForwardedList @procId ='" + procid + "',@LetterForwardedId='" + LetterForwardedId + "',@UnitName='" + SessionManager.UnitName + "',@userId='" + Convert.ToInt16(SessionManager.UserIntId) + "'").ToList();
            return data;

        }
        public IList<AviatorCRUD> SubmitGEBList(string submit, int LetterForwardedId)
        {
            var data = GetDataInList<AviatorCRUD>(" proc_SubmitGEBList @ProcId ='" + submit + "', @LetterForwardedId ='" + LetterForwardedId + "',@userId='"+Convert.ToInt16(SessionManager.UserIntId)+"',@UnitName='"+SessionManager.UnitName.ToString()+"' ").ToList();

          
            return data;

        }
        public IList<LetterForwardedGEB> GEBListForSqn(int id)
        {
             
            var data = GetDataInList<LetterForwardedGEB>(" proc_GEBListForSqn @GEBLetterId ='" + id + "',@userId='"+Convert.ToInt16(SessionManager.UserIntId) +"' ").ToList();
            return data;

        }

        public IList<LetterForwardedGEB> EditUpdateGEB(int procid,LetterForwardedGEB model)
        {

            var data = GetDataInList<LetterForwardedGEB>("proc_EditUpdateGEBDetails @procId='"+ procid + "',@FinalAppxId='  "+model.FinalAppxId+" ',@LetterForwardedId = '"+model.LetterForwardedId+"',@Aviator_ID='"+model.Aviator_ID +"',@Rank='"+model.Rank+"',@PresentCatIR='"+model.PresentCatIR+"',@PresentCatIRDate='  "+model.PresentCatIRDate+"',@PresentCatIRType='"+model.PresentCatIRType+"',@TypesIfAny='"+model.TypesIfAny+"', @SplQul='"+model.SplQul+"',@AppearingFor='"+model.AppearingFor+"',@DayHrsLastThreeMonth='"+model.DayHrsLastThreeMonth + "',@NighHrsLastSixMonth = '"+model.NighHrsLastSixMonth + " ',@AircraftType = '"+model.AircraftType +"',@QfiCat = '"+model.QfiCat+"',@QfiDate='"+model.QfiDate+"',@TotalInstHrs='"+model.TotalInstHrs+"',@CheckAviatorEndorsmentAwardedOn='"+model.CheckAviatorEndorsmentAwardedOn+"',@AwardByComd='"+model.AwardByComd+"',@TotalCptHrsPresentTypeDay='"+model.TotalCptHrsPresentTypeDay+"',@TotalCptHrsPresentTypeNight='"+model.TotalCptHrsPresentTypeNight+"',@OnHelicoptorDay='"+model.OnHelicoptorDay+"',@OnHelicoptornight='"+model.OnHelicoptornight+"',@IMCDayHrs='"+model.IMCDayHrs+"',@IMCNightHrs='"+model.IMCNightHrs+" ',@CaptHrsDayOnAllTypes='"+model.CaptHrsDayOnAllTypes+"',@CaptHrsNightOnAllTypes='"+model.CaptHrsNightOnAllTypes +"',@RemarksDay='"+model.RemarksDay + " ',@RemarksNight='"+model.RemarksNight+"',@RecomForCat='"+model.RecomForCat+"',@RecomForIR='"+model.RecomForIR+"',@RemarksAppearing='"+model.RemarksAppearing+"', @UserId='"+ Convert.ToInt16(SessionManager.UserIntId) +"'").ToList();
            return data;
        }


       
        public IList<ImportData> CreateGEBForNotifyUnit(int procid ,int Aviator_ID, int LetterForwardedId)
        {           

            var data = GetDataInList<ImportData>("CreateGEBForNotifyUnit @procid='"+ procid + "', @Aviator_ID='" + Aviator_ID + "',@LetterForwardedId='" + LetterForwardedId + "',@userId='"+Convert.ToInt16(SessionManager.UserIntId) +"'").ToList();
            return data;
        }


        #region Appx Flg Hrs
        public IList<AppxFFlgHrs> AppxFFlgHrs(int procid, AppxFFlgHrs model)
        {
            var data = GetDataInList<AppxFFlgHrs>("proc_AppxFFlgHrs_CRUD @procId='" + procid + "',@AppxF_FlyingDetailId='" + model.AppxF_FlyingDetailId + "',@AppxFId='" + model.AppxFId + "' ,@AircraftType='" + model.AircraftType + "' , @DayDualHr='" + model.DayDualHr + "' ,@DayCaptainHr='" + model.DayCaptainHr + "' , @NightDualHr='" + model.NightDualHr + "' , @NightCaptainHr='" + model.NightCaptainHr + "' , @UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "'").ToList();
            return data;
        }
        public IList<AppxFIntsrExp> AppxFIntsrExp(int procid, AppxFIntsrExp model)
        {    
            var data = GetDataInList<AppxFIntsrExp>("proc_AppxFInstrExp_CRUD @procId='" + procid + "',@AppxF_InstrExpId='" + model.AppxF_InstrExpId + "',@AppxFId='" + model.AppxFId + "' ,@AircraftType='" + model.AircraftType + "' , @CatHeld='" + model.CatHeld + "' ,@DateOfAward='" + model.DateOfAward + "' , @InstrDayHrs='" + model.InstrDayHrs + "' , @InstrNightHrs='" + model.InstrNightHrs + "' , @UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "'").ToList();
            return data;
        }
        public IList<AppxGFlgHrs> AppxGFlgHrs(int procid, AppxGFlgHrs model)
        {
            var data = GetDataInList<AppxGFlgHrs>("proc_tbl_AppxGFlyingHrs_CRUD @procId='" + procid + "',@AppxG_FlyingDetailId='" + model.AppxG_FlyingDetailId + "',@AppxGId='" + model.AppxGId + "' ,@AircraftType='" + model.AircraftType + "' , @DayCaptainHr='" + model.DayCaptainHr + "' ,@NightCaptainHr='" + model.NightCaptainHr + "', @UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "'").ToList();
            return data;
        }
        #endregion

        #endregion

        #region

        public IList<ImportResult> CheckXML(int procid, string xmldata)
        {
            var data = GetDataInList<ImportResult>("proc_CheckXML @procid='" + procid + "',@xml='" + xmldata + "' ").ToList();
            return data;

        }

        public IList<ImportResult> ReadXML( int procid, string xmldata)
        {
            var data = GetDataInList<ImportResult>("proc_GetXMLData @procid='"+ procid + "',@xml='"+xmldata+"' ").ToList();
            return data;
        }

        #endregion
       
        public IList<LetterForwardedGEB> GEBDetailsForSqnCdr(int GEBLetterId, string UnitName)
        {
            
            var data = GetDataInList<LetterForwardedGEB>("proc_GEBListOfFltForSqnCdr @UnitName='" + UnitName + "',@GEBLetterId='" + GEBLetterId+ "'").ToList();
            return data;
        }



        public IList<GEBLetterForwardedForUnit> GEBLetterForwardedForUnit(int cmdid,int id)

        {
            


            var data = GetDataInList<GEBLetterForwardedForUnit>("proc_GEBLetterForwardedForUnit @UserId='" + Convert.ToInt16(SessionManager.UserIntId)+ "',@comid='" + cmdid + "', @gebid='"+id+"' ").ToList();
      
            return data;
        }



        public IList<GEBLetterForwardedForUnit> GEBLetterForwardedForUnitList( int cmdid, int id)

        {



            var data = GetDataInList<GEBLetterForwardedForUnit>("proc_GEBLetterForwardedForUnitList  @UserId='" + Convert.ToInt16(SessionManager.UserIntId) + "',@comid='" + cmdid + "', @gebid='" + id + "' ").ToList();

            return data;
        }



        public IList<AppxFPerformance> UpdateAppxFPerFormence(int procid,AppxFPerformance model)
        {
            var data=GetDataInList<AppxFPerformance>("AppxFPerformance_CRUD @procid='"+procid+"', @AppxFPerformance_ID='" + model.AppxFPerformance_ID +"',@AppxFId='"+model.FinalAppxId +"',@ExaminingAuth='"+model.ExaminingAuth +"',@ExaminedOnType='"+model.ExaminedOnType +"',@DateOfExam='"+model.DateOfExam +"',@PlaceOfExam='"+model.PlaceOfExam +"',@FlgAbilityPercentage='"+model.FlgAbilityPercentage +"',@FlgAbilityStandard='"+model.FlgAbilityStandard +"',@FlgInstrAbilityPercentage='"+model.FlgInstrAbilityPercentage+"',@FlgInstrAbilityStandard= '"+model.FlgInstrAbilityStandard +"',@GrdSubInstrAbilityPercentage='"+model.GrdSubInstrAbilityPercentage +"',@GrdSubInstrAbilityStandard='"+model.GrdSubInstrAbilityStandard +"',@SplKnowledgePercentage='"+model.SplKnowledgePercentage +"',@SplKnowledgeStandard='"+model.SplKnowledgeStandard +"',@OverallPerformancePercentage='"+model.OverallPerformancePercentage +"',@OverallPerformanceStandard='"+model.OverallPerformanceStandard +"',@RecommendInstrCat='"+model.RecommendInstrCat +"',@RecommendOnType='"+model.RecommendOnType +"',@RecommendOnDate='"+model.RecommendOnDate +"',@NameOfExaminer='"+model.NameOfExaminer +"',@RankOfExaminer='"+model.RankOfExaminer +"',@ApptOfExaminer='"+model.ApptOfExaminer +"',@ApprovedInstrCat ='"+model.ApprovedInstrCat +"',@ApprovedOnType='"+model.ApprovedOnType +"',@ApprovedOnDate='"+model.ApprovedOnDate +"',@ApprovedNameOfDte='"+model.ApprovedNameOfDte +"',@ApprovedRankOfDte='"+model.ApprovedRankOfDte +"',@ApprovedApptOfDte='"+model.ApprovedApptOfDte +"',@UserId='"+Convert.ToString(SessionManager.UserIntId) +"' ").ToList();
            return data;
        }

        public IList<AppxGPerformance> UpdateAppxGPerFormence(int procid, AppxGPerformance model)
        {
            var data = GetDataInList<AppxGPerformance>("AppxGPerformance_CRUD @procid='" + procid + "',@AppxGPerformance_ID='" + model.AppxGPerformance_ID + "', @FinalAppxId= '" + model.FinalAppxId + "', @ExaminingAuth ='" + model.ExaminingAuth + "',@ExaminedOnType ='" + model.ExaminedOnType + "', @DateOfExam ='" + model.DateOfExam + "',@PlaceOfExam ='" + model.PlaceOfExam + "', @FlgAbilityPercentage='" + model.FlgAbilityPercentage + "',@FlgAbilityStandard ='" + model.FlgAbilityStandard + "',@FlgInstrAbilityPercentage='" + model.FlgInstrAbilityPercentage + "', @FlgInstrAbilityStandard ='" + model.FlgInstrAbilityStandard + "',@GrdSubInstrAbility ='" + model.GrdSubInstrAbility + "', @GrdSubInstrAbilityStandards ='" + model.GrdSubInstrAbilityStandards + "',@RecommendCheckAviator ='" + model.RecommendCheckAviator + "',@RecommendOnType ='" + model.RecommendOnType + "',@RecommendDate ='" + model.RecommendDate + "',@NameOfExaminer ='" + model.NameOfExaminer + "',@RankOfExaminer ='" + model.RankOfExaminer + "',@ApptOfExaminer ='" + model.ApptOfExaminer + "',@ApprovedCheckAviator ='" + model.ApprovedCheckAviator + "',@ApprovedOnType ='" + model.ApprovedOnType + "', @ApprovedOnDate ='" + model.ApprovedOnDate + "', @ApprovedNameOfDte ='" + model.ApprovedNameOfDte + "',@ApprovedRankOfDte ='" + model.ApprovedRankOfDte + "',@ApprovedApptOfDte ='" + model.ApprovedApptOfDte + "',@UserId='" + Convert.ToString(SessionManager.UserIntId) + "' ").ToList();
            return data;
        }


        public IList<AppxEPerformance> UpdateAppxEPerFormence(int procid, AppxEPerformance model)
        {
            var data = GetDataInList<AppxEPerformance>("AppxEPerformance_CRUD @procid='" + procid +
                "' ,@AppxEPerformance_ID='"+model.AppxEPerformance_ID + "',@FinalAppxId ='" + model.FinalAppxId + "',  @DateOfGEB ='" + model.DateOfGEB + "', @Result ='" + model.Result + "',@Category ='" + model.Category + "',@InstrumentRating ='" + model.InstrumentRating + "',@InstructorCat ='" + model.InstructorCat + "',@GoodShow ='" + model.GoodShow + "',@WarnedFor ='" + model.WarnedFor + "',@SpecialRemarks ='" + model.SpecialRemarks + "',@FlgSubDate ='" + model.FlgSubDate + "',@FlgSubMarks ='" + model.FlgSubMarks + "',@FlgSubRemarks ='" + model.FlgSubRemarks + "',@TacandSplDate ='" + model.TacandSplDate + "', @TacandSplMarks ='" + model.TacandSplMarks + "', @TacandSplRemarks ='" + model.TacandSplRemarks + "',@SplBfgDate ='" + model.SplBfgDate + "',@SplBfgMarks ='" + model.SplBfgMarks + "',@SplBfgRemarks ='" + model.SplBfgRemarks + "',@DayFlgDate ='" + model.DayFlgDate + "',@DayFlgMarks ='" + model.DayFlgMarks + "',@DayFlgRemarks ='" + model.DayFlgRemarks + "',@SplExDate ='" + model.SplExDate + "',@SplExMarks ='" + model.SplExMarks + "',@SplExRemarks ='" + model.SplExRemarks + "',@OpADate ='" + model.OpADate + "',@OpAMarks ='" + model.OpAMarks + "',@OpARemarks ='" + model.OpARemarks + "',@NiFlgDate ='" + model.NiFlgDate + "',@NiFlgMarks ='" + model.NiFlgMarks + "',@NiFlgRemarks ='" + model.NiFlgRemarks + "',@DateOfAward ='" + model.DateOfAward + "', @UserId='" + Convert.ToString(SessionManager.UserIntId) + "' ").ToList();
           return data;
        }
        public IList<AppxF> UpdateAppxF(int procid, AppxF model)
        {

            var data = GetDataInList<AppxF>("AppxF_CRUD @procid='" + procid +"',@AppxFId ='"+model.AppxFId+ "',@FinalAppxId ='" + model.FinalAppxId + "',@AppxFForYear ='" + model.AppxFForYear + "',@InstructoionalCatApplied ='" + model.InstructoionalCatApplied + "',@AircraftType ='" + model.AircraftType + "',@InstructoionalCatIRHeld ='" + model.InstructoionalCatIRHeld + "',@InstructoionalCatIRHeldAircraft ='" + model.InstructoionalCatIRHeldAircraft + "',@InstructoionalCatIRDate ='" + model.InstructoionalCatIRDate + "',@DateofCatAward ='" + model.DateofCatAward + "',@AwardTypeAircraft ='" + model.AwardTypeAircraft + "',@AHI_QFICourseNo ='" + model.AHI_QFICourseNo + "',@DateofCompletion ='" + model.DateofCompletion + "',@QFICatDate ='" + model.QFICatDate + "',@OpInstructionalSyllabusNo ='" + model.OpInstructionalSyllabusNo + "',@OpInstructionalHrs ='" + model.OpInstructionalHrs + "',@OpInstructionalSyllabusComletedOn ='" + model.OpInstructionalSyllabusComletedOn + "',@OpInstructionalSyllabusComletedByArmyNo ='" + model.OpInstructionalSyllabusComletedByArmyNo + "',@OpInstructionalSyllabusComletedByRank ='" + model.OpInstructionalSyllabusComletedByRank + "',@OpInstructionalSyllabusComletedByName ='" + model.OpInstructionalSyllabusComletedByName + "',@ReccommendInstructionalCatIR ='" + model.ReccommendInstructionalCatIR + "',@ReccommendInstructionalCatAircraft ='" + model.ReccommendInstructionalCatAircraft + "', @UserId='" + Convert.ToString(SessionManager.UserIntId) + "' ").ToList();
            return data;
        }

        public IList<AppxG> UpdateAppxG(int procid, AppxG model)



        {

            var data = GetDataInList<AppxG>("AppxG_CRUD @procid='" + procid + "' ,@FinalAppxId ='" + model.FinalAppxId + "',@AppxGForYear ='" + model.AppxGForYear + "',@CheckAviatorEndorsementExp ='" + model.CheckAviatorEndorsementExp + "',@CheckAviatorEndorsementOnAirCraftType ='" + model.CheckAviatorEndorsementOnAirCraftType + "',@CheckAviatorEndorsementExpUnit ='" + model.CheckAviatorEndorsementExpUnit + "',@TotalInstrDayExp ='" + model.TotalInstrDayExp + "',@TotalInstrNightExp ='" + model.TotalInstrNightExp + "',@Syllabus9ACompletedOn ='" + model.Syllabus9ACompletedOn + "',@CompletedByICNo ='" + model.CompletedByICNo + "',@CompletedByRank ='" + model.CompletedByRank + "',@CompletedByName ='" + model.CompletedByName + "',@NoQFIInTheUnit ='" + model.NoQFIInTheUnit + "',@RecomeForCheckAviatorUnit ='" + model.RecomeForCheckAviatorUnit + "',@RecomeForCheckAviatorOnType ='" + model.RecomeForCheckAviatorOnType + "', @UserId='" + Convert.ToString(SessionManager.UserIntId) + "',  @ISRecommendByBrigAvn='"+Convert.ToInt16(model.ISRecommendByBrigAvn) +"', @IsApprovedByGSO  ='"+Convert.ToInt16(model.IsApprovedByGSO) +"'").ToList();
            return data;
        }


        public IList<user> insertUserCert(user user, byte[] cert)
        {
            string st = Encoding.ASCII.GetString(cert);


            // string st = ByteArrayToString(cert);
            var data = GetDataInList<user>("insertCert @userId='" + user.IntId + "',@publicKey='" + st + "'").ToList();
            return data;
        }
        public IList<UserKeyMapping> findPublicKey(UserKeyMapping userKeyMapping)
        {
            var data = GetDataInList<UserKeyMapping>("findPublicKey @userId='" + userKeyMapping.UserId + "'").ToList();
            return data;

        }
        public IList<user> getAllUsers()
        {
            var data = GetDataInList<user>("getAllUsers").ToList();
            return data;
        }


        public IList<LetterForwardedGEB> GenrateAppx(int procid ,int GEBLetterId,string unitname,int userid)
        {
            var data = GetDataInList<LetterForwardedGEB>("proc_GenrateAppx @procId ='" + procid + "', @UnitName='" + unitname + "',@userId='" + userid + "',@GEBLetterId='"+GEBLetterId+"'").ToList();
            return data;
        }


        public IList<LetterForwardedGEB> GenrateNominalRoll(int procid ,int GEBLetterId,string query)
        {
            var data = GetDataInList<LetterForwardedGEB>("procGetNominalRoll @procid='"+procid+"', @GEBLetterId ='" + GEBLetterId + "',@query='"+query+"'").ToList();
            return data;
        }

        public IList<LetterForwardedGEB> GetAppxs(int procId, int FinalAppxId)
        {
            var data = GetDataInList<LetterForwardedGEB>("proc_GetAppxData   @procId ='" + procId + "',@FinalAppxId ='" + FinalAppxId + "'").ToList();
            return data;
        }

        public IList<GEBLetter> SubmitAppx(string submit, int fid)
        {
            var data = GetDataInList<GEBLetter>(" proc_AppxSubmit @FinalAppxID ='" + fid + "', @procId ='" + submit + "' ").ToList();
            return data;        

        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="procid"></param>
        /// <returns></returns>
        /// 

        

        public VieViewAviatorDetails VieViewAviatorDetails(int AviatorId  )    
        {
            VieViewAviatorDetails model = new VieViewAviatorDetails();
            ///Aviatore
            var data1 = GetDataInList<AviatorCRUD>(" proc_VieViewAviatorDetails @procid ='" +1 + "', @Aviator_ID ='" + AviatorId + "', @UserId ='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName + "'").ToList();
            model.ILAviatorCRUD = data1;

            var data2 = GetDataInList<AviatorContactDetailsCRUD>(" proc_VieViewAviatorDetails @procid ='" + 2 + "', @Aviator_ID ='" + AviatorId + "', @UserId ='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName + "'").ToList();
            model.ILAviatorContactDetailsCRUD = data2;


            var data3 = GetDataInList<AviatorCoursesCRUD>(" proc_VieViewAviatorDetails @procid ='" + 3 + "', @Aviator_ID ='" + AviatorId + "', @UserId ='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName + "'").ToList();
            model.ILAviatorCoursesCRUD = data3;


            var data4 = GetDataInList<AviatorHonourAwardsCRUD>(" proc_VieViewAviatorDetails @procid ='" +4 + "', @Aviator_ID ='" + AviatorId + "', @UserId ='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName + "'").ToList();
            model.ILAviatorHonourAwardsCRUD = data4;

            var data5 = GetDataInList<AviatorFlyingHrsCRUD>("proc_VieViewAviatorDetails @procid ='" + 5 + "', @Aviator_ID ='" + AviatorId + "', @UserId ='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName + "'").ToList();
            model.ILAviatorFlyingHrsCRUD = data5;



            var data6 = GetDataInList<AviatorSpecialEqptCRUD>(" proc_VieViewAviatorDetails @procid ='" + 6 + "', @Aviator_ID ='" + AviatorId + "', @UserId ='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName + "'").ToList();
            model.ILAviatorSpecialEqptCRUD = data6;

            var data7= GetDataInList<AviatorSpecialQualCRUD>(" proc_VieViewAviatorDetails @procid ='" + 7 + "', @Aviator_ID ='" + AviatorId + "', @UserId ='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName + "'").ToList();
            model.ILAviatorSpecialQualCRUD = data7;

            var data8 = GetDataInList<AviatorMedicalCRUD>(" proc_VieViewAviatorDetails @procid ='" + 8 + "', @Aviator_ID ='" + AviatorId + "', @UserId ='" + Convert.ToInt16(SessionManager.UserIntId) + "',@UnitName='" + SessionManager.UnitName + "'").ToList();
            model.ILAviatorMedicalCRUD = data8;




            return model;              
            
        }

        #region

        public IList<TransationStrengthReturn> IUDUnitStrReturn(TransationStrengthReturn model,int procid)
        {
            var data = GetDataInList<TransationStrengthReturn>("proc_UnitStrReturn @ProcId='"+procid+"',  @StrId = '" + model.StrId+"', @SUSNo =   '"+model.SUSNo+ "' ,@PosnAs ='" + model.PosnAs + "' , @PresentReturnSerNo =    '" + model.PresentReturnSerNo + "' ,@PresentReturnDate =   '" + model.PresentReturnDate + "' , @LastReturnSerNo =    '" + model.LastReturnSerNo + "' ,@LastReturnDate =   '" + model.LastReturnDate + "'  ,@LastIAFF =   '" + model.LastIAFF + "'  ,@LastIAFFDate =   '" + model.LastIAFFDate + "'  ,@FmnOfUnit =  '" + model.FmnOfUnit + "'   ,@Location =  '" + model.Location + "'   ,@EstNo =   '" + model.EstNo + "'  ,@EstDate =  '" + model.EstDate + "'   ,@CoRemarks =  '" + model.SUSNo + "'   ,@CoCertified =   '" + model.SUSNo + "'  ,@OffrsPostedExcessToEst =  '" + model.CoRemarks + "'   ,@OffrsSOSAndHeldOnSupernumeraryStr =   '" + model.OffrsSOSAndHeldOnSupernumeraryStr + "'  ,@DetailsOfPostingDuesInOffrs =   '" + model.DetailsOfPostingDuesInOffrs + "'  ,@DetailsOfPostingDuesOutOffrs =   '" + model.DetailsOfPostingDuesOutOffrs + "'  ,@PSCQualified =   '" + model.PSCQualified + "'  ,@ReEmpOffrs =     '" + model.ReEmpOffrs + "',@OffrsOnSuperStr =   '" + model.OffrsOnSuperStr + "'  ,@Remarks =   '" + model.Remarks + "'  ,@Month =  '" + model.Month + "'   ,@Year = '" + model.Year + "'    ,@userId = '" + SessionManager.UserId + "',@UnitName='"+SessionManager.UnitName+"' ").ToList();
            return data;

        }

        #endregion
        // GEBDetailsForSqnCdr



        

        #region CheckLoggedIn
        public IList<CheckLoggedIn> CheckLoggedIn(int procid, int IntId,string UserName,string id)
        {
            var data = GetDataInList<CheckLoggedIn>("proc_UpdateLogin @procId='" + procid + "',@intId='" + IntId + "' ,@UserName='"+ UserName + "'  ,@id='"+id+"'").ToList();
            return data;
        }
        #endregion



        public IList<GEBLetter> GEBLetterList(int procid,int GEBLetterId ,string Comd)
        {
            var data = GetDataInList<GEBLetter>("proc_GEBExam @procId='" + procid + "',@GEBLetterId='" + GEBLetterId + "',@Comd='" + Comd + "',@UserId ='" + Convert.ToInt16(SessionManager.UserIntId) + "'").ToList();
            return data;

        }

        public IList<GEBLetter> CancelGEBLetter(int GEBLetterId)
        {
            var data = GetDataInList<GEBLetter>("proc_CancelGEBLetter @GEBLetterId='" + GEBLetterId + "',@UserId ='" + Convert.ToInt16(SessionManager.UserIntId) + "'").ToList();
            return data;

        }


        public int SendForgot(ForgotPasswordViewModel model)
        {

            var  data = GetDataInList<getId>("INSERT INTO [dbo].[forgotPassword]([username],[userId],[superiorId],[createTime])VALUES('"+model.UserName+"','"+model.UserId+"','"+model.superiorId+ "',getDate())SELECT @@IDENTITY    AS 'Identity' ").FirstOrDefault();
            return Convert.ToInt32(data.Identity);
        }

        public int UpdatePassword(int id ,string haspassword)
        {
            var data = GetDataInList<updateId>(" UPDATE AspNetUsers SET PasswordHash = '"+haspassword+"'OUTPUT INSERTED.IntId as 'Identity' WHERE IntId = '"+id+"' ").FirstOrDefault();
            return Convert.ToInt32(data.Identity);
        }

        public int UpdateForgotPasswordTable (int id)
        {
            var data = GetDataInList<updateId>(" UPDATE [forgotPassword] SET [ApprovedBy] = '" + SessionManager.UserId + "', [ApprovedDate]=getDate() OUTPUT INSERTED.Id as 'Identity' WHERE Id = '" + id + "' ").FirstOrDefault();
            return Convert.ToInt32(data.Identity);
        }

        class updateId
        {
            public int Identity { get; set; }
        }
        class getId
        {
            public Decimal Identity { get; set; }
        }




        public List<ForgotPasswordViewModel> GetListResetPassword()
        {
            var data = GetDataInList<ForgotPasswordViewModel>("SELECT fe.id,c.[UserId], c.[ChildId] , c.[UserName], c.[RoleName], c.[EstablishmentFull],fe.[superiorId], fe.[createTime],fe.ApprovedDate FROM [aa7data].[dbo].[Child] c inner join [dbo].[forgotPassword] fe on c.ChildId = fe.userid  where c.UserId = '" + SessionManager.UserIntId+"' and c.ChildId Not In('"+ SessionManager.UserIntId + "')").ToList();
            return data;
        }
        #region  for connection DB 
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
