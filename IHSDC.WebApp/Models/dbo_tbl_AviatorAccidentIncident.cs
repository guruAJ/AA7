using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("tbl_AviatorAccidentIncident", Schema="dbo")]
    public class dbo_tbl_AviatorAccidentIncident
    {
        [Key]
        [Column(Order = 0)]
        [Required]
        [Display(Name = "Aviator Accident Incident I D")]
        public Int32 AviatorAccidentIncident_ID { get; set; }
        [Required]
        [Display(Name = "Aviator I D")]
        public Int32 Aviator_ID { get; set; }
        [Required]
        [Display(Name = "Aircraft I D")]
        public Int32? Aircraft_ID { get; set; }
     
        [StringLength(4000)]
        [Display(Name = "Unit Name")]
        public String UnitName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Accident Cat")]
        public String AccidentCat { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Of Accident Incident")]
        public DateTime? DateOfAccidentIncident { get; set; }

        [Required]
        [StringLength(4000)]
        [Display(Name = "Place Of Accident Incident")]
        public String PlaceOfAccidentIncident { get; set; }

        [Required]
        [StringLength(4000)]
        [Display(Name = "Details Of Accident Incident")]
        public String DetailsOfAccidentIncident { get; set; }

        [Required]
        [StringLength(4000)]
        [Display(Name = "Blameworthy")]
        public String Blameworthy { get; set; }

       
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

        // ComboBox
        public virtual dbo_tbl_Aircraft dbo_tbl_Aircraft { get; set; }



        public virtual dbo_tbl_Aviator dbo_tbl_Aviator { get; set; }
    }
}
 
