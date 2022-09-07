using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("SearchCourse", Schema="dbo")]
    public class dbo_SearchCourse
    {
        [Key]
        [Column(Order = 0)]
        [Display(Name = "I D")]
        public Int64? ID { get; set; }

        [Display(Name = "Aviator I D")]
        public Int32? Aviator_ID { get; set; }

        [StringLength(50)]
        [Display(Name = "Course Serial Number")]
        public String CourseSerialNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Course Start Date")]
        public DateTime? CourseStartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Course End Date")]
        public DateTime? CourseEndDate { get; set; }

        [StringLength(50)]
        [Display(Name = "Course Grading")]
        public String CourseGrading { get; set; }

        [StringLength(4000)]
        [Display(Name = "Instructor Grading")]
        public String InstructorGrading { get; set; }

        [StringLength(4000)]
        [Display(Name = "Special Award")]
        public String Special_Award { get; set; }

        [StringLength(4000)]
        [Display(Name = "Notes")]
        public String Notes { get; set; }

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


    }
}
 
