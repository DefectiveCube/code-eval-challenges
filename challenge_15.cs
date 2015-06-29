using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write(BitConverter.IsLittleEndian ? "Little" : "Big");
        Console.WriteLine("Endian");
    }
}