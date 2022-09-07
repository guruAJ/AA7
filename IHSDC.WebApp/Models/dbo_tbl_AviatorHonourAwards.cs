using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("tbl_AviatorHonourAwards", Schema="dbo")]
    public class dbo_tbl_AviatorHonourAwards
    {
        [Key]
        [Column(Order = 0)]
        [Required]
        [Display(Name = "Aviator Honour Awards I D")]
        public Int32 AviatorHonourAwards_ID { get; set; }


        [Required]
        [Display(Name = "Aviator I D")]
        public Int32 Aviator_ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Honour Awards")]
        public String HonourAwards { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Honour Awards Date")]
        public DateTime? HonourAwardsDate { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Honour Awards Place")]
        public String HonourAwardsPlace { get; set; }

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
    }
}
 
