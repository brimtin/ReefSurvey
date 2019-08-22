using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace directory
{
    class Parser
    {
        string filepath;
        

        public Parser(string filepath)
        {
            this.filepath = filepath;
        }
        public void PrintCSV()
        {
            string readcsv = File.ReadAllText(filepath);
            Console.WriteLine(readcsv);
        }
    }
}
