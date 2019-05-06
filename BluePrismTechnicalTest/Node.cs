using System.Collections.Generic;

namespace BluePrismTechnicalTest
{
    public class Node
    {
        public Node(string value) => Value = value;

        public string Value { get; set; }
        public List<Node> Neighbours { get; } = new List<Node>();
        public List<Node> ShortestPathChildren { get; } = new List<Node>();
        public bool IsVisited { get; set; } = false;
        public int Distance { get; set; } = int.MaxValue;
    }
}