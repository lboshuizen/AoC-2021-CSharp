using System;
using System.IO;
using AoC2021.Solvers;

namespace AoC2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadLines("../../../Data/day1.txt");
            var r = Day1Sweep.Solve(data);
            Console.WriteLine(r);
        }
    }
}