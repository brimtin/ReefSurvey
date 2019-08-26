using System;

namespace directory
{
    class Program
    {
        static void Main()
        {
            string filepath = @"C:\Users\Ryan Newman\Desktop\MSSA\Assignments\ISTA 220\GroupProject\ReefSurvey-master\directory\Fish Dump.csv";
                        
            Parser parser = new Parser(filepath);


           // parser.PrintCSV();
        }
    }
}
