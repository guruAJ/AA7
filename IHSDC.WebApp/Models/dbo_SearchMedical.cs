using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("SearchMedical", Schema="dbo")]
    public class dbo_SearchMedical
    {
        [Key]
        [Column(Order = 0)]
        [Display(Name = "I D")]
        public Int64? ID { get; set; }

        [Display(Name = "Aviator I D")]
        public Int32? Aviator_ID { get; set; }

        [StringLength(50)]
        [Display(Name = "Type Of Medical")]
        public String TypeOfMedical { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Medical Start Date")]
        public DateTime? MedicalStartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Medical End Date")]
        public DateTime? MedicalEndDate { get; set; }

        [StringLength(50)]
        [Display(Name = "Medical Cat")]
        public String MedicalCat { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Medical Cat Date")]
        public DateTime? MedicalCatDate { get; set; }

        [Display(Name = "Duration In Weeks")]
        public Int32? DurationInWeeks { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Re Cat Due Date")]
        public DateTime? ReCatDueDate { get; set; }

        [StringLength(50)]
        [Display(Name = "Medical Status")]
        public String MedicalStatus { get; set; }

        [StringLength(50)]
        [Display(Name = "Remarks")]
        public String Remarks { get; set; }

        [StringLength(4000)]
        [Display(Name = "Counter Validation")]
        public String CounterValidation { get; set; }


    }
}
 
