using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("tbl_AviatorFlyingHrs", Schema="dbo")]
    public class dbo_tbl_AviatorFlyingHrs
    {
        [Key]
        [Column(Order = 0)]
        [Required]
        [Display(Name = "Aviator Flying Hrs I D")]
        public Int32 AviatorFlyingHrs_ID { get; set; }

        [Required]
        [Display(Name = "Aviator I D")]
        public Int32 Aviator_ID { get; set; }

        [Required]
        [Display(Name = "Aircraft I D")]
        public Int32? Aircraft_ID { get; set; }

        [StringLength(4000)]
        [Display(Name = "Unit Name")]
        public String UnitName { get; set; }

        [StringLength(20)]
        [Display(Name = "Category")]
        public String Category { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Instrument Rating")]
        public String InstrumentRating { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Instructor Cat")]
        public String InstructorCat { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "C A T I R Date")]
        public DateTime? CATIRDate { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        [Display(Name = "Day Dual Hrs")]
        public Int32? DayDualHrs { get; set; }

        [Range(1, 59)]
        [Display(Name = "Day Dual Min")]
        public Int32? DayDualMin { get; set; }
        
        [Display(Name = "Day Solo Hrs")]
        public Int32? DaySoloHrs { get; set; }
        [Range(1, 59)]
        [Display(Name = "Day Solo Min")]
        public Int32? DaySoloMin { get; set; }

        [Display(Name = "Day Copilot Hrs")]
        public Int32? DayCopilotHrs { get; set; }
        [Range(1, 59)]
        [Display(Name = "Day Copilot Min")]
        public Int32? DayCopilotMin { get; set; }

        [Display(Name = "Night Dual Hrs")]
        public Int32? NightDualHrs { get; set; }
        [Range(1, 59)]
        [Display(Name = "Night Dual Min")]
        public Int32? NightDualMin { get; set; }

        [Display(Name = "Night Solo Hrs")]
        public Int32? NightSoloHrs { get; set; }
        [Range(1, 59)]
        [Display(Name = "Night Solo Min")]
        public Int32? NightSoloMin { get; set; }

        [Display(Name = "Night Copilot Hrs")]
        public Int32? NightCopilotHrs { get; set; }
        [Range(1, 59)]
        [Display(Name = "Night Copilot Min")]
        public Int32? NightCopilotMin { get; set; }

        [Display(Name = "N V G Dual Hrs")]
        public Int32? NVGDualHrs { get; set; }
        [Range(1, 59)]
        [Display(Name = "N V G Dual Min")]
        public Int32? NVGDualMin { get; set; }

        [Display(Name = "N V G Solo Hrs")]
        public Int32? NVGSoloHrs { get; set; }
        [Range(1, 59)]
        [Display(Name = "N V G Solo Min")]
        public Int32? NVGSoloMin { get; set; }

        [Display(Name = "N V G Copilot Hrs")]
        public Int32? NVGCopilotHrs { get; set; }
        [Range(1, 59)]
        [Display(Name = "N V G Copilot Min")]
        public Int32? NVGCopilotMin { get; set; }

        [Display(Name = "Instr Day Hrs")]
        public Int32? InstrDayHrs { get; set; }
        [Range(1, 59)]
        [Display(Name = "Instr Day Min")]
        public Int32? InstrDayMin { get; set; }

        [Display(Name = "Instr Night Hrs")]
        public Int32? InstrNightHrs { get; set; }
        [Range(1, 59)]
        [Display(Name = "Instr Night Min")]
        public Int32? InstrNightMin { get; set; }

        [Display(Name = "I M C Hrs")]
        public Int32? IMCHrs { get; set; }
        [Range(1, 59)]
        [Display(Name = "I M C Min")]
        public Int32? IMCMin { get; set; }

        [Display(Name = "S I F Hrs")]
        public Int32? SIFHrs { get; set; }
        [Range(1, 59)]
        [Display(Name = "S I F Min")]
        public Int32? SIFMin { get; set; }

        [StringLength(4000)]
        [Display(Name = "Validation")]
        public String Validation { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Validation Date")]
        public DateTime? ValidationDate { get; set; }

        [StringLength(4000)]
        [Display(Name = "Counter Validation")]
        public String CounterValidation { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Counter Validation Date")]
        public DateTime? CounterValidationDate { get; set; }

        [Display(Name = "Updated By User I D")]
        public Int32? UpdatedByUserID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Updated Date Time")]
        public DateTime? UpdatedDateTime { get; set; }

        public virtual dbo_tbl_Aviator dbo_tbl_Aviator { get; set; }
        // ComboBox
        public virtual dbo_tbl_Aircraft dbo_tbl_Aircraft { get; set; }

    }
}
 
