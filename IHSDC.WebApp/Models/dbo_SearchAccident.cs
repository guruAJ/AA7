using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("SearchAccident", Schema="dbo")]
    public class dbo_SearchAccident
    {
        [Key]
        [Column(Order = 0)]
        [Display(Name = "I D")]
        public Int64? ID { get; set; }

        [Display(Name = "Aviator I D")]
        public Int32? Aviator_ID { get; set; }

        [StringLength(4000)]
        [Display(Name = "Unit Name")]
        public String UnitName { get; set; }

        [StringLength(50)]
        [Display(Name = "Accident Cat")]
        public String AccidentCat { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Of Accident Incident")]
        public DateTime? DateOfAccidentIncident { get; set; }

        [StringLength(4000)]
        [Display(Name = "Place Of Accident Incident")]
        public String PlaceOfAccidentIncident { get; set; }

        [StringLength(4000)]
        [Display(Name = "Details Of Accident Incident")]
        public String DetailsOfAccidentIncident { get; set; }

        [StringLength(4000)]
        [Display(Name = "Blameworthy")]
        public String Blameworthy { get; set; }

        [StringLength(4000)]
        [Display(Name = "Counter Validation")]
        public String CounterValidation { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Aircraft Name")]
        public String AircraftName { get; set; }


    }
}
 
