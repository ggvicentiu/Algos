using System.Collections.Generic;

namespace Graphs
{
    public class TopologicalOrder
    {

        internal static List<int> DoTopologicalSort(Graph graph) {
            var queue = new Queue<int>();
            List<int> topologicalOrder = new List<int>();
            var N = graph.Vertices.Length;
            var indegree = new int[N];


            //build the indegree list
            for (int i = 0; i < N; i++)
            {
                foreach (int a in graph.Vertices[i].AdjList)
                {
                    indegree[a]++;
                }
            }

            //enqueue the vertices without incoming edges, if any
            for (int i = 0; i < N; i++) if (indegree[i] == 0) queue.Enqueue(i);

            while (queue.Count > 0)
            {
                var deq = queue.Dequeue();
                topologicalOrder.Add(deq);

                foreach (int a in graph.Vertices[deq].AdjList)
                {
                    indegree[a]--;
                    if (indegree[a] == 0) queue.Enqueue(a);
                }

            }

            if (topologicalOrder.Count < N)
                return new List<int>();

            return topologicalOrder;
        }
    }
}
