using System;
using System.IO;
using System.Collections.Generic;

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

                var nums = line.Split(',');
                int value = int.Parse(nums[0]);
                int multiple = int.Parse(nums[1]);

                int start = multiple;
                int end = value;

                while (start < end)
                {
                    start += multiple;
                }

                Console.WriteLine(start);
            }
    }
}