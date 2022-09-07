using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IHSDC.WebApp.Connection;

namespace IHSDC.WebApp.Models
{
    public class Common
    {
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public Int32 UserId { get; set; }
        public bool IsSuccess { get; set; }
        public bool IsExist { get; set; }
        public string Msg { get; set; }
        public string MsgStatus { get; set; }
        public string MidMsg { get; set; }

    }

    public class Rank
    {
        public int RankId { get; set; }
        [Required(ErrorMessage = "required!")]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string RankName { get; set; }
        public IList<Rank> ILRankName { get; set; }
    }
    public class ComdCRUD : Common
    {
        public int ComdId { get; set; }

        [Required(ErrorMessage = "required!")]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string ComdName { get; set; }
        public IList<ComdCRUD> ILComdCRUD { get; set; }
    }

    public class RankCRUD : Common
    {
        public int RankId { get; set; }
        [Required(ErrorMessage = "required!")]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string RankName { get; set; }
        public IList<RankCRUD> ILRankCRUD { get; set; }
    }

    public class CorpsCRUD : Common
    {
        public int CorpsId { get; set; }
        [Required(ErrorMessage = "required!")]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string CorpsName { get; set; }
        public IList<CorpsCRUD> ILCorpsCRUD { get; set; }
    }
    public class UnitCRUD : Common
    {
        public int Unit_ID { get; set; }
        [Required(ErrorMessage = "required!")]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string UnitName { get; set; }
        [Required(ErrorMessage = "required!")]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string Corps { get; set; }
        [Required(ErrorMessage = "required!")]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string TypeOfUnit { get; set; }
        [Required(ErrorMessage = "required!")]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string Command { get; set; }
        public IList<UnitCRUD> ILUnitCRUD { get; set; }
    }

    public class user
    {
        public int IntId { get; set; }
        public string UserName { get; set; }
        public IList<user> GetUser { get; set; }
    }

    public class CoursesCRUD : Common
    {
        public int Course_ID { get; set; }
        [Required(ErrorMessage = "required!")]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string CourseName { get; set; }
        [Required(ErrorMessage = "required!")]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string CourseInstitute { get; set; }
        [Required(ErrorMessage = "required!")]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string CoursePlace { get; set; }
        public IList<CoursesCRUD> ILCoursesCRUD { get; set; }
    }

    public class SpecialEqptCRUD : Common
    {
        public int SpecialEqpt_ID { get; set; }
        [Required(ErrorMessage = "required!")]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string SpecialEqptName { get; set; }
        public IList<SpecialEqptCRUD> ILSpecialEqptCRUD { get; set; }
    }

    public class SpecialQualCRUD : Common
    {
        public int SpecialQual_ID { get; set; }
        [Required(ErrorMessage = "required!")]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string SpecialQualName { get; set; }
        public IList<SpecialQualCRUD> ILSpecialQualCRUD { get; set; }
    }


    public class ArmServiceCRUD : Common
    {
        public int ArmService_ID { get; set; }
        [Required(ErrorMessage = "required!")]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string ArmServiceName { get; set; }
        public IList<ArmServiceCRUD> ILArmServiceCRUD { get; set; }
    }


    public class AircraftCRUD : Common
    {
        public int Aircraft_ID { get; set; }

        [Required(ErrorMessage = "required!")]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string AircraftName { get; set; }
        public IList<AircraftCRUD> ILAircraftCRUD { get; set; }
    }

    public class HonourAwardCRUD : Common
    {
        public int HonourAward_ID { get; set; }


        [Required(ErrorMessage = "required!")]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string HonourAwardName { get; set; }
        public IList<HonourAwardCRUD> ILHonourAwardCRUD { get; set; }
    }

    public class AccidentCatCRUD : Common
    {
        public int AccidentCat_ID { get; set; }
        [Required(ErrorMessage = "required!")]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string AccidentCatName { get; set; }
        public IList<AccidentCatCRUD> ILAccidentCatCRUD { get; set; }
    }

    public class CourseGradingCRUD : Common
    {
        public int CourseGradingId { get; set; }
        [Required(ErrorMessage = "required!")]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]

