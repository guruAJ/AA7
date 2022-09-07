using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("tbl_Courses", Schema="dbo")]
    public class dbo_tbl_Courses
    {
        [Key]
        [Column(Order = 0)]
        [Required]
        [Display(Name = "Course I D")]
        public Int32 Course_ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Course Name")]
        public String CourseName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Course Institute")]
        public String CourseInstitute { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Course Place")]
        public String CoursePlace { get; set; }

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
 
