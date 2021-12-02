using System;
using System.Collections.Generic;
using System.Linq;

namespace AoC2021
{
    internal static class Extensions
    {
        public static IEnumerable<TR> ZipWith3<T1,T2,T3,TR>(
            this IEnumerable<T1> first, 
            IEnumerable<T2> second,
            IEnumerable<T3> third,
            Func<(T1 a, T2 b, T3 c), TR> selector)
        {
            return Zip3(first,second,third)
                .Select(selector);
        }

        public static IEnumerable<(T1,T2,T3)> Zip3<T1,T2,T3>(
            this IEnumerable<T1> first, 
            IEnumerable<T2> second,
            IEnumerable<T3> third)
        {
            return first.Zip(second, (a, b) => (a, b))
                .Zip(third, (t, c) => (t.a, t.b, c));
        }
        
        public static IEnumerable<T> Tail<T>(this IEnumerable<T> xs) => xs.Skip(1);
    }
}