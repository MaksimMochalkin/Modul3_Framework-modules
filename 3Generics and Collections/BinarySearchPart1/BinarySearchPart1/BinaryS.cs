using System;
using System.Collections.Generic;

namespace BinarySearchPart1
{
    public static class BinaryS
    {
        /// <summary>
        /// Binary search
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="element"></param>
        /// <param name="comparison"></param>
        /// <returns></returns>
        public static int BinarySearch<T>(this List<T> list, T element, Comparison<T> comparison)
        {
            var left = 0;
            var right = list.Count - 1;
            var mid = right / 2;

            while(left <= right)
            {
                var result = comparison(list[mid], element);
                if (result == 0)
                    return mid;
                else if(result < 0)
                {
                    left = mid + 1;
                    mid = (left + right) / 2;
                }
                else if(true)
                {
                    right = mid - 1;
                    mid = (left + right) / 2;
                }
            }

            return -1;
        }

        /// <summary>
        /// Binary search with interface
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="element"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static int BinarySearch<T>(this List<T> list, T element, IComparer<T> comparer)
        {
            return BinarySearch<T>(list, element, comparer.Compare);
        }

        public static int BinarySearch<T>(this List<T> list, T element)
        {
            if(element is IComparable)
            {
                IComparer<T> comparer = Comparer<T>.Default;
                return BinarySearch<T>(list, element, comparer.Compare);
            }
            else
                throw new InvalidOperationException("Specified type does't implement IComparable<" + element.GetType() + "> interface");
        }
    }
}
