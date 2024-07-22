namespace Class13th__Dynamic_Programing_
{
    internal class Program
    {
            static int Fibonacci(int[] array, int x)
            {
                if (x <= 0)
                {
                    array[x] = 0;
                    return 0;
                }
                else if (x == 1)
                {
                    array[x] = 1;
                    return 1;
                }
                else
                {
                    if (array[x - 1] != 0)
                    {
                        int j = array[x - 1]; int k = array[x - 2];
                        array[x] = j + k;
                        return j + k;
                    }
                    int f = Fibonacci(array, x - 1) + Fibonacci(array, x - 2);
                    array[x] = f;
                    return f;
                }
            }
            static int FibonacciA(int[] array, int x)
            {
                if (x <= 0)
                {
                    return 0;
                }
                else if (x == 1)
                {
                    return 1;
                }
                if (array[x] != 0)
                {
                    return array[x];
                }
                return array[x] = Fibonacci(array, x - 1) + Fibonacci(array, x - 2);
            }
            static void Main(string[] args)
            {
                #region 동적 계획법
                // 특정 범위까지의 값을 구하기 위해서 그것과 다른 범위까지의 값을 이용하여 효율적으로 값을 구하는 알고리즘입니다.

                //  메모이제이션
                //  프로그램이 동일한 계산을 반복해야 할 때 이전에 계산한 값을 메모리에 저장함으로써
                //  동일한 계산을 반복수행하는 작업을 제거하여 프로그램의 실행 속도를 향상시키는 기법입니다.
                int[] array = new int[100];
                for (int i = 0; i < 47; i++)
                {
                    Console.Write(FibonacciA(array, i) + ", ");
                }
                #endregion
            }
        }
    }
