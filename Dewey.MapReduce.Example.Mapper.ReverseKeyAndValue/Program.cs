﻿using System;

namespace Dewey.MapReduce.Example.Mapper.ReverseKeyAndValue
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
           
            
            while (line != null)
            {
                var parts = line.Split('\t');
                if (parts!=null && parts.Length==2)
                {
                    var value = parts[0];
                    var key = parts[1];
                    Console.WriteLine($"{key}\t{value}");
                } else
                {
                     Console.Error.WriteLine("reporter:counter:Dewey.MapReduce.Example,Bad input lines,1");
                }
                line = Console.ReadLine();
            }
        }
    }
}
