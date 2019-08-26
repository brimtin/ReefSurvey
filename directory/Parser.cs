using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using ReefTest.Parser;
using ConsoleApp.SQLite.Migrations;
using ConsoleApp.SQLServer;

namespace directory
{
    class Parser
    {
        string filepath { get; set; }

        public Parser(string filepath)
        {
            this.filepath = filepath;
        }
        public void PrintCSV()
        {
            bool arb = false;
            foreach (string csvLine in File.ReadLines(filepath))                      
            {
                
                if (arb == false)
                {
                    arb = true;
                    continue;
                }
                csvLine.Trim();
                var commaParsing = csvLine.Split(",");
                try
                {
                    using (var tempDB = new ReefSurvey())
                    {
                        var region = new Region { RegionName = commaParsing[0], SubRegionName = commaParsing[1],  };
                        tempDB.Regions.Add(region);

                        var location = new Location { Region = region, Longitude = float.Parse(commaParsing[8]), Latitude = float.Parse(commaParsing[7]) };
                        tempDB.Locations.Add(location);

                        var fishName = new FishName { ScientificName = commaParsing[12], CommonName = commaParsing[13] };
                        tempDB.FishNames.Add(fishName);

                        var fishObserved = new FishObserved { Location = location, Family = commaParsing[11], Trophic = commaParsing[14] };
                        tempDB.FishObserveds.Add(fishObserved);

                        var fishInfo = new FishInfo { FishObserved = fishObserved, FishLength = float.Parse(commaParsing[15]), StructureType = commaParsing[10] };
                        tempDB.FishInfos.Add(fishInfo);

                        var survey = new Survey { SurveyIndex = int.Parse(commaParsing[5]), BatchCode = commaParsing[4], StudyArea = commaParsing[2], SurveyDate = commaParsing[6], SurveyYear = commaParsing[3], Management = commaParsing[9], FishCount = int.Parse(commaParsing[16]) };
                        tempDB.Surveys.Add(survey);
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Out of Range");
                    break;
                }
            }


            Console.WriteLine();
        }

    }
}
