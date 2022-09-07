using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("tbl_AviatorCourses", Schema="dbo")]
    public class dbo_tbl_AviatorCourses
    {
        [Key]
        [Column(Order = 0)]
        [Required]
        [Display(Name = "Aviator Courses I D")]
        public Int32 AviatorCourses_ID { get; set; }

        [Required]
        [Display(Name = "Select Aviator")]
        public Int32 Aviator_ID { get; set; }
        [Required]
        [Display(Name = "Course Name")]
        public Int32 Course_ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Course Serial Number")]
        public String CourseSerialNumber { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Course Start Date")]
        public DateTime? CourseStartDate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Course End Date")]
        public DateTime? CourseEndDate { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Course Grading")]
        public String CourseGrading { get; set; }
        [Required]
        [StringLength(4000)]
        [Display(Name = "Instructor Grading")]
        public String InstructorGrading { get; set; }

        [Required]
        [StringLength(4000)]
        [Display(Name = "Special Award")]
        public String Special_Award { get; set; }

       
        [StringLength(4000)]
        [Display(Name = "Notes")]
        public String Notes { get; set; }

        [StringLength(4000)]
        [Display(Name = "Validation")]
        public String Validation { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Validation Date")]
        public DateTime? ValidationDate { get; set; }

        [StringLength(4000)]
        [Display(Name = "Counter Validation")]
        public String CounterValidation{ get; set; }

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
        public virtual dbo_tbl_Courses dbo_tbl_Courses { get; set; }


        public virtual dbo_tbl_Aviator dbo_tbl_Aviator { get; set; }
    }
}
 
