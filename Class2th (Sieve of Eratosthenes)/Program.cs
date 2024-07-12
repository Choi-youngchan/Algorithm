namespace Class2th__Sieve_of_Eratosthenes_
{
    internal class Program
    {
        static void Sosu(int x) // 내가
        {
            int count = 0;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    count = count + 1;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("소수입니다.");
            }
            else if (count > 0)
            {
                Console.WriteLine("소수가 아닙니다.");
            }
        }
        static bool IsPrime(int x)
        {
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Era(int number) // 내가
        {
            int[] array = new int[number + 1];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            int count = 0;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                for (int j = 2; j <= number; j++)
                    if (i * j != 0 && i * j < array.Length)
                    {
                        array[i * j] = 0;
                    }
            }
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    count++;
                    Console.WriteLine(array[i]);
                }
            }
            Console.WriteLine(count);

        }
        static void Sieve(int n)
        {
            int[] array = new int[n + 1];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (array[i] == 0)
                {
                    continue;
                }
                for (int j = i * 2; j <= n; j += i)
                {
                    array[j] = 0;
                }
            }
            for (int i = 2; i <= n; i++)
            {
                if (array[i] != 0)
                    Console.WriteLine(array[i]);
            }
        }
        static void Main(string[] args)
        {


            //  int x = int.Parse(Console.ReadLine());
            //  Sosu(x);
            //  Console.WriteLine(IsPrime(x));

            #region 에라토스테네스의 체
            // 소수를 판정하는 방법으로, 자연수를 순서대로 늘어놓은 표에서 합성수를 차례대로 지원가면서
            // 소수의 목록을 얻어내는 방법입니다.

            // int number = 200;
            // Era(number);
            // Sieve(number);
            #endregion

        }
    }
}