        public string Grading { get; set; }
        public IList<CourseGradingCRUD> ILCourseGradingCRUD { get; set; }
    }


    public class FlgWithApptCRUD : Common
    {
        public int FlgWithApptId { get; set; }
        [Required(ErrorMessage = "required!")]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string ApptName { get; set; }
        public IList<FlgWithApptCRUD> ILFlgWithApptCRUD { get; set; }
    }





    public class CommandId
    {
        public int ComdId { get; set; }
        public string CommandName { get; set; }

    }





    public class MasterModels
    {
        public SelectList LoadCommandId()
        {
            DBConnection con = new DBConnection();
            CommandId model = new CommandId();
            return new SelectList(con.CommandId(), "ComdId", "CommandName");
        }




        public SelectList LoadRanks()
        {
            DBConnection con = new DBConnection();
            Rank model = new Rank();
            var data = con.GetDataInList<Rank>("SELECT [RankId],[RankName] FROM [dbo].[RankMaster] WHERE  IsActive = 1  AND IsDeleted = 0 ORDER BY [RankOder]  asc").ToList();

            return new SelectList(data, "RankName", "RankName");
        }

        public SelectList LoadAllUsers()
        {
            DBConnection con = new DBConnection();
            user model = new user();
            return new SelectList(con.getAllUsers(), "IntId", "UserName");
        }
        public SelectList LoadCourseName()
        {
            DBConnection con = new DBConnection();
            CoursesCRUD model = new CoursesCRUD();
            return new SelectList(con.CoursesCRUD(2, model), "Course_ID", "CourseName");
        }

        public SelectList LoadHonourAwardName()
        {
            DBConnection con = new DBConnection();
            HonourAwardCRUD model = new HonourAwardCRUD();
            return new SelectList(con.HonourAwardCRUD(2, model), "HonourAward_ID", "HonourAwardName");
        }


        public SelectList LoadAviatorName()
        {
            DBConnection con = new DBConnection();
            AviatorCRUD model = new AviatorCRUD();
            return new SelectList(con.GetAviatorList(), "Aviator_ID", "AviatorName");
        }

        public SelectList LoadPostingAviatorName()
        {
            DBConnection con = new DBConnection();
            AviatorCRUD model = new AviatorCRUD();
            return new SelectList(con.GetPostingAviatorList(), "Aviator_ID", "AviatorName");
        }

        public SelectList LoadUnitPostingName()
        {
            DBConnection con = new DBConnection();
            UnitCRUD model = new UnitCRUD();
            return new SelectList(con.GetPostingUnitList(), "Unit_ID", "UnitName");
        }


        public SelectList UnitName()
        {
            DBConnection con = new DBConnection();
            UnitCRUD model = new UnitCRUD();
            return new SelectList(con.GetPostingUnitList(), "UnitName", "UnitName");
        }


        public SelectList LoadYesNo()
        {
            return new SelectList(new SelectListItem[]{
                new SelectListItem{Text="YES",Value="YES"},
                new SelectListItem{Text="NO",Value="NO"}

            }, "Value", "Text");
        }
        public SelectList LoadAircraftName()
        {
            DBConnection con = new DBConnection();
            AircraftCRUD model = new AircraftCRUD();
            return new SelectList(con.AircraftCRUD(2, model), "Aircraft_ID", "AircraftName");
        }
        public SelectList LoadAircraftType()
        {
            DBConnection con = new DBConnection();
            AircraftCRUD model = new AircraftCRUD();
            return new SelectList(con.AircraftCRUD(2, model), "AircraftName", "AircraftName");
        }
        public SelectList LoadUnitName()
        {
            DBConnection con = new DBConnection();
            UnitCRUD model = new UnitCRUD();
            return new SelectList(con.UnitCRUD(2, model), "Unit_ID", "UnitName");
        }
        public SelectList LoadCourseGrading()
        {
            DBConnection con = new DBConnection();
            CourseGradingCRUD model = new CourseGradingCRUD();
            return new SelectList(con.CourseGradingCRUD(2, model), "Grading", "Grading");
        }

        public SelectList LoadCorpsName()
        {
            DBConnection con = new DBConnection();
            CorpsCRUD model = new CorpsCRUD();
            return new SelectList(con.CorpsCRUD(2, model), "CorpsId", "CorpsName");
        }
        public SelectList LoadCommandName()
        {
            DBConnection con = new DBConnection();
            ComdCRUD model = new ComdCRUD();
            return new SelectList(con.ComdCRUD(2, model), "ComdId", "ComdName");
        }
        public SelectList LoadSpecialEqptName()
        {
            DBConnection con = new DBConnection();
            SpecialEqptCRUD model = new SpecialEqptCRUD();
            return new SelectList(con.SpecialEqptCRUD(2, model), "SpecialEqpt_ID", "SpecialEqptName");
        }
        public SelectList LoadSpecialQualifiaction()
        {
            DBConnection con = new DBConnection();
            SpecialQualCRUD model = new SpecialQualCRUD();
            return new SelectList(con.SpecialQualCRUD(2, model), "SpecialQual_ID", "SpecialQualName");

        }
        public SelectList LoadArmServiceName()
        {
            DBConnection con = new DBConnection();
            ArmServiceCRUD model = new ArmServiceCRUD();
            return new SelectList(con.ArmServiceCRUD(2, model), "ArmService_ID", "ArmServiceName");
        }

        public SelectList LoadAccidentCat()
        {
            DBConnection con = new DBConnection();
            AccidentCatCRUD model = new AccidentCatCRUD();
            return new SelectList(con.AccidentCatCRUD(2, model), "AccidentCatName", "AccidentCatName");
        }
        public SelectList LoadExaminerAppt()
        {
            DBConnection con = new DBConnection();
            FlgWithApptCRUD model = new FlgWithApptCRUD();
            return new SelectList(con.FlgWithApptCRUD(2, model), "ApptName", "ApptName");
        }

        //public SelectList LoadRanks()
        //{
        //    return new SelectList(new SelectListItem[]{

        //        new SelectListItem{Text="LT",Value="Lt"},
        //        new SelectListItem{Text="CAPT",Value="Capt"},
        //        new SelectListItem{Text="MAJ",Value="Maj"},
        //         new SelectListItem{Text="LT COL",Value="Lt Col"},
        //        new SelectListItem{Text="COL",Value="Col"},
        //        new SelectListItem{Text="BRIG",Value="Brig"},
        //        new SelectListItem{Text="MAJ GEN",Value="Maj Gen"},
        //        new SelectListItem{Text="LT GEN",Value="Lt Gen"},
        //         new SelectListItem{Text="GEN",Value="Gen"}

        //    }, "Value", "Text");
        //}

        public SelectList LoadResults()
        {
            return new SelectList(new SelectListItem[]{
                new SelectListItem{Text="Upgraded",Value="Upgraded"},
                new SelectListItem{Text="Downgraded",Value="Downgraded"},
                new SelectListItem{Text="Standardised",Value="Standardised"},
                 new SelectListItem{Text="Not Awarded",Value="Not Awarded"},
                new SelectListItem{Text="To reappear",Value="To reappear"},


            }, "Value", "Text");
        }

        public SelectList LoadAppxType()
        {
            return new SelectList(new SelectListItem[]{
                new SelectListItem { Text = "NA", Value = "NA" },
                new SelectListItem{Value="Appx C",Text="Appx C"},
                new SelectListItem{Value="Appx D",Text="Appx D"},
                new SelectListItem{Value="Appx E",Text="Appx E"},
                 new SelectListItem{Value="Appx F",Text="Appx F"},
                new SelectListItem{Value="Appx G",Text="Appx G"}

            }, "Value", "Text");
        }
        public SelectList LoadLocation()
        {
            return new SelectList(new SelectListItem[]{

                new SelectListItem{Value="Peace",Text="Peace"},
                new SelectListItem{Value="Field",Text="Field"},


            }, "Value", "Text");
        }




        public SelectList LoadSuffixLetterNumber()
        {
            return new SelectList(new SelectListItem[]{
                new SelectListItem{Value="A",Text="A"},
                new SelectListItem{Value="F",Text="F"},
                new SelectListItem{Value="H",Text="H"},
                new SelectListItem{Value="K",Text="K"},
                new SelectListItem{Value="L",Text="L"},
                new SelectListItem{Value="M",Text="M"},
                new SelectListItem{Value="N",Text="N"},
                new SelectListItem{Value="P",Text="P"},
                  new SelectListItem{Value="W",Text="W"},
                new SelectListItem{Value="X",Text="X"},
               new SelectListItem{Value="Y",Text="Y"}

            }, "Value", "Text");
        }

        public SelectList LoadANumber()
        {
            return new SelectList(new SelectListItem[]{
                new SelectListItem{Value="IC",Text="IC"},
                new SelectListItem{Value="SS",Text="SS"},
                new SelectListItem{Value="SL",Text="SL"},
                new SelectListItem{Value="MS",Text="MS"},
                  new SelectListItem{Value="SC",Text="SC"},
                    new SelectListItem{Value="WS",Text="WS"},

            }, "Value", "Text");
        }

        public SelectList LoadMedicalStatus()
        {
            return new SelectList(new SelectListItem[]{
                new SelectListItem{Value="",Text="--Select Medical Status"},
                new SelectListItem { Text = "NA", Value = "NA" },
                new SelectListItem{Value="Flying Fit",Text="Flying Fit"},
                new SelectListItem{Value="Flying Unfit",Text="Flying Unfit"},
                new SelectListItem{Value="Flying Temporarily Fit",Text="Flying Temporarily Fit"},
                new SelectListItem{Value="Flying Temporarily UnFit",Text="Flying Permanently UnFit"},
                new SelectListItem{Value="Fit for CoPilot Duties",Text="Fit for CoPilot Duties"}
            }, "Value", "Text");
        }

        public SelectList LoadTypeofMedical()
        {
            return new SelectList(new SelectListItem[]{
              new SelectListItem() {Text = "--Select--", Value=""},
               new SelectListItem { Text = "NA", Value = "NA" },
               new SelectListItem() {Text = "AME", Value="AME"},
               new SelectListItem() {Text = "PME", Value="PME"},
                new SelectListItem() {Text = "SME", Value="SME"},

            }, "Value", "Text");
        }



        public SelectList LoadAircraft()
        {
            return new SelectList(new SelectListItem[]{
                new SelectListItem{Value="1",Text="CTH"},
                new SelectListItem{Value="2",Text="CTK"},
                new SelectListItem{Value="3",Text="CTL"},
                 new SelectListItem{Value="4",Text="ALH MK1"},
                new SelectListItem{ Value="5",Text="ALH MK2"},
                 new SelectListItem{Value="6",Text="ALH MK3"},
                new SelectListItem{Value="7",Text="ALH MK4"},
                new SelectListItem{Value="8",Text="ALH - WSI"},
                 new SelectListItem{Value="9",Text="CTHH"},
                new SelectListItem{Value="10",Text="KA226T"}

            }, "Value", "Text");
        }




        public SelectList LoadNokRelationship()
        {
            return new SelectList(new SelectListItem[]{

                new SelectListItem{Text="SPOUSE",Value="SPOUSE"},
                new SelectListItem{Text="FATHER",Value="FATHER"},
                new SelectListItem{Text="MOTHER",Value="MOTHER"},
                new SelectListItem{Text="BROTHER",Value="BROTHER"},
                new SelectListItem{Text="SISTER",Value="SISTER"},
                new SelectListItem{Text="SON",Value="SON"},
                new SelectListItem{Text="DAUGHTER",Value="DAUGHTER"},
                  new SelectListItem{Text="GRAND FATHER",Value="GRAND FATHER"},
                new SelectListItem{Text="GRAND MOTHER",Value="GRAND MOTHER"}

            }, "Value", "Text");
        }

        public SelectList LoadMartialStatus()
        {
            return new SelectList(new SelectListItem[]{

                new SelectListItem{Text="SINGLE",Value="SINGLE"},
                new SelectListItem{Text="MARRIED",Value="MARRIED"},
                  new SelectListItem{Text="SEPARATED",Value="SEPARATED"},
                   new SelectListItem{Text="DIVORCED",Value="DIVORCED"},
                    new SelectListItem{Text="WIDOWER",Value="WIDOWER"}


            }, "Value", "Text");
        }


        public SelectList LoadApptName()
        {
            return new SelectList(new SelectListItem[]{
               new SelectListItem{Text="Flt Cdr",Value="Flt Cdr"},
                new SelectListItem{Text="2IC",Value="2IC"},
                  new SelectListItem{Text="Adjut",Value="Adjut"},
                    new SelectListItem{Text="QM",Value="QM"},
                      new SelectListItem{Text="Sec Cdr",Value="Sec Cdr"},
                        new SelectListItem{Text="SATCO",Value="SATCO"}


            }, "Value", "Text");
        }
        public SelectList LoadHillflyingQualification()
        {
            return new SelectList(new SelectListItem[]{
                new SelectListItem { Text = "NA", Value = "NA" },
                new SelectListItem{Text="YES",Value="YES"},
                new SelectListItem{Text="NO",Value="NO"}

            }, "Value", "Text");
        }
        public SelectList LoadAttackHelicopter()
        {
            return new SelectList(new SelectListItem[]{
                new SelectListItem { Text = "NA", Value = "NA" },
                new SelectListItem{Text="YES",Value="YES"},
                new SelectListItem{Text="NO",Value="NO"}

            }, "Value", "Text");
        }
        public SelectList LoadHillflyingHeightClearance()
        {
            return new SelectList(new SelectListItem[]{
                new SelectListItem { Text = "NA", Value = "NA" },
                new SelectListItem{Text="UPTO 5000",Value="UPTO 5000"},
                new SelectListItem{Text="5000 TO 10000",Value="5000 TO 10000"},
                new SelectListItem{Text="10000 TO 15000",Value="10000 TO 15000"},
                new SelectListItem{Text="15000 TO 17000",Value="15000 TO 17000"},
                new SelectListItem{Text="ABOVE 17000",Value="ABOVE 17000"}

            }, "Value", "Text");
        }

        public SelectList LoadTypeOfFlight()
        {
            return new SelectList(new SelectListItem[]{
                new SelectListItem { Text = "NA", Value = "NA" },
                new SelectListItem{Text="NORMAL",Value="NORMAL"},
                new SelectListItem{Text="INDEPENDENT",Value="INDEPENDENT"}

            }, "Value", "Text");
        }
        public SelectList LoadDeckLanding()
        {
            return new SelectList(new SelectListItem[]{
                new SelectListItem { Text = "NA", Value = "NA" },
                new SelectListItem{Text="YES",Value="YES"},
                new SelectListItem{Text="NO",Value="NO"}

            }, "Value", "Text");
        }
        public SelectList LoadMonth()
        {
            return new SelectList(new SelectListItem[]{

                new SelectListItem{Text="JAN",Value="JAN"},
                new SelectListItem{Text="FEB",Value="FEB"},
                new SelectListItem{Text="MAR",Value="MAR"},
                new SelectListItem{Text="APR",Value="APR"},
                new SelectListItem{Text="MAY",Value="MAY"},
                new SelectListItem{Text="JUN",Value="JUN"},
                new SelectListItem{Text="JUL",Value="JUL"},
                new SelectListItem{Text="AUG",Value="AUG"},
                new SelectListItem{Text="SEP",Value="SEP"},
                new SelectListItem{Text="OCT",Value="OCT"},
                new SelectListItem{Text="NOV",Value="NOV"},
                 new SelectListItem{Text="DEC",Value="DEC"}

            }, "Value", "Text");
        }
        public SelectList LoadYear()
        {
            return new SelectList(new SelectListItem[]{
                new SelectListItem { Text = "NA", Value = "NA" },
                new SelectListItem{Text="2000",Value="2000"},
                new SelectListItem{Text="2001",Value="2001"}

            }, "Value", "Text");
        }

        public SelectList LoadBlameWorthy()
        {
            return new SelectList(new SelectListItem[]{
                new SelectListItem { Text = "NA", Value = "NA" },
                new SelectListItem{Text="YES",Value="YES"},
                new SelectListItem{Text="NO",Value="NO"}

            }, "Value", "Text");
        }

        public SelectList LoadAppearingFor()
        {
            return new SelectList(new SelectListItem[]{

            new SelectListItem { Text = "Not Appeared", Value = "Not Appeared" },
            new SelectListItem { Text = "AMG", Value = "A MASTER GREEN" },
            new SelectListItem { Text = "BMG", Value = "B MASTER GREEN" },
            new SelectListItem { Text = "BG", Value = "B GREEN" },
            new SelectListItem { Text = "CG", Value = "C GREEN" },
            new SelectListItem { Text = "CW Rec G", Value = "CW REC G" },
             new SelectListItem { Text = "CW", Value = "CW" },
             new SelectListItem { Text = "D Rec CW", Value = "D REC CW" },
            new SelectListItem { Text = "DW", Value = "D WHITE" },
            new SelectListItem { Text = "CR", Value = "CR" },
             new SelectListItem { Text = "CT", Value = "CT" },


        }
        , "Value", "Text");
        }

        public SelectList LoadCatResult()
        {
            return new SelectList(new SelectListItem[]{
            new SelectListItem { Text = "AMG", Value = "A MASTER GREEN" },
            new SelectListItem { Text = "BMG", Value = "B MASTER GREEN" },
            new SelectListItem { Text = "CG", Value = "C GREEN" },
            new SelectListItem { Text = "BG", Value = "B GREEN" },
            new SelectListItem { Text = "DW", Value = "D WHITE" },
            new SelectListItem { Text = "D Rec CW", Value = "D REC CW" },
            new SelectListItem { Text = "CW", Value = "CW" },
            new SelectListItem { Text = "CW Rec G", Value = "CW REC G" },
            new SelectListItem { Text = "CR", Value = "CR" },
             new SelectListItem { Text = "CT", Value = "CT" },
            new SelectListItem { Text = "INITIAL CAT", Value = "INITIAL CAT" },

        }
        , "Value", "Text");
        }

        public SelectList LoadQFI()
        {
            return new SelectList(new SelectListItem[]{

            new SelectListItem { Text = "JAI I", Value = "JAI I" },
      new SelectListItem { Text = "SAI I", Value = "SAI I" },
        new SelectListItem { Text = "SAI II", Value = "SAI II" },
        new SelectListItem { Text = "MAI", Value = "MAI" },


          }
        , "Value", "Text");
        }


        public SelectList LoadInstrCatIR()
        {
            return new SelectList(new SelectListItem[]{
            new SelectListItem { Text = "JAI I", Value = "JAI I" },
      new SelectListItem { Text = "SAI I", Value = "SAI I" },
        new SelectListItem { Text = "SAI II", Value = "SAI II" },
        new SelectListItem { Text = "MAI", Value = "MAI" },


          }
        , "Value", "Text");
        }



        public SelectList LoadAviatorCol()
        {
            return new SelectList(new SelectListItem[]{
          new SelectListItem { Text = "Army Number", Value = "ArmyNumber" },
          new SelectListItem { Text = "First Name", Value = "FirstName" },
          new SelectListItem { Text = "Unit Name", Value = "f.UnitName" },
          new SelectListItem { Text = "AviatorRank", Value = "AviatorRank" },
          new SelectListItem { Text = "Last Name", Value = "LastName" },
          new SelectListItem { Text = "Arm Service  Name", Value = "ArmServiceName" },
          new SelectListItem { Text = " Aircraft Name  ", Value = "AircraftName" },
          new SelectListItem { Text = "DateOfBirth", Value = "DateOfBirth" },
          new SelectListItem { Text = "DateOfSeniority", Value = "DateOfSeniority" },
          new SelectListItem { Text = "DateOfWings", Value = "DateOfWings" },
          new SelectListItem { Text = "DateOfRank", Value = "DateOfRank" },
          new SelectListItem { Text = "CatCardNo", Value = "CatCardNo" },
          new SelectListItem { Text = "DateofIssueCatCard", Value = "DateofIssueCatCard" },

          }
        , "Value", "Text");
        }
        public SelectList LoadContainsCol()
        {
            return new SelectList(new SelectListItem[]{
              new SelectListItem { Text = "Contains", Value = "Contains" },
               new SelectListItem { Text = "Equal", Value = "=" },
              new SelectListItem { Text = "Greater Than", Value = ">" },
              new SelectListItem { Text = "Less Than", Value = "<" },
              new SelectListItem { Text = "Greater Than Equal", Value = ">=" },
              new SelectListItem { Text = "Less Than Equal", Value = "<=" },
          }
        , "Value", "Text");
        }

        public SelectList LoadAViatorCourseCol()
        {
            return new SelectList(new SelectListItem[]{
              new SelectListItem { Text = "Course Name", Value = "CourseName" },
               new SelectListItem { Text = "Course Serial Number", Value = "CourseSerialNumber" },
              new SelectListItem { Text = "Course Star tDate", Value = "CourseStartDate" },
              new SelectListItem { Text = "Course End Date", Value = "CourseEndDate" },
              new SelectListItem { Text = "Unit Name", Value = "f.UnitName" },
              new SelectListItem { Text = "Course Grading", Value = "CourseGrading" },
              new SelectListItem { Text = "Instructor Grading", Value = "InstructorGrading" },
              new SelectListItem { Text = "Special Award", Value = "Special_Award" },
              new SelectListItem { Text = "Notes", Value = "Notes" },
          }
        , "Value", "Text");
        }


        public SelectList LoadAViatorMedicalCol()
        {
            return new SelectList(new SelectListItem[]{
              new SelectListItem { Text = "Type Of Medical", Value = "TypeOfMedical" },
               new SelectListItem { Text = "Medical Start Date", Value = "MedicalStartDate" },
              new SelectListItem { Text = "Medical End Date", Value = "MedicalEndDate" },
              new SelectListItem { Text = "Medical Cat", Value = "MedicalCat" },
              new SelectListItem { Text = "Unit Name", Value = "f.UnitName" },
              new SelectListItem { Text = "Medical Cat Date", Value = "MedicalCatDate" },
              new SelectListItem { Text = "Duration In Weeks", Value = "DurationInWeeks" },
              new SelectListItem { Text = "ReCat Due Date", Value = "ReCatDueDate" },
              new SelectListItem { Text = "Medical Status", Value = "MedicalStatus" },
          }
        , "Value", "Text");
        }



        public SelectList LoadAViatorEQPTCol()
        {
            return new SelectList(new SelectListItem[]{
              new SelectListItem { Text = "SpecialEqpt Name", Value = "SpecialEqptName" },
               new SelectListItem { Text = "Special Eqpt Date", Value = "SpecialEqptDate" },

          }
        , "Value", "Text");
        }

        public SelectList LoadAViatorQaulCol()
        {
            return new SelectList(new SelectListItem[]{
              new SelectListItem { Text = "Special Qual Name", Value = "SpecialQualName" },
               new SelectListItem { Text = "Special Qual Date", Value = "SpecialQualDate" },

          }
        , "Value", "Text");
        }



        public SelectList LoadCA()
        {
            return new SelectList(new SelectListItem[]{
              new SelectListItem { Text = "Supervisory", Value = "Supervisory" },
               new SelectListItem { Text = "Instructional", Value = "Instructional" },

          }
        , "Value", "Text");
        }


        public SelectList LoadAViatorHounerCol()
        {
            return new SelectList(new SelectListItem[]{
              new SelectListItem { Text = "Honour Award Name", Value = "HonourAwardName" },
               new SelectListItem { Text = "Honour Awards Date", Value = "HonourAwardsDate" },
               new SelectListItem { Text = "Honour Awards Place", Value = "HonourAwardsPlace" },
               new SelectListItem { Text = "Remarks", Value = "Remarks" },

          }
        , "Value", "Text");
        }
        public SelectList LoadAViatorAccidentCol()
        {
            return new SelectList(new SelectListItem[]{
              new SelectListItem { Text = "Accident Cat", Value = "AccidentCat" },
               new SelectListItem { Text = "Date Of Accident Incident", Value = "DateOfAccidentIncident" },
               new SelectListItem { Text = "Place Of Accident Incident", Value = "PlaceOfAccidentIncident" },
               new SelectListItem { Text = "Details Of Accident Incident", Value = "DetailsOfAccidentIncident" },
               new SelectListItem { Text = "Blameworthy", Value = "Blameworthy" },
               new SelectListItem { Text = "Aircraft Name", Value = "AircraftName" },
               new SelectListItem { Text = "Unit Name", Value = "c.UnitName" },
          }
        , "Value", "Text");
        }



        public SelectList LoadAViatorAPPCol()
        {
            return new SelectList(new SelectListItem[]{

               new SelectListItem { Text = "Appt Name", Value = "ApptName" },
                new SelectListItem { Text = "Appt Date", Value = "ApptDate" },

          }
        , "Value", "Text");
        }

        public SelectList LoadAViatorRankCol()
        {
            return new SelectList(new SelectListItem[]{
              new SelectListItem { Text = "Rank", Value = "Rank" },
               new SelectListItem { Text = "Rank Date", Value = "RankDate" },

          }
        , "Value", "Text");
        }


        public SelectList LoadContactContainsCol()
        {
            return new SelectList(new SelectListItem[]{
              new SelectListItem { Text = "Contains", Value = "Contains" },
               new SelectListItem { Text = "Equal", Value = "=" },

          }
        , "Value", "Text");
        }

        public SelectList LoadAviatorContactDetailsCol()
        {
            return new SelectList(new SelectListItem[]{
                 new SelectListItem { Text = "Unit Name", Value = "f.UnitName" },
              new SelectListItem { Text = "Mobile No", Value = "MobileNo" },
               new SelectListItem { Text = "LandLine No", Value = "LandLineNo" },
               new SelectListItem { Text = "NOK", Value = "NOK" },
               new SelectListItem { Text = "Relation With Nok", Value = "RelationWithNok" },
               new SelectListItem { Text = "Marital Status", Value = "MaritalStatus" },
               new SelectListItem { Text = "Name Of Spouse", Value = "NameOfSpouse" },
               new SelectListItem { Text = "Contact No. Of Spouse", Value = "ContactNoOfSpouse" },
               new SelectListItem { Text = "Email Of Spouse", Value = "EmailOfSpouse" },
               new SelectListItem { Text = "Residental HouseNo ", Value = "ResidentalHouseNo" },
               new SelectListItem { Text = "Residental Village Street", Value = "ResidentalVillage_Street" },
               new SelectListItem { Text = "Residental Post Office", Value = "ResidentalPostOffice" },
               new SelectListItem { Text = "Residental Tehsil", Value = "ResidentalTehsil" },
               new SelectListItem { Text = "Residental District", Value = "ResidentalDistrict" },
               new SelectListItem { Text = "Residental State", Value = "ResidentalState" },
               new SelectListItem { Text = "Residental Pincode", Value = "ResidentalPincode" },
               new SelectListItem { Text = "Permanent House No", Value = "PermanentHouseNo" },
               new SelectListItem { Text = "Permanent Village Street", Value = "PermanentVillage_Street" },
               new SelectListItem { Text = "Permanent Post Office", Value = "PermanentPostOffice" },
               new SelectListItem { Text = "Permanent Tehsil", Value = "PermanentTehsil" },
               new SelectListItem { Text = "Permanent District", Value = "PermanentDistrict" },
               new SelectListItem { Text = "Permanent State", Value = "PermanentState" },
               new SelectListItem { Text = "Permanent Pincode", Value = "PermanentPincode" },

          }
      , "Value", "Text");
        }


        public SelectList LoadAviatorFlyingCol()
        {
            return new SelectList(new SelectListItem[]{
              new SelectListItem { Text = "Aircraft Name", Value = "AircraftName" },
              new SelectListItem { Text = "Day Dual Hrs", Value = "DayDualHrs" },
               new SelectListItem { Text = "Day Solo Hrs", Value = "DaySoloHrs" },
               new SelectListItem { Text = "Day Copilot Hrs", Value = "DayCopilotHrs" },
               new SelectListItem { Text = "Night Dual Hrs", Value = "NightDualHrs" },
               new SelectListItem { Text = "Night Solo Hrs", Value = "NightSoloHrs" },
               new SelectListItem { Text = "Night Copilot Hrs", Value = "NightCopilotHrs" },
               new SelectListItem { Text = "NVG Exp", Value = "NVGExp" },
               new SelectListItem { Text = "WSO Exp", Value = "WSOExp" },
               new SelectListItem { Text = "IF Actual", Value = "IF_Actual" },
               new SelectListItem { Text = "Instr Day Hrs", Value = "InstrDayHrs" },
               new SelectListItem { Text = "IMC Hrs", Value = "IMCHrs" },
               new SelectListItem { Text = "SIF Hrs", Value = "SIFHrs" },
               new SelectListItem { Text = "ALH Sml Hrs", Value = "ALHSmlHrs" },
               new SelectListItem { Text = "Month", Value = "[Month]" },
               new SelectListItem { Text = "Year", Value = "[Year]" },
               new SelectListItem { Text = "UnitName", Value = "UnitName" },

          }
, "Value", "Text");
        }

        public SelectList LoadPostingCol()
        {
            return new SelectList(new SelectListItem[]{
              new SelectListItem { Text = "Posting Auth", Value = "PostingAuth" },
               new SelectListItem { Text = "Posting From Unit Name", Value = "ui.UnitName" },
               new SelectListItem { Text = "SOS", Value = "SOS" },
               new SelectListItem { Text = "SORS", Value = "SORS" },
               new SelectListItem { Text = "Posting To Unit Name", Value = "u.UnitName" },
               new SelectListItem { Text = "TOS", Value = "TOS" },
               new SelectListItem { Text = "TORS", Value = "TORS" },
               new SelectListItem { Text = "Posting Type", Value = "PostingType" },
               new SelectListItem { Text = "Posting In Date", Value = "PostingInDate" },
          }
        , "Value", "Text");
        }
        public SelectList LoadPostingTypeCol()
        {
            return new SelectList(new SelectListItem[]{
                new SelectListItem { Text = "NA", Value = "NA" },
              new SelectListItem { Text = "Flying Duties", Value = "Flying Duties" },

               new SelectListItem { Text = "Graded Staff", Value = "Graded Staff" },
               new SelectListItem { Text = "Line Staff", Value = "Line Staff" },
               new SelectListItem { Text = "Deputation", Value = "Deputation" },
               new SelectListItem { Text = "Cross Attachment", Value = "Cross Attachment" },
               new SelectListItem { Text = "Instr Appt", Value = "Instr Appt" },
               new SelectListItem { Text = "Foreign assignment Appt", Value = "Foreign assignment" },
               new SelectListItem { Text = "Other", Value = "Other" },
                        }
        , "Value", "Text");
        }

        // else if (select == "NA") { Item1.Selected = true; }
        //else if (select == "INITIAL CAT") { Item2.Selected = true; }
        //else if (select == "UPGRADED") { Item3.Selected = true; }
        //else if (select == "RENEWED") { Item4.Selected = true; }
        //else if (select == "DOWNGRADED") { Item5.Selected = true; }

        public SelectList LoadAppearingRemarks()
        {
            return new SelectList(new SelectListItem[]{
               new SelectListItem { Text = "NA", Value = "NA" },
               new SelectListItem { Text = "OnLeave", Value = "OnLeave" },
               new SelectListItem { Text = "OnTD", Value = "OnTD" },
               new SelectListItem { Text = "OnCourse", Value = "OnCourse" },



          }
        , "Value", "Text");
        }



        public SelectList LoadYesOrNO()
        {
            return new SelectList(new SelectListItem[]{
                new SelectListItem{Text="Yes",Value="True"},
                new SelectListItem{Text="No",Value="False"}

            }, "Value", "Text");
        }


        public SelectList LoadRecommededBrigAvn()
        {
            return new SelectList(new SelectListItem[]{

                new SelectListItem{Text="Recommeded",Value="True"},
                new SelectListItem{Text="Not Recommeded",Value="False"}

            }, "Value", "Text");
        }
        public SelectList LoadApprovedAvndte()
        {
            return new SelectList(new SelectListItem[]{
                new SelectListItem{Text="Approved",Value="True"},
                new SelectListItem{Text="Not Approved",Value="False"}

            }, "Value", "Text");
        }

        public SelectList LoadCourseType()
        {
            return new SelectList(new SelectListItem[]{
                new SelectListItem{Text="AHIC",Value="AHIC-"},
                new SelectListItem{Text="QFIC",Value="QFIC-"}

            }, "Value", "Text");
        }
        public SelectList LoadGoodShow()
        {
            return new SelectList(new SelectListItem[]{
                new SelectListItem{Text="Part I",Value="Part I"},
                new SelectListItem{Text="Part II",Value="Part II"},
                  new SelectListItem{Text="Lecture",Value="Lecture"},
                    new SelectListItem{Text="Ground Subjects",Value="Ground Subjects"},
                    new SelectListItem{Text="Flying Subjects",Value="Flying Subjects"},
                       new SelectListItem{Text="Flying & Ground Subjects",Value="Flying & Ground Subjects"},
            }, "Value", "Text");
        }


        public SelectList LoadPercentage()
        {
            return new SelectList(new SelectListItem[]{
  new SelectListItem{Text="1%",Value="1"},
 new SelectListItem{Text="2%",Value="2"},
 new SelectListItem{Text="3%",Value="3"},
 new SelectListItem{Text="4%",Value="4"},
 new SelectListItem{Text="5%",Value="5"},
 new SelectListItem{Text="6%",Value="6"},
 new SelectListItem{Text="7%",Value="7"},
 new SelectListItem{Text="8%",Value="8"},
 new SelectListItem{Text="9%",Value="9"},
 new SelectListItem{Text="10%",Value="10"},
 new SelectListItem{Text="11%",Value="11"},
 new SelectListItem{Text="12%",Value="12"},
 new SelectListItem{Text="13%",Value="13"},
 new SelectListItem{Text="14%",Value="14"},
 new SelectListItem{Text="15%",Value="15"},
 new SelectListItem{Text="16%",Value="16"},
 new SelectListItem{Text="17%",Value="17"},
 new SelectListItem{Text="18%",Value="18"},
 new SelectListItem{Text="19%",Value="19"},
 new SelectListItem{Text="20%",Value="20"},
 new SelectListItem{Text="21%",Value="21"},
 new SelectListItem{Text="22%",Value="22"},
 new SelectListItem{Text="23%",Value="23"},
 new SelectListItem{Text="24%",Value="24"},
 new SelectListItem{Text="25%",Value="25"},
 new SelectListItem{Text="26%",Value="26"},
 new SelectListItem{Text="27%",Value="27"},
 new SelectListItem{Text="28%",Value="28"},
 new SelectListItem{Text="29%",Value="29"},
 new SelectListItem{Text="30%",Value="30"},
 new SelectListItem{Text="31%",Value="31"},
 new SelectListItem{Text="32%",Value="32"},
 new SelectListItem{Text="33%",Value="33"},
 new SelectListItem{Text="34%",Value="34"},
 new SelectListItem{Text="35%",Value="35"},
 new SelectListItem{Text="36%",Value="36"},
 new SelectListItem{Text="37%",Value="37"},
 new SelectListItem{Text="38%",Value="38"},
 new SelectListItem{Text="39%",Value="39"},
 new SelectListItem{Text="40%",Value="40"},
 new SelectListItem{Text="41%",Value="41"},
 new SelectListItem{Text="42%",Value="42"},
 new SelectListItem{Text="43%",Value="43"},
 new SelectListItem{Text="44%",Value="44"},
 new SelectListItem{Text="45%",Value="45"},
 new SelectListItem{Text="46%",Value="46"},
 new SelectListItem{Text="47%",Value="47"},
 new SelectListItem{Text="48%",Value="48"},
 new SelectListItem{Text="49%",Value="49"},
 new SelectListItem{Text="50%",Value="50"},
 new SelectListItem{Text="51%",Value="51"},
 new SelectListItem{Text="52%",Value="52"},
 new SelectListItem{Text="53%",Value="53"},
 new SelectListItem{Text="54%",Value="54"},
 new SelectListItem{Text="55%",Value="55"},
 new SelectListItem{Text="56%",Value="56"},
 new SelectListItem{Text="57%",Value="57"},
 new SelectListItem{Text="58%",Value="58"},
 new SelectListItem{Text="59%",Value="59"},
 new SelectListItem{Text="60%",Value="60"},
 new SelectListItem{Text="61%",Value="61"},
 new SelectListItem{Text="62%",Value="62"},
 new SelectListItem{Text="63%",Value="63"},
 new SelectListItem{Text="64%",Value="64"},
 new SelectListItem{Text="65%",Value="65"},
 new SelectListItem{Text="66%",Value="66"},
 new SelectListItem{Text="67%",Value="67"},
 new SelectListItem{Text="68%",Value="68"},
 new SelectListItem{Text="69%",Value="69"},
 new SelectListItem{Text="70%",Value="70"},
 new SelectListItem{Text="71%",Value="71"},
 new SelectListItem{Text="72%",Value="72"},
 new SelectListItem{Text="73%",Value="73"},
 new SelectListItem{Text="74%",Value="74"},
 new SelectListItem{Text="75%",Value="75"},
 new SelectListItem{Text="76%",Value="76"},
 new SelectListItem{Text="77%",Value="77"},
 new SelectListItem{Text="78%",Value="78"},
 new SelectListItem{Text="79%",Value="79"},
 new SelectListItem{Text="80%",Value="80"},
 new SelectListItem{Text="81%",Value="81"},
 new SelectListItem{Text="82%",Value="82"},
 new SelectListItem{Text="83%",Value="83"},
 new SelectListItem{Text="84%",Value="84"},
 new SelectListItem{Text="85%",Value="85"},
 new SelectListItem{Text="86%",Value="86"},
 new SelectListItem{Text="87%",Value="87"},
 new SelectListItem{Text="88%",Value="88"},
 new SelectListItem{Text="89%",Value="89"},
 new SelectListItem{Text="90%",Value="90"},
 new SelectListItem{Text="91%",Value="91"},
 new SelectListItem{Text="92%",Value="92"},
 new SelectListItem{Text="93%",Value="93"},
 new SelectListItem{Text="94%",Value="94"},
 new SelectListItem{Text="95%",Value="95"},
 new SelectListItem{Text="96%",Value="96"},
 new SelectListItem{Text="97%",Value="97"},
 new SelectListItem{Text="98%",Value="98"},
 new SelectListItem{Text="99%",Value="99"},
 new SelectListItem{Text="100%",Value="100"},


            }, "Value", "Text");
        }





    }
}