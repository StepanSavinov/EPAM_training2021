using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace epamXT
{
    static class SuperArray
    {
        public static void ArrayAction<T>(this T[] arr, Func<T, T> func)
        {
            if (func != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = func(arr[i]);
                }
            }

            else { throw new ArgumentNullException(); }
        }

        public static T MostFrequent<T>(this T[] arr) => arr.GroupBy(el => el).OrderByDescending(array => array.Count()).First().Key;

        public static int Summ(this int[] arr) => arr.Sum();

        public static float Average(this int[] arr) => arr.Summ() / arr.Length;
    }
}
