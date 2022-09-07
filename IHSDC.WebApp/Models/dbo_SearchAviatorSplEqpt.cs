using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("SearchAviatorSplEqpt", Schema="dbo")]
    public class dbo_SearchAviatorSplEqpt
    {
        [Key]
        [Column(Order = 0)]
        [Display(Name = "I D")]
        public Int64? ID { get; set; }

        [Display(Name = "Aviator I D")]
        public Int32? Aviator_ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Special Eqpt Name")]
        public String SpecialEqptName { get; set; }

        [StringLength(4000)]
        [Display(Name = "Counter Validation")]
        public String CounterValidation { get; set; }


    }
}
 
