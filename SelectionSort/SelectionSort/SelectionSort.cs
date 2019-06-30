using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class SelectionSort
    {
        public static void Sort<T>(T[] arr) where T : IComparable {
            for (int i = 0; i < arr.Length - 1; i++) {
                int smallest = i;

                for (int j = i + 1; j < arr.Length; j++) {
                    if (Less(arr[j], arr[smallest])) {
                        smallest = j;
                    }
                }

                Swap(arr, smallest, i);
            }
        }

        private static bool Less(IComparable first, IComparable second) {
            return first.CompareTo(second) < 0;
        }

        private static void Swap<T>(T[] arr, int from, int to) {
            T temp = arr[from];
            arr[from] = arr[to];
            arr[to] = temp;
        }
    }
}

