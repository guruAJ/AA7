using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("tbl_AviatorMedical", Schema="dbo")]
    public class dbo_tbl_AviatorMedical
    {
        [Key]
        [Column(Order = 0)]
        [Required]
        [Display(Name = "Aviator Medical I D")]
        public Int32 AviatorMedical_ID { get; set; }

        [Required]
        [Display(Name = "Aviator I D")]
        public Int32 Aviator_ID { get; set; }

        [Required]

        [StringLength(50)]
        [Display(Name = "Type Of Medical")]
        public String TypeOfMedical { get; set; }

        [Required]

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Medical Start Date")]
        public DateTime? MedicalStartDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Medical End Date")]
        public DateTime? MedicalEndDate { get; set; }
       
             
        [Required]
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
    }
}
 
