using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("tbl_SeacrhHeading", Schema="dbo")]
    public class dbo_tbl_SeacrhHeading
    {
        [Key]
        [Column(Order = 0)]
        [Required]
        [Display(Name = "Sno")]
        public Int32 Sno { get; set; }
        
        [StringLength(4000)]
        [Display(Name = "Search Heading")]
        public String SearchHeading { get; set; }

        [Display(Name = "Searched By")]
        public Int32? SearchedBy { get; set; }


    }
}
 
