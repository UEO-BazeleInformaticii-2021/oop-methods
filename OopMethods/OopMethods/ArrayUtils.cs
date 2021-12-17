using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopMethods
{
    public static class ArrayUtils
    {
        public static int IndexOf(int[] array, int element)
        {
            return IndexOf(array, element, 0, array.Length - 1);
        }

        private static int IndexOf(int[] array, int element, int startIndex, int endIndex)
        {
            if (array is null ||
                array.Length == 0 ||
                startIndex < 0 ||
                endIndex >= array.Length ||
                startIndex > endIndex)
            {
                return -1;
            }

            int middleIndex = (startIndex + endIndex) / 2;
            if (element == array[middleIndex])
            {
                return middleIndex;
            }
            else
            {
                if (element < array[middleIndex])
                {
                    return IndexOf(array, element, startIndex, middleIndex);
                }
                else
                {
                    return IndexOf(array, element, middleIndex + 1, endIndex);
                }
            }
        }
    }
}
