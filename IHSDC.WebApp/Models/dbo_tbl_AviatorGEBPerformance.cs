using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("tbl_AviatorGEBPerformance", Schema="dbo")]
    public class dbo_tbl_AviatorGEBPerformance
    {
        [Key]
        [Column(Order = 0)]
        [Required]
        [Display(Name = "Aviator G E B Performance I D")]
        public Int32 AviatorGEBPerformance_ID { get; set; }

        [Display(Name = "Aviator I D")]
        public Int32 Aviator_ID { get; set; }

        [Display(Name = "Aircraft I D")]
        public Int32? Aircraft_ID { get; set; }

        [StringLength(4000)]
        [Display(Name = "Unit Name")]
        public String UnitName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Of G E B")]
        public DateTime? DateOfGEB { get; set; }

        [StringLength(50)]
        [Display(Name = "Result")]
        public String Result { get; set; }

        [StringLength(20)]
        [Display(Name = "Category")]
        public String Category { get; set; }

        [StringLength(20)]
        [Display(Name = "Instrument Rating")]
        public String InstrumentRating { get; set; }

        [StringLength(20)]
        [Display(Name = "Instructor Cat")]
        public String InstructorCat { get; set; }

        [StringLength(50)]
        [Display(Name = "Good Show")]
        public String GoodShow { get; set; }

        [StringLength(50)]
        [Display(Name = "Warned For")]
        public String WarnedFor { get; set; }

        [StringLength(4000)]
        [Display(Name = "Remarks")]
        public String Remarks { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Flg Sub Date")]
        public DateTime? FlgSubDate { get; set; }

        [Display(Name = "Flg Sub Marks")]
        public Decimal? FlgSubMarks { get; set; }

        [StringLength(50)]
        [Display(Name = "Flg Sub Remarks")]
        public String FlgSubRemarks { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Tacand Spl Date")]
        public DateTime? TacandSplDate { get; set; }

        [Display(Name = "Tacand Spl Marks")]
        public Decimal? TacandSplMarks { get; set; }

        [StringLength(50)]
        [Display(Name = "Tacand Spl Remarks")]
        public String TacandSplRemarks { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Spl Bfg Date")]
        public DateTime? SplBfgDate { get; set; }

        [Display(Name = "Spl Bfg Marks")]
        public Decimal? SplBfgMarks { get; set; }

        [StringLength(50)]
        [Display(Name = "Spl Bfg Remarks")]
        public String SplBfgRemarks { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Day Flg Date")]
        public DateTime? DayFlgDate { get; set; }

        [Display(Name = "Day Flg Marks")]
        public Decimal? DayFlgMarks { get; set; }

        [StringLength(50)]
        [Display(Name = "Day Flg Remarks")]
        public String DayFlgRemarks { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Spl Ex Date")]
        public DateTime? SplExDate { get; set; }

        [Display(Name = "Spl Ex Marks")]
        public Decimal? SplExMarks { get; set; }

        [StringLength(50)]
        [Display(Name = "Spl Ex Remarks")]
        public String SplExRemarks { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Op A Date")]
        public DateTime? OpADate { get; set; }

        [Display(Name = "Op A Marks")]
        public Decimal? OpAMarks { get; set; }

        [StringLength(50)]
        [Display(Name = "Op A Remarks")]
        public String OpARemarks { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Ni Flg Date")]
        public DateTime? NiFlgDate { get; set; }

        [Display(Name = "Ni Flg Marks")]
        public Decimal? NiFlgMarks { get; set; }

        [StringLength(50)]
        [Display(Name = "Ni Flg Remarks")]
        public String NiFlgRemarks { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Of Award")]
        public DateTime? DateOfAward { get; set; }

        [StringLength(4000)]
        [Display(Name = "Validation")]
        public String Validation { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Validation Date")]
        public DateTime? ValidationDate { get; set; }


        [StringLength(4000)]
        [Display(Name = "Validation")]
        public String CounterValidation { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Validation Date")]
        public DateTime? CounterValidationDate { get; set; }

        [Display(Name = "Updated By User I D")]
        public Int32? UpdatedByUserID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Updated Date Time")]
        public DateTime? UpdatedDateTime { get; set; }

        // ComboBox
        public virtual dbo_tbl_Aviator dbo_tbl_Aviator { get; set; }
        public virtual dbo_tbl_Aircraft dbo_tbl_Aircraft { get; set; }
        //public virtual dbo_tbl_Unit dbo_tbl_Unit { get; set; }

    }
}
 
