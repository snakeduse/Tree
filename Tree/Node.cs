using System.Collections.Generic;

namespace Tree
{
    public class Node
    {
        public string Header { get; private set; }
        public List<Node> Childs { get; set; }

        public Node(string header)
        {
            Header = header;
            Childs = new List<Node>();
        }

        public override string ToString()
        {
            return Header;
        }
    }
}
