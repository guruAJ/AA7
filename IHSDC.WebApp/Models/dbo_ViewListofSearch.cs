using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("ViewListofSearch", Schema="dbo")]
    public class dbo_ViewListofSearch
    {
        [Key]
        [Column(Order = 0)]
        [Display(Name = "I D")]
        public Int64? ID { get; set; }

        [Required]
        [Display(Name = "Sno")]
        public Int32 Sno { get; set; }

        [Display(Name = "Sno")]
        public Int32 SearchTypeId { get; set; }

        [Display(Name = "Searched By")]
        public Int32? SearchedBy { get; set; }

        [Display(Name = "Aviator I D")]
        public Int32? Aviator_ID { get; set; }

        [StringLength(20)]
        [Display(Name = "Army Number")]
        public String ArmyNumber { get; set; }

        [StringLength(152)]
        [Display(Name = "Name")]
        public String Name { get; set; }

        [StringLength(20)]
        [Display(Name = "Arm Service Name")]
        public String ArmServiceName { get; set; }

        [StringLength(50)]
        [Display(Name = "Aircraft Name")]
        public String AircraftName { get; set; }


        [StringLength(4000)]
        [Display(Name = "Heading")]
        public String SearchHeading { get; set; }

        [StringLength(4000)]
        [Display(Name = "Unit")]
        public String Unit { get; set; }


    }
}
 
