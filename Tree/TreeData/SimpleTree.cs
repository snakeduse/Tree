using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree.TreeData
{
    class SimpleTree : ITreeData
    {
        public IList<Node> Tree
        {
            get
            {
                var tree = new List<Node>{
                    new Node("A"){
                        Childs = new List<Node>{
                            new Node("B"),
                            new Node("C"){
                                Childs = new List<Node>{ new Node("D"), new Node("E"), new Node("F") }
                            },
                            new Node("G"),
                            new Node("H"){
                                Childs = new List<Node>{
                                    new Node("I"){ Childs = new List<Node>{ new Node("J"), new Node("K")}},
                                    new Node("L")
                                }}
                        }
                    }
                };
                return tree;
            }
        }
    }
}
