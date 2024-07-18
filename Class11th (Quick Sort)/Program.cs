namespace Class11th__Quick_Sort_
{
    internal class Program
    {
        static void A(int[] array, int start, int end)
        {
            int pivot = 0;    // 내가
            int left = start + 1;
            int right = end;
            while (left <= right)
            {
                if (array[right] > array[pivot])
                {
                    right -= 1;
                }
                else
                {
                    if (array[left] < array[pivot])
                    {
                        left += 1;
                    }
                    else
                    {
                        Swap(ref array[left], ref array[right]);
                    }
                }
                if (left > right)
                {
                    Swap(ref array[pivot], ref array[right]);
                }
                A(array, start, right - 1);
                A(array, right + 1, end);

            }
        }
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void QuickSort(int[] array, int start, int end)
        {
            int pivot = start;
            int left = start + 1;
            int right = end;      // pivot, left, right 변수값 설정
            // 4. left가 right보다 크거나 같을때까지 반복
            if (start >= end)
            {
                return;
            }
            while (left <= right)
            {
                //5. left가 end보다 작거나 같고 array[left]가 array[pivot]보다 작거나 같을 때 까지 반복합니다.
                while (left <= end && array[pivot] >= array[left])
                {
                    left++;
                }
                // 6. right가 start보다 크고 list[right]가 list[pivot]보다 크거나 같을 때 까지 반복합니다.
                while (right > start && array[pivot] <= array[right])
                {
                    right--;
                }
                if (left > right)
                {
                    Swap(ref array[pivot], ref array[right]);
                }
                else
                {
                    Swap(ref array[left], ref array[right]);
                }
                // 8. 피벗을 기준으로 나누어진 두 번째 배열에 대해 재귀적으로 퀵 정렬을 호출합니다.
            }
            QuickSort(array, right + 1, end);
            QuickSort(array, start, right - 1);
        }
        static void Main(string[] args)
        {
            #region 퀵 정렬
            // 기준점을 획득한 다음 해당 기준점을 기준으로 배열을 나누고 한 쪽에는 기준점보다 작은 값들이 위치하고
            // 다른 한쪽에는 기준점보다 큰값들이 위치하도록 합니다.

            // 나누어진하위 배열에 대해 재귀적으로 퀵 정렬을 호출하여 모든 배열이 기본 배열이 될 때 까지 반복하면서 정렬합니다.

            // 퀵 정렬은 평균적으로 O(n log n)의 시간 복잡도를 가지며, 최악의 경우 O(n²)의 시간 복잡도를 가집니다.

            // 1. 기준점을 선택합니다.
            // 2. 기준점을 기준으로 왼쪽은 큰 값, 오른쪽은 기준점보다 작은 값을 탐색합니다.
            // 3. 양 방향에서 찾은 두 원소를 교환합니다.
            // 4. 왼쪽에서 탐색하는 위치와 오른쪽에서탐색하는 위치가 엇갈리지 않을 때 까지 2번으로 돌아가 위의 과정을 반복합니다.
            // 5. 엇갈린 기점을 기준으로 두개의 부분 리스트로 나누어 1번으로 돌아가 해당 부분 리스트의 길이가 1이 될 때 까지 반복합니다.
            // 6. 인접한 부분 리스트끼리 합하여 수행합니다.

            #endregion

            int[] array = { 5, 13, 7, 2, 11, 6, 8, 9, 3, 4, 10 };
            int start = 0;
            int end = array.Length - 1;
            //  A(array,start,end);
            QuickSort(array, start, end);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            // 5, 3, 8, 9, 2, 4, 7, / 
        }
    }
}
