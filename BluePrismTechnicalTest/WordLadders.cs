using System.Collections.Generic;
using System.Linq;

namespace BluePrismTechnicalTest
{
    public class WordLadders
    {
        public bool WithinSingleEditDistance(string s1, string s2)
        {
            int misMatchCount = 0;

            for (int i = 0; i < s1.Length && misMatchCount < 2; ++i)
            {
                if (s1[i] != s2[i])
                {
                    misMatchCount++;
                }
            }

            return misMatchCount == 1;
        }
        public List<Node> BuildGraph(IList<string> wordList, string beginWord)
        {
            var graph = new List<Node>();

            if (!wordList.Contains(beginWord))
                graph.Add(new Node(beginWord));

            graph.AddRange(wordList.Select(w => new Node(w)));

            foreach (var n1 in graph)
            {
                n1.Neighbours.AddRange(graph.Where(n2 => WithinSingleEditDistance(n1.Value, n2.Value)));
            }

            return graph;
        }

        public IEnumerable<IList<string>> FindLadders(
            string beginWord, string endWord, IList<string> wordList)
        {
            var graph = BuildGraph(wordList, beginWord);

            var startNode = graph.Single(x => x.Value.Equals(beginWord));

            var destNode = graph.SingleOrDefault(x => x.Value.Equals(endWord));

            if (destNode == null)
                return new List<IList<string>>();

            FindPathsBreadthFirstSearch(startNode, destNode);

            return TraverseDepthFirstSearch(startNode, destNode, new List<string>());
        }


        public int MinDistance { get; set; }
        public void FindPathsBreadthFirstSearch(Node start, Node dest)
        {
            MinDistance = int.MaxValue;
            var list = new List<Node>();
            start.Distance = 0;
            list.Add(start);

            while (list.Count > 0)
            {
                var newList = new List<Node>();

                foreach (var node in list)
                {
                    if (node.Value.Equals(dest.Value))
                    {
                        MinDistance = node.Distance;
                        continue;
                    }

                    foreach (var neighbour in node.Neighbours)
                    {
                        var newDistance = node.Distance + 1;

                        if (!node.IsVisited &&
                            newDistance <= neighbour.Distance &&
                            newDistance <= MinDistance)
                        {
                            node.ShortestPathChildren.Add(neighbour);
                            neighbour.Distance = newDistance;
                            newList.Add(neighbour);
                        }
                    }

                    node.IsVisited = true;
                }

                list = newList;
            }

        }
        public IEnumerable<IList<string>> TraverseDepthFirstSearch(Node current, Node dest, List<string> ladder)
        {
            ladder.Add(current.Value);

            if (current.Value.Equals(dest.Value))
            {
                var copiedLadder = ladder.ToList();

                yield return copiedLadder;

                ladder.Remove(current.Value);
                yield break;
            }

            foreach (var child in current.ShortestPathChildren)
            {
                foreach (var childLadder in TraverseDepthFirstSearch(child, dest, ladder))
                {
                    yield return childLadder;
                }
            }

            ladder.Remove(current.Value);
        }
    }
}