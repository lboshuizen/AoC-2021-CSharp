using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace AoC2021.Solvers
{
    internal static class Day1Sweep
    {
        private static int Part1(this IEnumerable<int> depths)
        {
            return depths
                .Zip(depths.Tail(), (x, y) => y > x)
                .Count(i => i);
        }

        private static IEnumerable<int> Window3Sum(this IEnumerable<int> depths)
        {
            var d2 = depths.Tail();
            var d3 = d2.Tail();

            return depths.ZipWith3(d2, d3, t3 => t3.a + t3.b + t3.c)
                .ToArray();
        }

        public static int Solve(IEnumerable<string> lines)
        {
            return lines
                .Select(int.Parse).ToList()
                .Window3Sum()
                .Part1();
        }
    }
}