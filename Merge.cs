using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortAssist
{
    public class Merge
    {
        public static void MergeArrays(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            for (int i = 0; i < n1; i++)
            {
                leftArr[i] = arr[left + i];
            }
            for (int j = 0; j < n2; j++)
            {
                rightArr[j] = arr[mid + 1 + j];
            }

            int k = left;
            int leftIndex = 0;
            int rightIndex = 0;

            while (leftIndex < n1 && rightIndex < n2)
            {
                if (leftArr[leftIndex] <= rightArr[rightIndex])
                {
                    arr[k] = leftArr[leftIndex];
                    leftIndex++;
                }
                else
                {
                    arr[k] = rightArr[rightIndex];
                    rightIndex++;
                }
                k++;
            }

            while (leftIndex < n1)
            {
                arr[k] = leftArr[leftIndex];
                leftIndex++;
                k++;
            }

            while (rightIndex < n2)
            {
                arr[k] = rightArr[rightIndex];
                rightIndex++;
                k++;
            }
        }
    }
}
