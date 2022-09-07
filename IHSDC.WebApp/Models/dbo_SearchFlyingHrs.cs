using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("SearchFlyingHrs", Schema="dbo")]
    public class dbo_SearchFlyingHrs
    {
        [Key]
        [Column(Order = 0)]
        [Display(Name = "I D")]
        public Int64? ID { get; set; }

        [Display(Name = "Aviator I D")]
        public Int32? Aviator_ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Aircraft Name")]
        public String AircraftName { get; set; }

        [StringLength(4000)]
        [Display(Name = "Unit Name")]
        public String UnitName { get; set; }

        [StringLength(20)]
        [Display(Name = "Category")]
        public String Category { get; set; }

        [StringLength(20)]
        [Display(Name = "Instrument Rating")]
        public String InstrumentRating { get; set; }

        [StringLength(20)]
        [Display(Name = "Instructor Cat")]
        public String InstructorCat { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "C A T I R Date")]
        public DateTime? CATIRDate { get; set; }

        [Display(Name = "Day Dual Hrs")]
        public Int32? DayDualHrs { get; set; }

        [Display(Name = "Day Solo Hrs")]
        public Int32? DaySoloHrs { get; set; }

        [Display(Name = "Day Dual Min")]
        public Int32? DayDualMin { get; set; }

        [Display(Name = "Day Solo Min")]
        public Int32? DaySoloMin { get; set; }

        [Display(Name = "Day Copilot Hrs")]
        public Int32? DayCopilotHrs { get; set; }

        [Display(Name = "Day Copilot Min")]
        public Int32? DayCopilotMin { get; set; }

        [Display(Name = "Night Dual Hrs")]
        public Int32? NightDualHrs { get; set; }

        [Display(Name = "Night Dual Min")]
        public Int32? NightDualMin { get; set; }

        [Display(Name = "Night Solo Hrs")]
        public Int32? NightSoloHrs { get; set; }

        [Display(Name = "Night Solo Min")]
        public Int32? NightSoloMin { get; set; }

        [Display(Name = "Night Copilot Hrs")]
        public Int32? NightCopilotHrs { get; set; }

        [Display(Name = "Night Copilot Min")]
        public Int32? NightCopilotMin { get; set; }

        [Display(Name = "N V G Dual Hrs")]
        public Int32? NVGDualHrs { get; set; }

        [Display(Name = "N V G Solo Hrs")]
        public Int32? NVGSoloHrs { get; set; }

        [Display(Name = "N V G Dual Min")]
        public Int32? NVGDualMin { get; set; }

        [Display(Name = "N V G Solo Min")]
        public Int32? NVGSoloMin { get; set; }

        [Display(Name = "N V G Copilot Hrs")]
        public Int32? NVGCopilotHrs { get; set; }

        [Display(Name = "N V G Copilot Min")]
        public Int32? NVGCopilotMin { get; set; }

        [Display(Name = "Instr Day Hrs")]
        public Int32? InstrDayHrs { get; set; }

        [Display(Name = "Instr Day Min")]
        public Int32? InstrDayMin { get; set; }

        [Display(Name = "Instr Night Hrs")]
        public Int32? InstrNightHrs { get; set; }

        [Display(Name = "Instr Night Min")]
        public Int32? InstrNightMin { get; set; }

        [Display(Name = "I M C Hrs")]
        public Int32? IMCHrs { get; set; }

        [Display(Name = "I M C Min")]
        public Int32? IMCMin { get; set; }

        [Display(Name = "S I F Hrs")]
        public Int32? SIFHrs { get; set; }

        [StringLength(4000)]
        [Display(Name = "Validation")]
        public String Validation { get; set; }

        [Display(Name = "S I F Min")]
        public Int32? SIFMin { get; set; }

        [StringLength(4000)]
        [Display(Name = "Counter Validation")]
        public String CounterValidation { get; set; }

        [Display(Name = "Total Min")]
        public Int32? TotalMin { get; set; }

        [StringLength(30)]
        [Display(Name = "Total Hrs")]
        public String TotalHrs { get; set; }

        [Display(Name = "Hrs Only")]
        public Int32? HrsOnly { get; set; }


    }
}
 
