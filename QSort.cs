using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class QSort
    {
        static void swapp(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public int partition(int []array,int start,int end)
        {
            int pivot = array[end];
            int partition_index = start;
            for(int i = start; i < end ; i++)
            {
                if (array[i] <= pivot)
                {
                    swapp(ref array[i],ref array[partition_index]);
                    partition_index++;
                }

            }
            swapp(ref array[partition_index], ref array[end]);
            return partition_index;   
        }

        public void quick_sort(int []array,int start,int end)
        {
            if (start < end)
            {
                int partition_index = partition(array, start, end);
                quick_sort(array, start, partition_index - 1);
                quick_sort(array, partition_index+ 1, end);
            }
        }

    }
}
