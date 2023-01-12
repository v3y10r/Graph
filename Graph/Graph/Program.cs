using System;

namespace Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph= new Graph();
            graph.add_v("a");
            graph.add_v("b");
            graph.add_v("c");
            graph.add_e(0, 2, 5);
            graph.add_e(0, 1, 10);
            graph.add_e(2, 1, 15);
            graph.fancyPrint();
        }
    }
}
