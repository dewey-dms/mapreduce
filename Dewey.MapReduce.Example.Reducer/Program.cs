﻿using System;

namespace Dewey.MapReduce.Example.Reducer
{
    class Program
    {
             public static void Main(string[] args)
        {
            string classification = null;
            var count = 0L;

            //var line = Console.ReadLine();
            var line = "Pułku Piechoty 67\t1";
            while (line != null)
            {
                var parts = line.Split('\t');
                var key = parts[0];
                var value = long.Parse(parts[1]);

                if (key == classification)
                {                    
                    count += value;
                }
                else
                {
                    if (classification != null)
                    {
                        Console.WriteLine($"{classification}\t{count}");
                    }
                    classification = key;
                    count = value;
                }

                line = Console.ReadLine();
            }
            Console.WriteLine($"{classification}\t{count}");
        }
    }
}
