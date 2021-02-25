using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode
{
    class BFS
    {
        public int[] Shortest(int n, int m, int s, IDictionary<int, int[]> edges)
        {
            Queue<int> q = new Queue<int>();
            Dictionary<int, int> visited = new Dictionary<int, int>(n);
            for (int i = 1; i <= n; i++)
            {
                visited.Add(i, -1);
            }

            q.Enqueue(s);
            visited[s] = 0;

            while (q.Count > 0)
            {
                int node = q.Dequeue();
                //visited[node] = 0;
                int[] aaa = edges[node];

                foreach (int i in aaa)
                {
                    if (visited[i] == -1)
                    {
                        visited[i] = visited[node] + 1;
                        q.Enqueue(i);
                    }
                }
            }

            int[] res = visited.Values.ToArray();
            res = res.OrderByDescending(c => c).ToArray();

            return res;
        }

        public void Execute()
        {
            int n, m, s;
            int[][] edges;

            IDictionary<int, int[]> graph = new Dictionary<int, int[]>();

            graph.Add(1, new int[] { 2, 3 });
            graph.Add(2, new int[] { 1 });
            graph.Add(3, new int[] { 1 });

            int[] a = new BFS().Shortest(4, 2, 1, graph);

            foreach (int i in a)
                Console.Write(" " + i);
        }
    }
}
