using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IHSDC.WebApp.Connection;

namespace IHSDC.WebApp.Models
{
    public class AA7Common
    {
        public string AviatorName { get; set; }
        public string PrefixLetter { get; set; }
        public string ANumber { get; set; }
        public string SuffixLetter { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public Int32 UserId { get; set; }
        public bool IsSuccess { get; set; }
        public bool IsExist { get; set; }
        public string Msg { get; set; }
        public string MsgStatus { get; set; }
        public string MidMsg { get; set; }
        public string Validation { get; set; }
        public string ValidationDate { get; set; }
        public string CounterValidation { get; set; }
        public string CounterValidationDate { get; set; }
        public string RoleName { get; set; }
        public string UnitName { get; set; }
        public int Aviator_ID { get; set; }

        public string Col1 { get; set; }
        public string Col2 { get; set; }
        public string Col3 { get; set; }
        public string Col4 { get; set; }

        public string ColContains1 { get; set; }
        public string ColContains2 { get; set; }
        public string ColContains3 { get; set; }
        public string ColContains4 { get; set; }

        public string ColVal1 { get; set; }
        public string ColVal2 { get; set; }
        public string ColVal3 { get; set; }
        public string ColVal4 { get; set; }

    }

    public class ImportResult
    {
        public bool IsSuccess { get; set; }
        public bool IsExist { get; set; }
        public string Msg { get; set; }
        public string MsgStatus { get; set; }
        public string MidMsg { get; set; }
        public string UnitName { get; set; }
    }

    public class AviatorCRUD : AA7Common
    {
        public string ArmyNumber { get; set; }
        public string AviatorRank { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int ArmService_ID { get; set; }
        public string ArmServiceName { get; set; }
        public int Aircraft_ID { get; set; }
        public string AircraftName { get; set; }
        public string DateOfBirth { get; set; }
        public string DateOfSeniority { get; set; }
        public string DateOfWings { get; set; }
        public string DateOfRank { get; set; }
        public string CatCardNo { get; set; }
        public string DateofIssueCatCard { get; set; }
        public bool IsGEB { get; set; }
        public int FinalAppxId { get; set; }
        public int LetterForwardedId { get; set; }
        public string PresentCatIR { get; set; }
        public string DateOfCommision { get; set; }


        public IList<AviatorCRUD> ILAviatorCRUD { get; set; }
    }
    public class AviatorCoursesCRUD : AA7Common
    {
        public int AviatorCourses_ID { get; set; }

        public int Course_ID { get; set; }
        public string CourseName { get; set; }
        public string CourseSerialNumber { get; set; }
        public string CourseStartDate { get; set; }
        public string CourseEndDate { get; set; }
        public string CourseGrading { get; set; }
        public string InstructorGrading { get; set; }
        public string Special_Award { get; set; }
        public string Notes { get; set; }
        public string CourseInstitute { get; set; }
        public string CoursePlace { get; set; }

        

