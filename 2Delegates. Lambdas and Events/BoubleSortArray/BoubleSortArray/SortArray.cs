using System;
using System.Collections.Generic;

namespace BoubleSortArray
{
    public static class SortArray
    {

        /// <summary>
        /// Sorting of array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static int[][] Sort(int[][] array, Comparison<int[]> comparer) =>
            BoubleSort(array, new Formater(comparer));

        private static int[][] BoubleSort(int[][] array, IComparer<int[]> comparer)
        {
            if (ReferenceEquals(array, null))
                throw new ArgumentNullException(nameof(array));

            if (ReferenceEquals(comparer, null))
                throw new ArgumentNullException(nameof(comparer));

            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length - 1; j++)
                {
                    if(comparer.Compare(array[j], array[j + 1]) > 0 )
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }


        /// <summary>
        /// Swap elements
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public static void Swap(ref int[] left, ref int[] right)
        {
            var temp = left;
            left = right;
            right = temp;
        }

    }
}
