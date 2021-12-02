using System;
using System.Collections.Generic;
using System.Linq;

namespace AoC2021.Solvers
{
    public static class Day2Dive
    {
        private static (string, int) Parse(string s)
        {
            var t = s.Split(' ');
            return (t[0], int.Parse(t[1]));
        }

        private static (int, int, int) Move((int fwd, int depth, int aim) position, (string, int) cmd)
            => cmd switch
            {
                ("forward", var n) => (position.fwd + n, position.depth + (position.aim * n), position.aim),
                ("up", var n) => (position.fwd, position.depth, position.aim - n),
                ("down", var n) => (position.fwd, position.depth, position.aim + n),
                _ => throw new InvalidOperationException($"no case for {cmd.Item1}")
            };

        public static int Solve(IEnumerable<string> lines)
        {
            var (x, y, _) = lines
                                  .Select(Parse)
                                  .Aggregate((0, 0, 0), Move);
            return x * y;
        }
    }
}