        public IList<AviatorCoursesCRUD> ILAviatorCoursesCRUD { get; set; }
    }
    public class AviatorHonourAwardsCRUD : AA7Common
    {
        public int AviatorHonourAwards_ID { get; set; }
        public int HonourAward_ID { get; set; }
        public string HonourAwardsDate { get; set; }
        public string HonourAwardsPlace { get; set; }
        public string HonourAwardName { get; set; }
        public string Remarks { get; set; }
        public IList<AviatorHonourAwardsCRUD> ILAviatorHonourAwardsCRUD { get; set; }
    }
    public class AviatorFlyingHrsCRUD : AA7Common
    {
        public int AviatorFlyingHrs_ID { get; set; }
        public int Aircraft_ID { get; set; }
        public string Year { get; set; }
        public decimal DayDualHrs { get; set; }     
        public decimal DaySoloHrs { get; set; }
        public decimal DayCopilotHrs { get; set; }
        public decimal NightDualHrs { get; set; }
        public decimal NightSoloHrs { get; set; }
        public decimal NightCopilotHrs { get; set; }
        public decimal NVGExp { get; set; }
        public decimal WSOExp { get; set; }
        public decimal IF_Actual { get; set; }
        public decimal InstrDayHrs { get; set; }
        public decimal InstrNightHrs { get; set; }
        public decimal IMCHrs { get; set; }
        public decimal SIFHrs { get; set; }
        public decimal ALHSmlHrs { get; set; }
        public string Month { get; set; }
        public string AircraftName { get; set; }
        public string ListYear { get; set; }
        public IList<AviatorFlyingHrsCRUD> ILAviatorFlyingHrsCRUD { get; set; }
        //public string DayDualHrsStr { get { return ConvertFlyingHrs(DayDualHrs); } }
        //public string DaySoloHrsStr { get { return ConvertFlyingHrs(DaySoloHrs); } }
        //public string DayCopilotHrsStr { get { return ConvertFlyingHrs(DayCopilotHrs); } }
        //public string NightDualHrsStr { get { return ConvertFlyingHrs(NightDualHrs); } }
        //public string NightSoloHrsStr { get { return ConvertFlyingHrs(NightSoloHrs); } }
        //public string NightCopilotHrsStr { get { return ConvertFlyingHrs(NightCopilotHrs); } }
        //public string NVGExpStr { get { return ConvertFlyingHrs(NVGExp); } }
        //public string WSOExpStr { get { return ConvertFlyingHrs(WSOExp); } }
        //public string IF_ActualStr { get { return ConvertFlyingHrs(IF_Actual); } }
        //public string InstrDayHrsStr { get { return ConvertFlyingHrs(InstrDayHrs); } }
        //public string InstrNightHrsStr { get { return ConvertFlyingHrs(InstrNightHrs); } }
        //public string IMCHrsStr { get { return ConvertFlyingHrs(IMCHrs); } }
        //public string SIFHrsStr { get { return ConvertFlyingHrs(SIFHrs); } }
        //public string ALHSmlHrsStr { get { return ConvertFlyingHrs(ALHSmlHrs); } }



        public string ConvertFlyingHrs(decimal hrs)
        {
            string data = hrs.ToString();
            string[] parts = data.Split('.');
            if(parts[0].Length==1)
            {
                parts[0] = "0" + parts[0].ToString();
            }
            return parts[0] + ":" + parts[1];
        }
    }


  

    public class AviatorAccidentCRUD : AA7Common
    {
        public int AviatorAccidentIncident_ID { get; set; }
        public int Aircraft_ID { get; set; }
        public string AircraftName { get; set; }
        public string AccidentCat { get; set; }
        public string DateOfAccidentIncident { get; set; }
        public string PlaceOfAccidentIncident { get; set; }
        public string DetailsOfAccidentIncident { get; set; }
        public string Blameworthy { get; set; }
        public IList<AviatorAccidentCRUD> ILAviatorAccidentCRUD { get; set; }
    }

    public class AviatorSpecialEqptCRUD : AA7Common
    {
        public int AviatorSpecialEqpt_ID { get; set; }
        public int SpecialEqpt_ID { get; set; }
        public string SpecialEqptDate { get; set; }
        public string SpecialEqptName { get; set; }
        public IList<AviatorSpecialEqptCRUD> ILAviatorSpecialEqptCRUD { get; set; }
    }

    public class AviatorSpecialQualCRUD : AA7Common
    {
        public int AviatorSpecialQual_ID { get; set; }
        public int SpecialQual_ID { get; set; }
        public string SpecialQualName { get; set; }
        public string SpecialQualDate { get; set; }
        public IList<AviatorSpecialQualCRUD> ILAviatorSpecialQualCRUD { get; set; }
    }

    public class AviatorApptCRUD : AA7Common
    {
        public int AviatorAppointment_ID { get; set; }
        public string ApptDate { get; set; }
        public string ApptName { get; set; }
        public IList<AviatorApptCRUD> ILAviatorApptCRUD { get; set; }
    }

    public class AviatorRankCRUD : AA7Common
    {
        public int AviatorRank_ID { get; set; }
        public string RankDate { get; set; }
        public string Rank { get; set; }
        public IList<AviatorRankCRUD> ILAviatorRankCRUD { get; set; }
    }

