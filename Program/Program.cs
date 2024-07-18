using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace Program
{
    internal class Program
    {
        static void MergeSort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int middle = (start + end) / 2;
                MergeSort(array, start, middle);
                MergeSort(array, middle + 1, end);
                Merge(array, start, end);
            }
        }
        static void Merge(int[] array , int start, int end)
        {
            int[] arrayLeft = new int[(end - start) + 1];
            int[] arrayRight = new int[(end - start) + 1];
            int left = start;
            int right = end;
            int count = 0;
            while(right < arrayLeft.Length)
            {
                if (array[left] > array[right])
                {
                    arrayLeft[left] = array[right];
                    arrayLeft[right] = array[left];
                    left++; right++;
                }
                else
                {
                    arrayLeft[left] = array[left];
                    arrayLeft[right] = array[right]; 
                    start++; right++;
                }
            }
            for( int i = count; i <= end; i++ ) 
            {
                array[i] = arrayLeft[i];
            }
            left = end + 1;
            right = (end+1) * 2 - 1 ;
            while (end < arrayRight.Length)
            {
                if (array[left] > array[right])
                {
                    arrayRight[left] = array[right];
                    arrayRight[right] = array[left];
                    left++; right++;
                }
                else
                {
                    arrayRight[left] = array[left];
                    arrayRight[right] = array[right];
                    left++; right++;
                }
            }
            for (int i = count; i < end; i++)
            {
                array[i] = arrayRight[i];
            }
            Merge(array, start, end);

        }
        static void Main(string[] args)
        {
            #region 병합 정렬
            // 하나의 리스트를 두개의 균등한 크기로 분할하고 분할된 부분 리스트를 정렬한 다음,
            // 두 개의 정렬된 부분 리스트를 합하여 전체가 정렬된 리스트가 되게 하는 방법입니다.

            // 1. 리스트의 길이가 0 또는 1이면 이미 정렬된 것으로 봅니다.
            // 2. 그렇지 않은 경우 
            // 2-1. 정렬되지 않은 리스트를 절반으로 잘라 비슷한 크기의 두 부분 리스트로 나눕니다.
            // 2-2. 각 부분 리스트를 재귀적으로 병합 정렬을 이용해 정렬합니다.
            // 2-3. 두 부분 리스트를 다시 하나의 정렬된 리스트로 병합합니다.

            int[] array = new int[] {21,10,12,20,25,13,15,22 };

            int start = 0;
            int end = array.Length - 1;
            MergeSort(array, start, end);


            #endregion
        }
    }
}



