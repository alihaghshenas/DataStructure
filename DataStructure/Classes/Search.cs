using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Classes
{
    public class Search
    {
        public int? Linear(int[] array, int key) 
        {
            for (int i = 0; i != array.Length -1; i++)
            {
                if (array[i] == key)
                    return i;
            }

            return null;
        }

        public int? Binary(int[] array, int key) {
            int min = 0;
            int max = array.Length-1;

            while (min <= max) 
            { 
                int mid = (min+max)/2;

                if (array[mid] == key)
                {
                    return mid;
                }
                else if (array[mid] < key)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }

            return null;
        }
    }
}
