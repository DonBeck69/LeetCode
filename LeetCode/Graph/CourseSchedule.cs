using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Graph
{
    /// <summary>
    /// Graph algo
    /// </summary>
    public class CourseSchedule
    {

        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            HashSet<int> res = new HashSet<int>();
            List<Vertacy> vertacies = new List<Vertacy>();
            for (int i = 0; i < numCourses; i++)
            {
                Vertacy vertacy = new Vertacy()
                {
                    ID = i
                };

                vertacies.Add(vertacy);
            }

            for (int n = 0; n < prerequisites.Length; n++)
            {
                vertacies[prerequisites[n][0]].Edges.Add(prerequisites[n][1]);
            }

            int index = 0;
            while (index < vertacies.Count)
            {
                Vertacy vertacy = vertacies[index];
                if (vertacy.Edges.Count == 0)
                {
                    int id = vertacy.ID;
                    res.Add(id);
                    vertacies.Remove(vertacy);
                    index = 0;
                    foreach (Vertacy v in vertacies)
                    {
                        v.Edges.Remove(id);
                    }
                }
                else
                {
                    index++;
                }
            }

            if (vertacies.Count > 1)
            {
                res.Clear();
            }

            return res.ToArray();
        }


        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            List<Vertacy> vertacies = new List<Vertacy>();
            for (int i = 0; i < numCourses; i++)
            {
                Vertacy vertacy = new Vertacy()
                {
                    ID = i
                };

                vertacies.Add(vertacy);
            }

            for (int n = 0; n < prerequisites.Length; n++)
            {
                vertacies[prerequisites[n][0]].Edges.Add(prerequisites[n][1]);                
            }

            for (int i = 0; i < numCourses; i++)
            {
                if (DepthFirstSearchCanFinish(vertacies, i) == false)
                {
                    return false;
                }
            }

            return true;
        }

        public void TopologicalOrder(List<Vertacy> Vertacies, List<int> Result)
        {
            while(Vertacies.Count > 0)
            {
                Vertacy vertacy = Vertacies[0];
                if (vertacy.Edges.Count == 0)
                {
                    int id = vertacy.ID;
                    Result.Add(id);
                    Vertacies.Remove(vertacy);
                    foreach(Vertacy v in Vertacies)
                    {
                        v.Edges.Remove(id);
                    }
                }
            }
        }

        public bool DepthFirstSearchCanFinish(List<Vertacy> Vertacies, int vertacy)
        {
            if (Vertacies[vertacy].Used) return false;

            if (Vertacies[vertacy].Edges.Any() && !Vertacies[vertacy].Visited)
            {
                Vertacies[vertacy].Visited = true;

                Vertacies[vertacy].Used = true;
                foreach (int v in Vertacies[vertacy].Edges)
                {
                    if (DepthFirstSearchCanFinish(Vertacies, v) == false) return false;
                }
                Vertacies[vertacy].Used = false;
            }

            return true;
        }


    }

    public class Vertacy
    {
        public Vertacy()
        {
            Edges = new HashSet<int>();
        }
        public int ID { get; set; }
        public HashSet<int> Edges
        {
            get; set;
        }

        public bool Visited
        {
            get; set;
        }
        public bool Used
        {
            get; set;
        }

    }
}


