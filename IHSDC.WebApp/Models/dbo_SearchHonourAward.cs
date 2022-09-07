using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("SearchHonourAward", Schema="dbo")]
    public class dbo_SearchHonourAward
    {
        [Key]
        [Column(Order = 0)]
        [Display(Name = "I D")]
        public Int64? ID { get; set; }

        [Display(Name = "Aviator I D")]
        public Int32? Aviator_ID { get; set; }

        [StringLength(50)]
        [Display(Name = "Honour Awards")]
        public String HonourAwards { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Honour Awards Date")]
        public DateTime? HonourAwardsDate { get; set; }

        [StringLength(50)]
        [Display(Name = "Honour Awards Place")]
        public String HonourAwardsPlace { get; set; }

        [StringLength(4000)]
        [Display(Name = "Counter Validation")]
        public String CounterValidation { get; set; }


    }
}
 