    public class AviatorContactDetailsCRUD : AA7Common
    {
        public int AviatorDetailID { get; set; }
        public string MobileNo { get; set; }
        public string LandLineNo { get; set; }
        public string NOK { get; set; }
        public string RelationWithNok { get; set; }
        public string MaritalStatus { get; set; }
        public string NameOfSpouse { get; set; }
        public string ContactNoOfSpouse { get; set; }
        public string EmailOfSpouse { get; set; }
        public string ResidentalHouseNo { get; set; }
        public string ResidentalVillage_Street { get; set; }
        public string ResidentalPostOffice { get; set; }
        public string ResidentalTehsil { get; set; }
        public string ResidentalDistrict { get; set; }
        public string ResidentalState { get; set; }
        public string ResidentalPincode { get; set; }
        public string PermanentHouseNo { get; set; }
        public string PermanentVillage_Street { get; set; }
        public string PermanentPostOffice { get; set; }
        public string PermanentTehsil { get; set; }
        public string PermanentDistrict { get; set; }
        public string PermanentState { get; set; }
        public string PermanentPincode { get; set; }
        public IList<AviatorContactDetailsCRUD> ILAviatorContactDetailsCRUD { get; set; }
    }

    public class AviatorMedicalCRUD : AA7Common
    {
        public int AviatorMedical_ID { get; set; }
        public string TypeOfMedical { get; set; }
        public string MedicalStartDate { get; set; }
        public string MedicalEndDate { get; set; }
        public string MedicalCat { get; set; }
        public string MedicalCatDate { get; set; }
        public int DurationInWeeks { get; set; }
        public string ReCatDueDate { get; set; }
        public string MedicalStatus { get; set; }
        public string Remarks { get; set; }

        public IList<AviatorMedicalCRUD> ILAviatorMedicalCRUD { get; set; }
    }


    public class AppxCCRUD : AA7Common
    {
        public int AppxCId { get; set; }
        public int AppxListId { get; set; }
        public string PresentCat { get; set; }
        public string PresentIR { get; set; }
        public string PresentCatIR { get; set; }
        public string RecomCat { get; set; }
        public string RecomIR { get; set; }
        public string RecomOfCO { get; set; }
        public int TotalCaptHrs { get; set; }
        public int OnTypeCaptHrs { get; set; }
        public IList<AppxCCRUD> ILAppxCCRUD { get; set; }
    }
    public class AppxListCRUD : AA7Common
    {
        public int AppxListId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string AppxType { get; set; }
        public string UpToFlyingHrsDate { get; set; }
        public IList<AppxListCRUD> ILAppxListCRUD { get; set; }
    }

    public class GEBLetterForwardedForUnit
    {
        public int ChildId { get; set; }
        public string UserName { get; set; }
        public bool checkbox { get; set; }
        public string RoleName { get; set; }
        public string TypeOfUnit { get; set; }
        public bool IsSubmit { get; set; }
        public bool IsNotification { get; set; }

    }

    public class GEBLetter : AA7Common
    {
        public int GEBLetterId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public int Comd { get; set; }
        public string BrigAvnName { get; set; }
        public string SubmitSqnCdr { get; set; }
        public string Status { get; set; }
        public string TypeOfUnit { get; set; }
        public string LetterForwarded { get; set; }
        public string LetterForwardedDate { get; set; }
        public string SubmitByComd { get; set; }
        public string ComdSubmitDate { get; set; }
        public int LetterFwdSqnId { get; set; }
        public bool IsSubmit { get; set; }
        public int CountChildBrig { get; set; }
        public bool IsNotification
        {
            get; set;
        }
        public IList<GEBLetter> ILGEBLetter { get; set; }
        public IList<GEBLetterForwardedForUnit> IlGEBLetterForwardedForUnit { get; set; }
    }

    public class LetterForwardedGEB : GEBLetter
    {

