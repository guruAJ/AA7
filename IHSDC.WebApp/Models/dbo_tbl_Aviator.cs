using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("tbl_Aviator", Schema="dbo")]
    public class dbo_tbl_Aviator
    {
        [Key]
        [Column(Order = 0)]
        [Required]
        [Display(Name = "Aviator I D")]
        public Int32 Aviator_ID { get; set; }

        [StringLength(20)]
        [Display(Name = "Army Number")]
        public String ArmyNumber { get; set; }

        [StringLength(20)]
        [Display(Name = "Rank")]
        public String Rank { get; set; }

        [StringLength(50)]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [StringLength(50)]
        [Display(Name = "Middle Name")]
        public String MiddleName { get; set; }

        [StringLength(50)]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [Display(Name = "Arm Service I D")]
        public Int32? ArmService_ID { get; set; }

        [Display(Name = "Aircraft I D")]
        public Int32? Aircraft_ID { get; set; }

        [StringLength(4000)]
        [Display(Name = "Unit")]
        public String Unit_ID { get; set; }


        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        [Display(Name = "Date Of Birth")]
        public DateTime? DateOfBirth { get; set; }

      
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        [Display(Name = "Date Of Seniority")]
        public DateTime? DateOfSeniority { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        [Display(Name = "Date Of Wings")]
        public DateTime? DateOfWings { get; set; }

        [StringLength(4000)]
        [Display(Name = "Present Address")]
        public String PresentAddress { get; set; }

        [StringLength(4000)]
        [Display(Name = "Permanent Address")]
        public String PermanentAddress { get; set; }

        [StringLength(50)]
        [Display(Name = "Mobile No")]
        public String MobileNo { get; set; }

        [StringLength(50)]
        [Display(Name = "Landline No")]
        public String LandlineNo { get; set; }

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

        [StringLength(50)]
        [Display(Name = "Spouse Email I D")]
        public String SpouseEmailID { get; set; }

        [StringLength(4000)]
        [Display(Name = "Notes")]
        public String Notes { get; set; }

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

        [StringLength(50)]
        [Display(Name = "Initial Medical Place")]
        public String InitialMedicalPlace { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        [Display(Name = "Initial Medical Date")]
        public DateTime? InitialMedicalDate { get; set; }

        [StringLength(4000)]
        [Display(Name = "Initial Medical Remarks")]
        public String InitialMedicalRemarks { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        [Display(Name = "P A B T Date")]
        public DateTime? PABTDate { get; set; }

        [StringLength(50)]
        [Display(Name = "P A B T Place")]
        public String PABTPlace { get; set; }

        [StringLength(50)]
        [Display(Name = "P A B T Batch")]
        public String PABTBatch { get; set; }

        [StringLength(4000)]
        [Display(Name = "P A B T Remarks")]
        public String PABTRemarks { get; set; }

        [StringLength(4000)]
        [Display(Name = "Validation")]
        public String Validation { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        [Display(Name = "Validation Date")]
        public DateTime? ValidationDate { get; set; }

        [StringLength(4000)]
        [Display(Name = "Counter Validation")]
        public String CounterValidation { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        [Display(Name = "Counter Validation Date")]
        public DateTime? CounterValidationDate { get; set; }

        [Display(Name = "Updated By User I D")]
        public Int32? UpdatedByUserID { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        [Display(Name = "Updated Date Time")]
        public DateTime? UpdatedDateTime { get; set; }

       

        // ComboBox
        public virtual dbo_tbl_ArmService dbo_tbl_ArmService { get; set; }
        public virtual dbo_tbl_Aircraft dbo_tbl_Aircraft { get; set; }

    }
}
 
