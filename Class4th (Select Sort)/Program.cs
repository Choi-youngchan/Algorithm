namespace Class4th__Select_Sort_
{
    internal class Program
    {
        static void Ab(int[] array) // 내가
        {
            int min = array[0];
            int x = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    x = i;
                }
            }
            int temp = array[0];
            array[0] = min;
            array[x] = temp;
            // for (int i  = 1; i < array.Length ; i++)
            // {
            //     if (array[i] < min)
            //     {
            //         min = array[i];
            //         x = i;
            //     }
            // }
            // temp = array[0];
            // array[0] = min;
            // array[x] = temp;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            #region 선택 정렬
            // 주어진 리스트 중에 최소값을 찾아서 맨 앞에 위치한 결과를 교체하는 방식으로 정렬는 알고리즘입니다.

            #endregion

            int[] array = { 6, 5, 7, 3, 9 };
            for (int i = 0; i < array.Length; i++)
            {
                int min = array[i];
                int select = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (min > array[j])
                    {
                        min = array[j];

                        select = j;
                    }
                }
                int temp = array[i];
                array[i] = array[select];
                array[select] = temp;

            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }
    }
}
