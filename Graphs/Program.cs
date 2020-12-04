using System;

namespace Graphs
{
    class Program
    {

        static void Main(string[] args)
        {
            DoTopologicalSort(14, new[] { new[] {0,2 }, new[] { 0, 3 }, new[] { 0, 6 }, new[] { 1,4 }, new[] { 2,6 },
            new[] {3,1 },new[] {3,4 },new[] {4,5 },new[] {4,8 },new[] {6,7 },new[] {6,11 },
            new[] {7,4},new[] {7, 12 },new[] {9,2 },new[] {9,10 },new[] {10,6 },new[] {11,12 }});

            DoDFS(14, new[] { new[] {0,2 }, new[] { 0, 3 }, new[] { 0, 6 }, new[] { 1,4 }, new[] { 2,6 },
            new[] {3,1 },new[] {3,4 },new[] {4,5 },new[] {4,8 },new[] {6,7 },new[] {6,11 },
            new[] {7,4},new[] {7, 12 },new[] {9,2 },new[] {9,10 },new[] {10,6 },new[] {11,12 }});
        }

        private static void DoDFS(int v, int[][] vs)
        {
            Console.WriteLine();
            
            var graph = new Graph(v, vs);
            var dfs = DFS.Traverse(graph,0);
            foreach (var t in dfs)
                    Console.Write($"{t} ");
        }

        private static void DoTopologicalSort(int N, int[][] edges)
        {
            var graph = new Graph(N, edges);

            var topologicalOrder = TopologicalOrder.DoTopologicalSort(graph);

            if (topologicalOrder.Count < N) Console.WriteLine("Not a DAG");
            else
                foreach (var t in topologicalOrder)
                    Console.Write($"{t} ");
        }
    }
    
}
