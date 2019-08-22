using System;

namespace directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\Ryan Newman\Desktop\MSSA\Assignments\ISTA 220\GroupProject\ReefSurvey-master\external\survey\0-data\FishDump.csv";
            Parser parser = new Parser(filepath);


            parser.PrintCSV();
        }
    }
}
