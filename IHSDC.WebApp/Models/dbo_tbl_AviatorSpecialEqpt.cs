using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("tbl_AviatorSpecialEqpt", Schema="dbo")]
    public class dbo_tbl_AviatorSpecialEqpt
    {
        [Key]
        [Column(Order = 0)]
        [Required]
        [Display(Name = "Aviator Special Eqpt I D")]
        public Int32 AviatorSpecialEqpt_ID { get; set; }

        [Display(Name = "Aviator I D")]
        public Int32 Aviator_ID { get; set; }

        [Display(Name = "Special Eqpt I D")]
        public Int32? SpecialEqpt_ID { get; set; }

        [StringLength(4000)]
        [Display(Name = "Validation")]
        public String Validation{ get; set; }

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
        public virtual dbo_tbl_SpecialEqpt dbo_tbl_SpecialEqpt { get; set; }

    }
}
 
