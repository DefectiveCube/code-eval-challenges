using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (string.IsNullOrEmpty(line))
                    continue;

                try
                {
                    var str = line.Split(' ')
                        .Select(s => int.Parse(s))
                        .ToArray();

                    if (str.Length != 3)
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                    var results = FizzBuzz(str[0], str[1], str[2]);

                    Console.WriteLine(string.Join(" ", results));
                }
                catch
                {
                    continue;
                }
            }
    }

    static IEnumerable<string> FizzBuzz(int first, int second, int length)
    {
        var nums = Enumerable.Range(1, length);

        var fizz = nums.Select(n => n % first == 0 ? "F" : string.Empty);
        var buzz = nums.Select(n => n % second == 0 ? "B" : string.Empty);

        var fizzBuzz = fizz.Zip(buzz, (f, b) => f + b);

        return nums.Zip(fizzBuzz, (n, fb) => string.IsNullOrEmpty(fb) ? n.ToString() : fb);
    }
}