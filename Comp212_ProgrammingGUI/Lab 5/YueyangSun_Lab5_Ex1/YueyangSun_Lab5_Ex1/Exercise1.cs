using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueyangSun_Lab5_Ex1
{
    public static class Exercise1
    {
        public static int Search<T>(T[] array, T item) where T : IComparable<T>
        {
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (item.CompareTo(array[i]) == 0) index = i;
            }
            return index;
        }
    }
}