        public int CountOfGEBList { get; set; }
        public int AvCount { get; set; }
        public int LetterForwardedId { get; set; }
        public int ChildId { get; set; }
        public string SubmitByFltCdr { get; set; }
        public string SubmitByFltCdrDate { get; set; }
        public string SubmitSqnCdrDate { get; set; }
        public string SubmitBy2IC { get; set; }
        public string SubmitBy2ICDate { get; set; }
        public int FinalAppxId { get; set; }
        public string Rank { get; set; }
        public string PresentCat { get; set; }
        public string PresentIR { get; set; }
        public string PresentCatIRDate { get; set; }
        public string PresentCatIRType { get; set; }
        public string TypesIfAny { get; set; }
        public string SplQul { get; set; }
        public string AppearingFor { get; set; }
        public decimal DayHrsLastThreeMonth { get; set; }
        public decimal NighHrsLastSixMonth { get; set; }
        public string AircraftType { get; set; }
        public string QfiCat { get; set; }
        public string QfiDate { get; set; }
        public decimal TotalInstHrs { get; set; }
        public string CheckAviatorEndorsmentAwardedOn { get; set; }
        public string AwardByComd { get; set; }
        public decimal TotalCptHrsPresentTypeDay { get; set; }
        public decimal TotalCptHrsPresentTypeNight { get; set; }
        public decimal OnHelicoptorDay { get; set; }
        public decimal OnHelicoptornight { get; set; }
        public string RemarksDay { get; set; }
        public string RemarksNight { get; set; }
        public string RecomForCat { get; set; }
        public string RecomForIR { get; set; }
        public string RemarksAppearing { get; set; }
        public string ArmServiceName { get; set; }
        public string AircraftName { get; set; }
        public decimal IMCDayHrs { get; set; }
        public decimal IMCNightHrs { get; set; }
        public decimal CaptHrsDayOnAllTypes { get; set; }
        public decimal CaptHrsNightOnAllTypes { get; set; }
        public string PresentCatIR { get; set; }
        public string RecomForCatIR { get; set; }
        public bool IsAppxF { get; set; }
        public bool IsAppxG { get; set; }
        public bool IsRejectBrig { get; set; }
        public bool IsRejectGSO { get; set; }
        public bool? IsApprovedByGSO { get; set; }
        public string  GEBType { get; set; }

        //  public int LetterFwdSqnId { get; set; }
        //public bool IsSubmit { get; set; }
        //public bool IsNotification
        //{
        //    get; set;
        //}


        public IList<LetterForwardedGEB> ILLetterForwardedGEB { get; set; }
        public string ConvertFlyingHrs(decimal hrs)
        {
            string data = hrs.ToString();
            string[] parts = data.Split('.');
            if (parts[0].Length == 1)
            {
                parts[0] = "0" + parts[0].ToString();
            }
            return parts[0] + ":" + parts[1];
        }
    }


    public class PostingAviator : AA7Common
    {
        public int AviatorPosting_ID { get; set; }
        public string PostingAuth { get; set; }
        public int? PostingFromUnit { get; set; }
        public string SOS { get; set; }
        public string SORS { get; set; }
        public int PostingToUnit { get; set; }
        public string PostingToUnitName { get; set; }
        public string PostingFromUnitName { get; set; }
        public string TOS { get; set; }
        public string TORS { get; set; }
        public string PostingType { get; set; }
        public string PostingInDate { get; set; }
        public IList<PostingAviator> ILPostingAviator { get; set; }
    }


    public class ImportData : AA7Common
    {
        public HttpPostedFileWrapper HttpPostedFileWrapper { get; set; }
    }

