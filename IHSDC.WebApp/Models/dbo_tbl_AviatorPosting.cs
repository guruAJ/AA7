using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("tbl_AviatorPosting", Schema="dbo")]
    public class dbo_tbl_AviatorPosting
    {
        [Key]
        [Column(Order = 0)]
        [Required]
        [Display(Name = "Aviator Posting I D")]
        public Int32 AviatorPosting_ID { get; set; }

        [Display(Name = "Aviator I D")]
        public Int32 Aviator_ID { get; set; }

        [Required]
        [StringLength(4000)]
        [Display(Name = "Posting Auth")]
        public String PostingAuth { get; set; }

        
        [StringLength(4000)]
        [Display(Name = "Posting From Unit")]
        public String PostingFromUnit { get; set; }


        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "S O S")]
        public DateTime? SOS { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "S O R S")]
        public DateTime? SORS { get; set; }

        [Required]
        [StringLength(4000)]
        [Display(Name = "Posting To Unit")]
        public String PostingToUnit { get; set; }


        
        [StringLength(4000)]
        [Display(Name = "Posting Type")]
        public String PostingType { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "T O S")]
        public DateTime? TOS { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "T O R S")]
        public DateTime? TORS { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Posting In Date")]
        public DateTime? PostingInDate { get; set; }
        
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
 
