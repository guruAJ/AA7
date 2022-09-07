using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("tbl_SpecialQual", Schema="dbo")]
    public class dbo_tbl_SpecialQual
    {
        [Key]
        [Column(Order = 0)]
        [Required]
        [Display(Name = "Special Qual I D")]
        public Int32 SpecialQual_ID { get; set; }

        [Required]
        [StringLength(4000)]
        [Display(Name = "Special Qual Name")]
        public String SpecialQualName { get; set; }

        [Required]
        [Display(Name = "Updated By User I D")]
        public Int32 UpdatedByUserID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Updated Date Time")]
        public DateTime UpdatedDateTime { get; set; }

       
    }
}
 
