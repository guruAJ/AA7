using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("SearchAviator", Schema="dbo")]
    public class dbo_SearchAviator
    {
        [StringLength(20)]
        [Display(Name = "Army Number")]
        public String ArmyNumber { get; set; }

        [StringLength(20)]
        [Display(Name = "Rank")]
        public String Rank { get; set; }

        [Key]
        [Column(Order = 2)]
        [Required]
        [Display(Name = "Aviator I D")]
        public Int32 Aviator_ID { get; set; }

        [StringLength(152)]
        [Display(Name = "Name")]
        public String Name { get; set; }

        public string fullName { get { return ArmyNumber + " - " + Rank + " - " + Name; } }

        [StringLength(20)]
        [Display(Name = "Arm Service Name")]
        public String ArmServiceName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Aircraft Name")]
        public String AircraftName { get; set; }

        [StringLength(4000)]
        [Display(Name = "Unit")]
        public String Unit { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Of Birth")]
        public DateTime? DateOfBirth { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Of Seniority")]
        public DateTime? DateOfSeniority { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Of Wings")]
        public DateTime? DateOfWings { get; set; }

        [StringLength(50)]
        [Display(Name = "Mobile No")]
        public String MobileNo { get; set; }

        [StringLength(50)]
        [Display(Name = "Email I D")]
        public String EmailID { get; set; }

        [StringLength(50)]
        [Display(Name = "Next Of Kin")]
        public String NextOfKin { get; set; }

        [StringLength(20)]
        [Display(Name = "N O K Relationship")]
        public String NOKRelationship { get; set; }

        [StringLength(20)]
        [Display(Name = "Marital Status")]
        public String MaritalStatus { get; set; }

        [StringLength(50)]
        [Display(Name = "Spouse Name")]
        public String SpouseName { get; set; }

        [StringLength(50)]
        [Display(Name = "Spouse Mobile No")]
        public String SpouseMobileNo { get; set; }

        [StringLength(4000)]
        [Display(Name = "Hill Flying Qualified")]
        public String HillFlyingQualified { get; set; }

        [StringLength(20)]
        [Display(Name = "Hill Flying Height Clearance")]
        public String HillFlyingHeightClearance { get; set; }

        [StringLength(4000)]
        [Display(Name = "Attack Helicopter")]
        public String AttackHelicopter { get; set; }

        [StringLength(4000)]
        [Display(Name = "Deck Landing")]
        public String DeckLanding { get; set; }

        [Display(Name = "Cat Card No")]
        public Int32? CatCardNo { get; set; }

        [StringLength(4000)]
        [Display(Name = "Counter Validation")]
        public String CounterValidation { get; set; }

        [StringLength(50)]
        [Display(Name = "Unit Formation")]
        public String UnitFormation { get; set; }

        
    }
}
 
