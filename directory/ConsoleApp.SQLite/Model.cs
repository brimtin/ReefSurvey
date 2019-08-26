using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp.SQLServer
{
    public class ReefSurvey : DbContext
    {
        public DbSet<FishInfo> FishInfos { get; set; }
        public DbSet<FishName> FishNames { get; set; }
        public DbSet<FishObserved> FishObserveds { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Survey> Surveys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=testDB;Integrated Security=true");
        }
    }

    public class FishInfo
    {
        public int FishInfoID { get; set; }
        public int MetricID { get; set; }
        public float FishLength { get; set; }
        public string StructureType { get; set; }
        public FishObserved FishObserved { get; set; }
    }

    public class FishName
    {
        public int FishNameID { get; set; }
        public string ScientificName { get; set; }
        public string CommonName { get; set; }
        
    }

    public class FishObserved
    {
        public int FishObservedID { get; set; } // Observation
        public int MetricID { get; set; }
        public int LocationID { get; set; }
        public string Family { get; set; }
        public string Trophic { get; set; }
        public Location Location { get; set; }
    }

    public class Location
    {
        public int LocationID { get; set; }
        public int RegionID { get; set; }
        public float Longitude { get; set; }
        public float Latitude { get; set; }
        public Region Region { get; set; }
    }

    public class Region
    {
        public int RegionID { get; set; }
        public string RegionName { get; set; }
        public string SubRegionName { get; set; }
    }

    public class Survey
    {
        public int SurveyID { get; set; }
        public int ObservationID { get; set; }
        public int SurveyIndex { get; set; }
        public string BatchCode { get; set; }
        public string StudyArea { get; set; }
        public string SurveyDate { get; set; }
        public string SurveyYear { get; set; }
        public string Management { get; set; }
        public int FishCount { get; set; }
    }
}