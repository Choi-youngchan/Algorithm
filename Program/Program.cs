namespace Program
{
    internal class Program
    { 
        static bool Complete(int n)
        {
            int x = 1;
            int z = 0;
            int b = n;
            for (int i = 2; i <= b; i++)
            {
                while (b % i == 0)
                {
                    int y = x * i;
                    x = 1 + y;
                    b = b / i;
                }
            }
            if( x == n )
            {
                return true;
            }
            else 
            { 
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.Write(Complete(24));
        }
    }
}
