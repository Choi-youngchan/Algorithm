namespace Class17th__Back_Tracking_
{
    internal class Program
    {
        static void HanoiTower(int n, char from, char by, char to)
        {
            if (n == 1)
            {
                Console.WriteLine("[" + n + "] " + from + " → " + to);
            }
            else
            {
                HanoiTower(n - 1, from, to, by);
                Console.WriteLine("[" + n + "] " + from + " → " + to);
                HanoiTower(n - 1, by, from, to);
            }
        }
        static void Main(string[] args)
        {
            #region 백트래킹
            // 해를 찾아가는 도중에 지금의경로가 해가 될 것 같지 않으면,
            // 더이상 깊이 들어가지 않고, 이전 단계로 다시 돌아가는 알고리즘입니다.

            // 백트래킹의 유망성 판단
            // 해가 될 만한지 판단한 후에 유망하지 않다고 결정되면, 그 노드의 이전 노드로 돌아간 다음 자식 노드로 이동합니다.

            // 해가 될 만한 가능성이 있으면 유망하다.(Promising)
            // 유망하지 않은 노드에 가지 않는 것     (Pruning)


            // 하노이.
            // 막대가 가져야할 정보 : 1. 원판의 크기 2. 원판의 개수
            // 한번에 하나씩 맨위의 원판만 이동.
            // 크기가 작은원판 위에 큰 원판을 쌓을 수 없다.

            HanoiTower(4, 'A', 'B', 'C');

            #endregion
        }
    }
}
