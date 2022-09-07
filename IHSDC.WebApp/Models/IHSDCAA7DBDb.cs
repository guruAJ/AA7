using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace AA7.Models
{
    public class IHSDCAA7DBDBContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<dbo_SearchGEB>().ToTable("dbo.SearchGEB");
            modelBuilder.Entity<dbo_SearchAviatorSplEqpt>().ToTable("dbo.SearchAviatorSplEqpt");
            modelBuilder.Entity<dbo_SearchAviatorSplQual>().ToTable("dbo.SearchAviatorSplQual");
            modelBuilder.Entity<dbo_SearchFlyingHrs>().ToTable("dbo.SearchFlyingHrs");
            modelBuilder.Entity<dbo_SearchMedical>().ToTable("dbo.SearchMedical");
            modelBuilder.Entity<dbo_SearchPosting>().ToTable("dbo.SearchPosting");
            modelBuilder.Entity<dbo_SearchAccident>().ToTable("dbo.SearchAccident");
            modelBuilder.Entity<dbo_SearchHonourAward>().ToTable("dbo.SearchHonourAward");
            modelBuilder.Entity<dbo_SearchCourse>().ToTable("dbo.SearchCourse");
            modelBuilder.Entity<dbo_tbl_SearchStore>().ToTable("dbo.tbl_SearchStore");
            modelBuilder.Entity<dbo_SearchAviator>().ToTable("dbo.SearchAviator");
            modelBuilder.Entity<dbo_tbl_SearchType>().ToTable("dbo.tbl_SearchType");
            modelBuilder.Entity<dbo_ViewListofSearch>().ToTable("dbo.ViewListofSearch");
            modelBuilder.Entity<dbo_tbl_SeacrhHeading>().ToTable("dbo.tbl_SeacrhHeading");
            modelBuilder.Entity<dbo_FullHierarchy>().ToTable("dbo.FullHierarchy");
            modelBuilder.Entity<dbo_tbl_Aircraft>().ToTable("dbo.tbl_Aircraft");
            modelBuilder.Entity<dbo_tbl_ArmService>().ToTable("dbo.tbl_ArmService");
            modelBuilder.Entity<dbo_tbl_Aviator>().ToTable("dbo.tbl_Aviator");
            modelBuilder.Entity<dbo_tbl_AviatorAccidentIncident>().ToTable("dbo.tbl_AviatorAccidentIncident");
            modelBuilder.Entity<dbo_tbl_AviatorCourses>().ToTable("dbo.tbl_AviatorCourses");
            modelBuilder.Entity<dbo_tbl_AviatorFlyingHrs>().ToTable("dbo.tbl_AviatorFlyingHrs");
            modelBuilder.Entity<dbo_tbl_AviatorGEBPerformance>().ToTable("dbo.tbl_AviatorGEBPerformance");
            modelBuilder.Entity<dbo_tbl_AviatorHonourAwards>().ToTable("dbo.tbl_AviatorHonourAwards");
            modelBuilder.Entity<dbo_tbl_AviatorMedical>().ToTable("dbo.tbl_AviatorMedical");
            modelBuilder.Entity<dbo_tbl_AviatorPosting>().ToTable("dbo.tbl_AviatorPosting");
            modelBuilder.Entity<dbo_tbl_AviatorSpecialEqpt>().ToTable("dbo.tbl_AviatorSpecialEqpt");
            modelBuilder.Entity<dbo_tbl_AviatorSpecialQual>().ToTable("dbo.tbl_AviatorSpecialQual");
            modelBuilder.Entity<dbo_tbl_Courses>().ToTable("dbo.tbl_Courses");
            modelBuilder.Entity<dbo_tbl_SpecialEqpt>().ToTable("dbo.tbl_SpecialEqpt");
            modelBuilder.Entity<dbo_tbl_SpecialQual>().ToTable("dbo.tbl_SpecialQual");
            modelBuilder.Entity<dbo_tbl_Unit>().ToTable("dbo.tbl_Unit");
            
        }
        
        public DbSet<dbo_SearchGEB> dbo_SearchGEB { get; set; }
        public DbSet<dbo_SearchAviatorSplEqpt> dbo_SearchAviatorSplEqpt { get; set; }

        public DbSet<dbo_SearchAviatorSplQual> dbo_SearchAviatorSplQual { get; set; }

        public DbSet<dbo_SearchFlyingHrs> dbo_SearchFlyingHrs { get; set; }

        public DbSet<dbo_SearchMedical> dbo_SearchMedical { get; set; }

        public DbSet<dbo_SearchPosting> dbo_SearchPosting { get; set; }

        public DbSet<dbo_SearchAccident> dbo_SearchAccident { get; set; }

        public DbSet<dbo_SearchHonourAward> dbo_SearchHonourAward { get; set; }

        public DbSet<dbo_SearchCourse> dbo_SearchCourse { get; set; }
        public DbSet<dbo_tbl_SearchStore> dbo_tbl_SearchStore { get; set; }
        public DbSet<dbo_SearchAviator> dbo_SearchAviator { get; set; }
        public DbSet<dbo_tbl_SearchType> dbo_tbl_SearchType { get; set; }
        public DbSet<dbo_ViewListofSearch> dbo_ViewListofSearch { get; set; }
        public DbSet<dbo_tbl_SeacrhHeading> dbo_tbl_SeacrhHeading { get; set; }
        public DbSet<dbo_FullHierarchy> dbo_FullHierarchy { get; set; }

        public DbSet<dbo_tbl_Aircraft> dbo_tbl_Aircraft { get; set; }

        public DbSet<dbo_tbl_ArmService> dbo_tbl_ArmService { get; set; }

        public DbSet<dbo_tbl_Aviator> dbo_tbl_Aviator { get; set; }

        public DbSet<dbo_tbl_AviatorAccidentIncident> dbo_tbl_AviatorAccidentIncident { get; set; }

        public DbSet<dbo_tbl_AviatorCourses> dbo_tbl_AviatorCourses { get; set; }

        public DbSet<dbo_tbl_AviatorFlyingHrs> dbo_tbl_AviatorFlyingHrs { get; set; }

        public DbSet<dbo_tbl_AviatorGEBPerformance> dbo_tbl_AviatorGEBPerformance { get; set; }

        public DbSet<dbo_tbl_AviatorHonourAwards> dbo_tbl_AviatorHonourAwards { get; set; }

        public DbSet<dbo_tbl_AviatorMedical> dbo_tbl_AviatorMedical { get; set; }

        public DbSet<dbo_tbl_AviatorPosting> dbo_tbl_AviatorPosting { get; set; }

        public DbSet<dbo_tbl_AviatorSpecialEqpt> dbo_tbl_AviatorSpecialEqpt { get; set; }

        public DbSet<dbo_tbl_AviatorSpecialQual> dbo_tbl_AviatorSpecialQual { get; set; }

        public DbSet<dbo_tbl_Courses> dbo_tbl_Courses { get; set; }

        public DbSet<dbo_tbl_SpecialEqpt> dbo_tbl_SpecialEqpt { get; set; }

        public DbSet<dbo_tbl_SpecialQual> dbo_tbl_SpecialQual { get; set; }

        public DbSet<dbo_tbl_Unit> dbo_tbl_Unit { get; set; }

      

    }
}
 
