namespace Class3th__Bubble_Sort_
{
    internal class Program
    {
        static void A(int[] array) // 내가
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Swap(ref array[i], ref array[i + 1]);
                }
            }
        }
        static void Show(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            #region 거품 정렬
            // 서로 인접한 두 원소를 검사하여 정렬하는 알고리즘입니다.
            int[] array = new int[] { 5, 7, 1, 29, 31 };

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < (array.Length - i) - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }

            // A(array);
            // Show(array);
            #endregion

        }
    }
}
