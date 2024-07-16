using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 이진 탐색
            // 탐색 범위를 반으로 나누어 찾는 값을 포함하는 범위를 좁혀가는 방식으로 동작하는 탐색 알고리즘입니다.
            int[] array = { 1, 4, 7, 9, 15, 21, 24, 31, 35, 47, 79 , 111};
            int left = 0;
            int right = array.Length - 1;
            int num = 115;
            while ( left <= right)
            {
                int middle = (left + right) / 2;
                if (num < array[middle])
                {
                    right = middle - 1;
                }
                else if ( num > array[middle])
                {
                    left = middle + 1;
                }
                else if ( num == array[middle])
                {
                    Console.WriteLine("Found out " + num);
                    break;
                }
                if ( right < left )
                {
                    Console.WriteLine("Cannot find " + num);
                    break;
                }
            }

            #endregion
        }
    }
}



