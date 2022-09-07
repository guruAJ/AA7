using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("tbl_ArmService", Schema="dbo")]
    public class dbo_tbl_ArmService
    {
        [Key]
        [Column(Order = 0)]
        [Required]
        [Display(Name = "Arm Service I D")]
        public Int32 ArmService_ID { get; set; }

        [StringLength(20)]
        [Display(Name = "Arm Service Name")]
        public String ArmServiceName { get; set; }

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
 
