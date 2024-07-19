namespace Class12th__Merge_Sort_
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
                Merge(array, start, middle, end);
            }
        }
        static void Merge(int[] array, int start, int middle, int end)
        {
            int count = 0;
            int left = start;
            int right = middle + 1;

            int[] tempArray = new int[end - start + 1];
            // 
            while (left <= middle && right <= end)
            {
                if (array[left] <= array[right])
                {
                    tempArray[count++] = array[left++];
                }
                else
                {
                    tempArray[count++] = array[right++];
                }
            }
            // 남은 왼쪽 배열의 요소들을 복사합니다.
            while (left <= middle)
            {
                tempArray[count++] = array[left++];
            }
            // 남은 오른쪽 배열의 요소들을 복사합니다.
            while (right <= end)
            {
                tempArray[count++] = array[right++];
            }
            // 원본 배열에 정렬된 임시 배열의 값을 복사합니다.
            for (int i = 0; i < tempArray.Length; i++)
            {
                array[start + i] = tempArray[i];
            }
        }
        static void MergeMe(int[] array, int start, int end)
        {
            //  int[] arrayLeft = new int[(end - start) + 1];
            //  int[] arrayRight = new int[(end - start) + 1];
            //  int left = start;
            //  int right = end;
            //  int count = 0;
            //  while(right < arrayLeft.Length)
            //  {
            //      if (array[left] > array[right])
            //      {
            //          arrayLeft[left] = array[right];
            //          arrayLeft[right] = array[left];
            //          left++; right++;
            //      }
            //      else
            //      {
            //          arrayLeft[left] = array[left];
            //          arrayLeft[right] = array[right]; 
            //          start++; right++;
            //      }
            //  }
            //  for( int i = count; i <= end; i++ ) 
            //  {
            //      array[i] = arrayLeft[i];
            //  }
            //  left = end + 1;
            //  right = (end+1) * 2 - 1 ;
            //  int x = 0;
            //  while (x < arrayRight.Length-1)
            //  {
            //      if (array[left] > array[right])
            //      {
            //          arrayRight[x] = array[right];
            //          arrayRight[x+1] = array[left];
            //          left++; right++; x++;
            //      }
            //      else
            //      {
            //          arrayRight[x] = array[left];
            //          arrayRight[x+1] = array[right];
            //          left++; right++; x++;
            //      }
            //  }
            //  for (int i = count; i < right-left+1 ; i++)
            //  {
            //      array[left-1+i] = arrayRight[i];
            //  }
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

            int[] array = new int[] { 21, 10, 12, 20, 25, 13, 15, 22 };

            int start = 0;
            int end = array.Length - 1;
            MergeSort(array, start, end);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            #endregion
        }
    }
}
