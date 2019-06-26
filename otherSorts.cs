using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class otherSorts
    {
        static void swapp(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public void bubble_sort(int []array)
        {
            bool needSort;
            for (int i = 0; i < array.Length-1; i++)
            {
                needSort = false;
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        swapp(ref array[j], ref array[j + 1]);
                        needSort = true;
                    }
                }
                if (!needSort)
                    break;
            }
        }


        public void selection_sort(int [] array)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for(int j = i + 1; j < array.Length ; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                if (i != min)
                {
                    swapp(ref array[i],ref array[min]);
                }
            }
        }

        public void insertion_sort(int[] array)
        {
            for (int i = 1; i < array.Length ; i++)
            {
                int j = i;
                while(j>0 && array[j - 1] > array[j])
                {
                    swapp(ref array[j], ref array[j - 1]);
                    j--;
                }
            }
        }


    }
}
