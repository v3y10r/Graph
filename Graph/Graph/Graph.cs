using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    internal class Graph
    {
        public List<List<int>> matrix = new List<List<int>>();
        public List<string> verticesNames = new List<string>();
        public List<int> edgesWeights = new List<int>();
        /*matrix.Add(new List<int>());
            matrix[0].Add(new int ());
            matrix[0][0] = 5;
            Console.WriteLine(matrix[0][0]);*/
        public void add_v(string name)
        {
            matrix.Add(new List<int>());
            verticesNames.Add(name);
        }
        public void add_e(int vertexOne, int vertexTwo, int weight)
        {
            edgesWeights.Add(weight);
            for (int i = 0; i < matrix.Count; i++)
            {
                matrix[i].Add(new int());

                if (i == vertexOne || i == vertexTwo)
                    matrix[i][edgesWeights.Count() - 1] = 1;
                else
                    matrix[i][edgesWeights.Count() - 1] = 0;
            }
        }
        public void del_v(string name)
        {
            int i = 0;
            while (verticesNames[i] != name)
                i++;
            matrix.RemoveAt(i);
        }
        public void del_e(int vertexOne, int vertexTwo)
        {
            int i = 0;
            while (matrix[vertexOne][i] != 1 && matrix[vertexTwo][i] != 1)
            {
                i++;
            }
            for (int j = 0; j < i; j++)
            {
                matrix[j].RemoveAt(i);
            }
        }
        public void edit_v(string oldName, string newName) 
        {
            int i = 0;
            while (verticesNames[i] != oldName) i++;
            verticesNames[i] = newName;
        }
        public void edit_e(int vertexOne, int vertexTwo, int newWeight)
        {
            int i = 0;
            while (matrix[vertexOne][i] != 1 && matrix[vertexTwo][i] != 1)
            {
                i++;
            }
            edgesWeights[i] = newWeight;
        }
        public int first(int vertex)
        {
            int j = 0;
            while (matrix[vertex][j] != 1 && j < matrix[vertex].Count())
                j++;
            int i = 0;
            while (matrix[i][j] != 1 && i < matrix.Count()) 
                i++;
            if (i < matrix.Count() && j < matrix[vertex].Count())
                return i;
            else
                return -1;
        }
        public int next(int vertex, int index)
        {
            int j = 0;
            while (matrix[vertex][j] != 1)
                j++;
            int i = index;
            while (matrix[i][j] != 1 && i < matrix.Count())
                i++;
            if (matrix[i][j] == 1)
                return i;
            else
                return -1;
        }
        public int vertex(int vertex, int index)
        {
            int j = 0, counter = 0;
            
            while(j < matrix[vertex].Count() || counter != index)
            {
                if (matrix[vertex][j] == 1)
                    counter++;
                j++;
            }
            if (j != matrix[vertex].Count())
                return j;
            else
                return -1;
        }
        public void fancyPrint()
        {
            for (int i = 0; i <= matrix.Count(); i++)
            {
                for (int j = 0; j <= matrix[0].Count(); j++)
                {
                    if (i == 0)
                    {
                        if (j != 0)
                            Console.Write(edgesWeights[j-1]);
                        Console.Write('\t');
                    }
                    else if (j == 0)
                    {
                        if (i != 0)
                            Console.Write(verticesNames[i-1]);
                        Console.Write('\t');
                    }
                    else
                    {
                        Console.Write(matrix[i-1][j-1]);
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
