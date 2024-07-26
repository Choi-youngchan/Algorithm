namespace Class19th__Breadth_First_Search_
{
    internal class Program
    {
        public class Graph
        {
            private int size;
            private Queue<int> queue;
            private bool[] visited;
            private List<int>[] graph;

            public Graph()
            {
                size = 8;
                queue = new Queue<int>();
                visited = new bool[size];
                graph = new List<int>[size];
                for (int i = 0; i < size; i++)
                {
                    graph[i] = new List<int>();
                }
            }
            public void Insert(int vertex, int node)
            {
                graph[vertex].Add(node);
                graph[node].Add(vertex);
            }
            public void Search(int start)  // 내가
            {
                int temp;
                queue.Enqueue(start);
                visited[queue.Peek()] = true;
                while (queue.Count != 0)
                {
                    temp = queue.Peek();
                    queue.Dequeue();
                    Console.Write(temp + " ");
                    for (int i = 0; i < graph[temp].Count; i++)
                    {
                        if (visited[graph[temp][i]] == false)
                        {
                            queue.Enqueue(graph[temp][i]);
                            visited[graph[temp][i]] = true;
                        }
                    }
                }
            }
            public void SearchT(int start)
            {
                queue.Enqueue(start);
                visited[start] = true;
                while (queue.Count > 0)
                {
                    int x = queue.Dequeue();
                    Console.Write(x + " ");
                    for (int i = 0; i < graph[x].Count; i++)
                    {
                        int next = graph[x][i];
                        if (visited[next] == false)
                        {
                            queue.Enqueue(next);
                            visited[next] = true;
                        }
                    }
                }
            }
            public void Show()
            {
                for (int i = 0; i < graph.Length; i++)
                {
                    for (int j = 0; j < graph[i].Count; j++)
                    {
                        Console.Write(graph[i][j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            #region 너비 우선 탐색
            // 시작 정점을 방문한 후 시작 정점에 인접한 모든 정점들을 우선 방문하는 방법입니다.

            // 더 이상 방문하지 않은 정점이 없을 때 까지 방문하지 않은 모든 정점들에 대해서도 너비 우선 탐색을 적용합니다.

            Graph graph = new Graph();

            graph.Insert(1, 2);
            graph.Insert(1, 3);
            graph.Insert(2, 3);

            graph.Insert(3, 6);
            graph.Insert(3, 7);

            graph.Insert(2, 4);
            graph.Insert(2, 5);

            graph.Insert(4, 5);
            graph.Insert(6, 7);

            graph.Show();

            graph.Search(1);

            #endregion
        }
    }
}
