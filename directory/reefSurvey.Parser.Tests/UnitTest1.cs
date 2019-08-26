using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ReefTest.Parser;
using Shouldly;
using reefSurvey;

namespace reefSurvey.Parser.Tests
{
    [TestClass]
    public class HeaderTests
    {
        string rawHeader = "Region,SubRegion,StudyArea,SurveyYear,BatchCode,SurveyIndex,SurveyDate,Latitude,Longitude,Management,StructureType,Family,ScientificName,CommonName,Trophic,FishLength,FishCount";
        List<string> ValidHeader = new List<string> { "Region", "SubRegion", "StudyArea", "SurveyYear", "BatchCode", "SurveyIndex", "SurveyDate", "Latitude", "Longitude", "Management", "StructureType", "Family", "ScientificName", "CommonName", "Trophic", "FishLength", "FishCount" };


        [TestMethod]
        public void TestHeaderTokenization()
        {
            var tokenized = HeaderParsing.Tokenize(rawHeader);

            tokenized.ShouldAllBe(v => ValidHeader.Contains(v));
            ValidHeader.ShouldAllBe(v => tokenized.Contains(v));
        }
    }
}
