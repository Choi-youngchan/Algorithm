namespace Program
{
    internal class Program
    {
        static void Sosu(int x)
        {
            int count = 0;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    count = count + 1 ;
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
        static void Main(string[] args)
        {
             int x = int.Parse(Console.ReadLine());
             Sosu(x);
             Console.WriteLine(IsPrime(x));

            #region 에라토스테네스의 체
            // 소수를 판정하는 방법으로, 자연수를 순서대로 늘어놓은 표에서 합성수를 차례대로 지원가면서
            // 소수의 목록을 얻어내는 방법입니다.
            #endregion
        }
    }
}
