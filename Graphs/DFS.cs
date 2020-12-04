using System;
using System.Collections.Generic;

namespace  Graphs{
    public class DFS{
        private static bool[] _visisted;
        private static Graph _graph;

        private static List<int> _traversal;
        public static List<int> Traverse(Graph graph, int startVertice){
            _graph = graph;
            _visisted = new bool[graph.Vertices.Length];
            _traversal = new List<int>();

            var start = graph.Vertices[startVertice];

            DoDFS(start);

            return _traversal;
        }

        private static void DoDFS(Graph.GraphNode start)
        {
            if(_visisted[start.Value]) {
                return; }

            _visisted[start.Value] = true;
            _traversal.Add(start.Value);

            foreach(var neighbour in start.AdjList)
                DoDFS(_graph.Vertices[neighbour]);

        }
    }
}