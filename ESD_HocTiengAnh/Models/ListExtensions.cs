using System;
using System.Collections.Generic;
using System.Linq;

namespace ESD_HocTiengAnh.Models
{
    public static class ListExtensions
    {
        public static List<T> ShuffleTake<T>(this List<T> list, int count)
        {
            var newList = list.Take(count).ToList();
            Shuffle(newList);
            return newList;
        }

        public static void Shuffle<T>(this List<T> list)
        {
            var random = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}