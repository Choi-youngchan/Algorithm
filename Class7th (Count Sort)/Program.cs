namespace Class7th__Count_Sort_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 계수 정렬
            // 데이터의 값을 집적 비교하지 않고, 단순하게 각 숫자가 몇 개 있는지 개수를 세어 저장한 다음 정렬하는 알고리즘입니다.
            int[] array = { 1, 6, 6, 6, 5, 1, 2, 3, 1, 2, 3, 6, 5, 4, };
            int[] count = new int[6];

            for (int i = 0; i < array.Length; i++)
            {
                count[array[i] - 1] += 1;
            }
            for (int j = 0; j < count.Length; j++)
            {
                Console.WriteLine(count[j]);
            }

            #endregion
        }
    }
}
