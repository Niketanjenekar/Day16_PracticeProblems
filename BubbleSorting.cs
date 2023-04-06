using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDemo
{
    internal class BubbleSorting
    {
        public static void BubbleSort()
        {
            int[] arr = { 99, 67, 88, 78, 65, 13, 4, 3, 1 };
            int temp;
            for (int j = 0; j <= arr.Length-2; j++)
            {
                for (int i = 0; i <= arr.Length-2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i+1];
                        arr[i+1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Bubble Sorting");
            foreach(int p in arr){
                Console.WriteLine(p + " ");
            }
        }
    }
}
