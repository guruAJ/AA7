using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("tbl_Aircraft", Schema="dbo")]
    public class dbo_tbl_Aircraft
    {
        [Key]
        [Column(Order = 0)]
        [Required]
        [Display(Name = "Aircraft I D")]
        public Int32 Aircraft_ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Aircraft Name")]
        public String AircraftName { get; set; }

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
 
