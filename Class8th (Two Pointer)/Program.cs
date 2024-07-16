namespace Class8th__Two_Pointer_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 투 포인터
            // 두 개의 포인터를 두고 값들을 비교하여 문제를 해결하는 알고리즘입니다.
            //1. M(5)시작점과 끝점이 첫번째 원소의 인덱스를 가리키게한다
            //2. 현재 부분합이 M과 같다면 카운트한다
            //3. 현재 부분합이 M보다 작다면 end 1증가
            //4. M보다 크거나 같다면 start 1증가
            int[] array = { 1, 2, 5, 2, 5 };
            int M = 5;
            int start = 0;
            int end = 0;
            int count = 0;
            int sum = 0;
            // while (end < array.Length)  // 내가
            // {
            //     if (start == end)
            //     {
            //         if (array[start] == M)
            //         {
            //             count++;
            //         }
            //         if (array[start] < M)
            //         {
            //             end++;
            //         }
            //         else if (array[start] >= M)
            //         {
            //             start++;
            //             end++;
            //         }
            //     }
            //     else
            //     {
            //         if ((array[start] + array[end]) == M)
            //         {
            //             count++;
            //         }
            //         if ((array[start] + array[end]) < M)
            //         {
            //             end++;
            //         }
            //         else if ((array[start] + array[end]) >= M)
            //         {
            //             start++;
            //         }
            //     }
            // }
            // ----------------------------------------------------------------
            // while ( end < array.Length) // 내가
            // {
            //    if(sum == M)
            //    {
            //        count++;
            //    }
            //    if ( sum < M )
            //     {
            //        sum = sum + array[end++];
            //     }
            //    else if ( sum >= M )
            //    {
            //        sum = sum - array[start++];
            //    }
            // }
            //------------------------------------------------
            while (start <= end)
            {
                if (sum >= M)
                {
                    sum -= array[start++];
                }
                else if (end >= array.Length)
                {
                    break;
                }
                else
                {
                    sum += array[end++];
                }
                if (sum == M)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            #endregion
        }
    }
}
