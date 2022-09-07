using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AA7.Models
{
    [Table("tbl_SearchStore", Schema="dbo")]
    public class dbo_tbl_SearchStore
    {
        [Key]
        [Column(Order = 0)]
        [Required]
        [Display(Name = "Search Type Id")]
        public Int32 SearchStoreID { get; set; }

        [Display(Name = "Search Type Id")]
        public Int32? SearchTypeId { get; set; }

        [Display(Name = "Aviator ID")]
        public Int32? Aviator_Id { get; set; }


    }
}
 
