using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("tbl_SearchType", Schema="dbo")]
    public class dbo_tbl_SearchType
    {
        [Key]
        [Column(Order = 0)]
        [Required]
        [Display(Name = "Search Type Id")]
        public Int32 SearchTypeId { get; set; }

        [Display(Name = "Sno")]
        public Int32? Sno { get; set; }

        [StringLength(4000)]
        [Display(Name = "Search From")]
        public String SearchFrom { get; set; }

        [StringLength(4000)]
        [Display(Name = "Search Field")]
        public String SearchField { get; set; }

        [StringLength(4000)]
        [Display(Name = "Search Condition")]
        public String SearchCondition { get; set; }

        [StringLength(4000)]
        [Display(Name = "Search Text")]
        public String SearchText { get; set; }


    }
}
 
