namespace Class23th__prefix_Sum_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 누적 합
            // 특정한 배열이 있을 때 해당 배열까지의 합을 의미합니다.


            int[] array = { 7, 3, 4, 5, 1 };
            for (int i = 1; i < array.Length; i++)
            {
                array[i] += array[i - 1];
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            // 3-4사이의 구간 합
            Console.WriteLine("3과 4사이의 구간 합 : " + (array[4] - array[3 - 1]));
            #endregion
        }
    }
}
