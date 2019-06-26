using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HeapSort
    {
        static void swapp(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }



        public void heapify(int []array,int index,int size)
        {
            int left_child = 2 * index+1;
            int right_child = 2 * index + 2;
            int max=index;
            if (left_child < size && array[left_child] > array[max])
            {
                max = left_child;
            }
  
            if (right_child < size && array[right_child] > array[max])
            {
                max = right_child;
            }
            if (max != index)
            {
                swapp(ref array[index],ref array[max]);
                heapify(array, max,size);
            }
        }


        public void BuildMaxHeap(int[] array,int size)
        {
            for(int i = (size / 2)-1; i >= 0; i--)
            {
                heapify(array, i,size);
            }
        }

        public void heap_sort(int[] array,int size)
        {
            
            BuildMaxHeap(array,size);
            for (int i = size - 1; i >= 0; i--)
            {
                swapp(ref array[0], ref array[i]);
                heapify(array, 0,i);
            }
        }

    }
}