    public class AppxGPerformance : LetterForwardedGEB
    {
        public int AppxGPerformance_ID { get; set; }
        public string ExaminingAuth { get; set; }
        public string ExaminedOnType { get; set; }
        public string DateOfExam { get; set; }
        public string PlaceOfExam { get; set; }
        public int FlgAbilityPercentage { get; set; }
        public string FlgAbilityStandard { get; set; }
        public int FlgInstrAbilityPercentage { get; set; }
        public string FlgInstrAbilityStandard { get; set; }
        public string GrdSubInstrAbility { get; set; }
        public string GrdSubInstrAbilityStandards { get; set; }
        public string RecommendCheckAviator { get; set; }
        public string RecommendOnType { get; set; }
        public string RecommendDate { get; set; }
        public string NameOfExaminer { get; set; }
        public string RankOfExaminer { get; set; }
        public string ApptOfExaminer { get; set; }
        public string ApprovedCheckAviator { get; set; }
        public string ApprovedOnType { get; set; }
        public string ApprovedOnDate { get; set; }
        public string ApprovedNameOfDte { get; set; }
        public string ApprovedRankOfDte { get; set; }
        public string ApprovedApptOfDte { get; set; }
        public AppxG AppxG { get; set; }
        public AppxGFlgHrs AppxGFlgHrs { get; set; }
        public IList<AppxGFlgHrs> ILAppxGFlgHrs { get; set; }

    }
    public class AppxFPerformance : LetterForwardedGEB
    {
        public int AppxFPerformance_ID { get; set; }
        public int AppxFId { get; set; }
        public string ExaminingAuth { get; set; }
        public string ExaminedOnType { get; set; }
        public string DateOfExam { get; set; }
        public string PlaceOfExam { get; set; }
        public int FlgAbilityPercentage { get; set; }
        public string FlgAbilityStandard { get; set; }
        public int FlgInstrAbilityPercentage { get; set; }
        public string FlgInstrAbilityStandard { get; set; }
        public int GrdSubInstrAbilityPercentage { get; set; }
        public string GrdSubInstrAbilityStandard { get; set; }
        public int SplKnowledgePercentage { get; set; }
        public string SplKnowledgeStandard { get; set; }
        public int OverallPerformancePercentage { get; set; }
        public string OverallPerformanceStandard { get; set; }
        public string RecommendInstrCat { get; set; }
        public string RecommendOnType { get; set; }
        public string RecommendOnDate { get; set; }
        public string NameOfExaminer { get; set; }
        public string RankOfExaminer { get; set; }
        public string ApptOfExaminer { get; set; }
        public string ApprovedInstrCat { get; set; }
        public string ApprovedOnType { get; set; }
        public string ApprovedOnDate { get; set; }
        public string ApprovedNameOfDte { get; set; }
        public string ApprovedRankOfDte { get; set; }
        public string ApprovedApptOfDte { get; set; }
        public AppxF appxF { get; set; }
        public AppxFFlgHrs appxFFlgHrs { get; set; }
        public AppxFIntsrExp appxFIntsrExp { get; set; }
        public IList<AppxFFlgHrs> ILAppxFFlgHrs { get; set; }
        public IList<AppxFIntsrExp> ILAppxFIntsrExp { get; set; }



    }


    public class AppxEPerformance : LetterForwardedGEB
    {
        public int AppxEPerformance_ID { get; set; }

        public string DateOfGEB { get; set; }
        public string Result { get; set; }
        public string Category { get; set; }
        public string InstrumentRating { get; set; }
        public string InstructorCat { get; set; }
        public string GoodShow { get; set; }
        public string WarnedFor { get; set; }
        public string SpecialRemarks { get; set; }
        public string FlgSubDate { get; set; }
        public int FlgSubMarks { get; set; }
        public string FlgSubRemarks { get; set; }
        public string TacandSplDate { get; set; }
        public int TacandSplMarks { get; set; }
        public string TacandSplRemarks { get; set; }
        public string SplBfgDate { get; set; }
        public int SplBfgMarks { get; set; }
        public string SplBfgRemarks { get; set; }
        public string DayFlgDate { get; set; }
        public int DayFlgMarks { get; set; }
        public string DayFlgRemarks { get; set; }
        public string SplExDate { get; set; }
        public int SplExMarks { get; set; }
        public string SplExRemarks { get; set; }
        public string OpADate { get; set; }
        public int OpAMarks { get; set; }
        public string OpARemarks { get; set; }
        public string NiFlgDate { get; set; }
        public int NiFlgMarks { get; set; }
        public string NiFlgRemarks { get; set; }
        public string DateOfAward { get; set; }


        public LetterForwardedGEB finalAppx { get; set; }



    }
    public class AppxF : LetterForwardedGEB
    {
        public int AppxFId { get; set; }
        public int AppxFForYear { get; set; }
        public string InstructoionalCatApplied { get; set; }
        public string InstructoionalCatIRHeld { get; set; }
        public string InstructoionalCatIRHeldAircraft { get; set; }
        public string InstructoionalCatIRDate { get; set; }
        public string DateofCatAward { get; set; }
        public string AwardTypeAircraft { get; set; }
        public string AHI_QFICourseNo { get; set; }
        public string DateofCompletion { get; set; }
        public string QFICatDate { get; set; }
        public string OpInstructionalSyllabusNo { get; set; }
        public decimal OpInstructionalHrs { get; set; }
        public string OpInstructionalSyllabusComletedOn { get; set; }
        public string OpInstructionalSyllabusComletedByArmyNo { get; set; }
        public string OpInstructionalSyllabusComletedByRank { get; set; }
        public string OpInstructionalSyllabusComletedByName { get; set; }
        public string ReccommendInstructionalCatIR { get; set; }
        public string ReccommendInstructionalCatAircraft { get; set; }
        public string CourseType { get; set; }



    }

