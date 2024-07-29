namespace Class20th__Topology_Sort_
{
    internal class Program
    {
        public class Graph
        {
            int size;
            Queue<int> queue;
            List<int>[] graph;
            int[] degree;
            public Graph()
            {
                size = 8;
                queue = new Queue<int>();
                graph = new List<int>[size];
                degree = new int[size];
                for (int i = 0; i < size; i++)
                {
                    graph[i] = new List<int>();
                }
            }
            public void Connect(int vertex1, int vertex2)
            {
                graph[vertex1].Add(vertex2);
                degree[vertex2]++;
            }
            public void Show()
            {
                for (int i = 0; i < graph.Length; i++)
                {
                    for (int j = 0; j < graph[i].Count; j++)
                    {
                        Console.Write(i + " : " + graph[i][j] + " ");
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < degree.Length; i++)
                {
                    Console.Write(i + "노드의 차수 : " + degree[i]);
                    Console.WriteLine();
                }
            }
            public void Sort()
            {
                for (int i = 1; i < degree.Length; i++)
                {
                    if (degree[i] == 0)
                    {
                        queue.Enqueue(i);
                    }
                }
                while (queue.Count > 0)
                {
                    int temp = queue.Dequeue();
                    Console.Write(temp + " ");
                    for (int i = 0; i < graph[temp].Count; i++)
                    {
                        degree[graph[temp][i]]--;
                        if (degree[graph[temp][i]] == 0)
                        {
                            queue.Enqueue(graph[temp][i]);
                        }

                    }
                }

            }
        }

        static void Main(string[] args)
        {
            #region 위상 정렬
            // 방향 그래프에 존재하는 각 정점들의 선행 순서를 지키며, 모든 정점을 차례대로 진행하는 알고리즘입니다.

            // 사이클이 발생하는 경우 위상 정렬을 수행할 수 없습니다.

            // DAG(Directed Acyclic Graph) : 사이클이 존재하지 않는 그래프

            // 시간 복잡도 O(V + E)

            // 위상 정렬하는 방법

            // 1. 진입 차수가 0인 정점을 Queue에 삽입합니다.

            // 2. Queue에서 원소를 꺼내 연결된 모든 간선을 제거합니다.

            // 3. 간선 제거 이후에 진입 차수가 0이 된 정점을 Queue에 삽입합니다.

            // 4. Queue가 비어있을 때 까지 2번 ~ 3번을 반복합니다.


            #endregion
            #region 위상 정렬 예제
            Graph graph = new Graph();
            graph.Connect(1, 2);
            graph.Connect(1, 5);
            graph.Connect(2, 3);
            graph.Connect(5, 6);
            graph.Connect(3, 4);
            graph.Connect(6, 4);
            graph.Connect(4, 7);

            graph.Show();

            graph.Sort();
            #endregion
        }
    }
}
