using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************QUICK SORT************");

            int[] array_for_quickSort = { 1, 2000, 233, 37, 15, 31,2,2,24,33,33};
            int start = 0;
            int end = array_for_quickSort.Length-1;
            
            QSort quick = new QSort();
            quick.quick_sort(array_for_quickSort, start, end);
            foreach(int i in array_for_quickSort)
                Console.Write(" {0} ",i);
            Console.WriteLine();

            Console.WriteLine("************HEAP SORT************");

            int[] array_for_heapSort = { 1000, 700, 5, 37,47, 286, 4, 1, 1,3, 2,777,5648,2};
            int size = array_for_heapSort.Length;
            HeapSort heap = new HeapSort();
            heap.heap_sort(array_for_heapSort,size);
            foreach (int i in array_for_heapSort)
                Console.Write(" {0} ", i);
            Console.WriteLine();

            Console.WriteLine("************Bubble Sort************");

            int[] array_for_bubbleSort = { 123,0, 7, 57684, 500, 286, 1, 2, 1, 3, 2, 777, 5648, 2 };
            
            otherSorts bubble = new otherSorts();
            bubble.bubble_sort(array_for_bubbleSort);
            foreach (int i in array_for_bubbleSort)
                Console.Write(" {0} ", i);
            Console.WriteLine();

            Console.WriteLine("************Selection Sort************");

            int[] array_for_selectionSort = { 56, 0, 7, 258, 4, 9, 1, 2, 5567, 0, 2, 777, 5648, 2 };

            otherSorts selection = new otherSorts();
            selection.selection_sort(array_for_selectionSort);
            foreach (int i in array_for_selectionSort)
                Console.Write(" {0} ", i);
            Console.WriteLine();


            Console.WriteLine("************Insertion Sort************");

            int[] array_for_insertionSort = { 689, 0, 7, 1, 4, 464, 1, 47, 78, 48, 2, 777, 5648, 2 };

            otherSorts insertion = new otherSorts();
            insertion.insertion_sort(array_for_insertionSort);
            foreach (int i in array_for_insertionSort)
                Console.Write(" {0} ", i);
            Console.WriteLine();





        }
    }
}
