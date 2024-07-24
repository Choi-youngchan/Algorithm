namespace Class16th___Euclid_Algorithm_
{
    internal class Program
    {
        static int A(int a, int b) // 내가 만든 최대공약수 알고리즘
        {
            int x = 1;
            for (int i = 2; i < a && i < b; i++)
            {
                while ((a % i == 0) && (b % i == 0))
                {
                    x = i * x;
                    a = a / i; b = b / i;
                }
            }
            return x;
        }
        static int Euclid(int a, int b)
        {
            int x = Math.Max(a, b);
            int y = Math.Min(a, b);
            int z = x % y;
            if (z == 0)
            {
                return y;
            }
            else
            {
                return (Euclid(y, z));
            }

        }
        static void Main(string[] args)
        {
            #region 유클리드 호제법
            // 2개의 자연수 또는 정식의 최대공약수를 구하는 알고리즘으로,
            // 두 수가 서로 상대방 수를 나누어서 원하는 수를 얻어내는 알고리즘입니다.

            int x = 44;
            int y = 48;
            int result = 0;

            for (int i = 1; i <= Math.Min(x, y); i++)
            {
                if (x % i == 0 && y % i == 0)
                {
                    result = i;
                }
            }

            // Console.WriteLine(result);

            Console.WriteLine(Euclid(78696, 19332));

            // Console.WriteLine(A(128,32));
            #endregion
        }
    }
}
