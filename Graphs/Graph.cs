using System.Collections.Generic;

namespace Graphs
{
    public class Graph
    {
        public List<Edge> Edges { get; private set; }
        public GraphNode[] Vertices { get; private set; }
        public Graph(int N, int[][] edges)
        {
            Edges = _InitEdges(edges);
            Vertices = _InitGraph(N);
           
        }

        public class GraphNode
        {
            public int Value { get; private set; }
            public List<int> AdjList { get; private set; }

            public GraphNode(int v, List<int> lists)
            {
                this.Value = v;
                this.AdjList = lists;
            }
        }

        public class Edge
        {
            public int X { get; private set; }
            public int Y { get; private set; }
            public Edge(int x, int y) { X = x; Y = y; }
        }

        private GraphNode[] _InitGraph(int N)
        {
            var vertices = new GraphNode[N];

            for (int i = 0; i < N; i++)
            {
                vertices[i] = new GraphNode(i, new List<int> { });
            }

            //build adjacency list
            foreach (var e in Edges)
            {
                vertices[e.X].AdjList.Add(e.Y);
            }

            return vertices;
        }

        private List<Edge> _InitEdges(int[][] edges)
        {
            var rval = new List<Edge>();
            foreach (var edge in edges)
                rval.Add(new Edge(edge[0], edge[1]));

            return rval;
        }
    }
}
