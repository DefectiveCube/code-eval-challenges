using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;

                var data = line.Split(',').Select(x => int.Parse(x));
                var count = data.Count() / 2.0;
                var result = data.GroupBy(x => x).Where(x => x.Count() > count).Select(x => x.Key).FirstOrDefault();

                Console.WriteLine(result > 0 ? result.ToString() : "None");
            }
    }
}