    public class AppxG : LetterForwardedGEB
    {
        public int AppxGId { get; set; }
        public int AppxGForYear { get; set; }
        public string CheckAviatorEndorsementExp { get; set; }
        public string CheckAviatorEndorsementOnAirCraftType { get; set; }
        public string CheckAviatorEndorsementExpUnit { get; set; }
        public decimal TotalInstrDayExp { get; set; }
        public decimal TotalInstrNightExp { get; set; }
        public string Syllabus9ACompletedOn { get; set; }
        public string CompletedByICNo { get; set; }
        public string CompletedByRank { get; set; }
        public string CompletedByName { get; set; }
        public int NoQFIInTheUnit { get; set; }
        public string RecomeForCheckAviatorUnit { get; set; }
        public string RecomeForCheckAviatorOnType { get; set; }
        public bool? ISRecommendByBrigAvn { get; set; }
        ///public bool? IsApprovedByGSO { get; set; }


    }

    public class AppxFFlgHrs : Common
    {
        public int AppxF_FlyingDetailId {get;set;}
        public int AppxFId {get;set;}
        public string AircraftType {get;set;}
        public decimal DayDualHr {get;set;}
        public decimal DayCaptainHr {get;set;}
        public decimal NightDualHr {get;set;}
        public decimal NightCaptainHr {get;set;}
        public IList<AppxFFlgHrs> ILAppxFFlgHrs { get; set; }


        public string ConvertFlyingHrs(decimal hrs)
        {
            string data = hrs.ToString();
            string[] parts = data.Split('.');
            if (parts[0].Length == 1)
            {
                parts[0] = "0" + parts[0].ToString();
            }
            return parts[0] + ":" + parts[1];
        }
    }

    public class AppxGFlgHrs : Common
    {
         public int AppxG_FlyingDetailId {get;set;}
         public int AppxGId {get;set;}
         public string AircraftType {get;set;}
         public decimal DayCaptainHr {get;set;}
         public decimal NightCaptainHr {get;set;}
      
    }

    public class AppxFIntsrExp : Common
    {
        public int AppxF_InstrExpId {get;set;}
        public int AppxFId {get;set;}
        public string AircraftType {get;set;}
        public string CatHeld {get;set;}
        public string DateOfAward {get;set;}
        public decimal InstrDayHrs {get;set;}
        public decimal InstrNightHrs {get;set;}
        

    }

    public class FinalAppxF
    {
        public AppxF appxF { get; set; }
        public AppxFFlgHrs appxFFlgHrs { get; set; }
        public AppxFIntsrExp appxFIntsrExp { get; set; }
        public IList<AppxFFlgHrs> ILAppxFFlgHrs { get; set; }
        public IList<AppxFIntsrExp> ILAppxFIntsrExp { get; set; }
    }

    public class FinalAppxG
    {
        public AppxG AppxG { get; set; }
        public AppxGFlgHrs AppxGFlgHrs { get; set; }      
        public IList<AppxGFlgHrs> ILAppxGFlgHrs { get; set; }
      
    }

    public class NominalRollForGEB
    {
        public IList<GEBLetter> ILGEBLetter { get; set; }
        public IList<LetterForwardedGEB> ILLetterForwardedGEB { get; set; }
        public IList<GEBLetterForwardedForUnit> ILGEBLetterForwardedForUnit { get; set; }

        public AviatorCRUD aviator { get; set; }
    }

    public class VieViewAviatorDetails
    {

        public IList<AviatorCRUD> ILAviatorCRUD { get; set; }
        public IList<AviatorContactDetailsCRUD> ILAviatorContactDetailsCRUD { get; set; }
        public IList<AviatorCoursesCRUD> ILAviatorCoursesCRUD { get; set; }
        public IList<AviatorHonourAwardsCRUD> ILAviatorHonourAwardsCRUD { get; set; }
        public IList<AviatorFlyingHrsCRUD> ILAviatorFlyingHrsCRUD { get; set; }
        public IList<AviatorSpecialEqptCRUD> ILAviatorSpecialEqptCRUD { get; set; }
        public IList<AviatorSpecialQualCRUD> ILAviatorSpecialQualCRUD { get; set; }
        public IList<AviatorMedicalCRUD> ILAviatorMedicalCRUD { get; set; }
   


    }


}