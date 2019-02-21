using System;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

namespace Dewey.MapReduce.Example.Mapper
{
    public class Program
    {
        private readonly static int STREET_FIRST = 7;
        private readonly static int STREET_LAST = 8; 
        static void Main(string[] args)
        {
          
          
            string line = Console.ReadLine();
            Configuration configuration = new Configuration();
            configuration.Delimiter = ";";
            configuration.HasHeaderRecord = true;
            while (line != null)
            {
                using (var reader = new StringReader(line))
                using (var parser = new CsvParser(reader,configuration))
                {
                    string[] fields;
                    try {
                        fields = parser.Read();
                        Console.WriteLine($"{fields[STREET_FIRST]} {fields[STREET_LAST]}\t1");
                     } catch(Exception ex){}
                }
                line = Console.ReadLine();
           }
        }
    }
}
