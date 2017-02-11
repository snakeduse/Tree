using System;
using System.Collections.Generic;
using System.Linq;

namespace Tree.TreeTraversals
{
    class StackTreeTraversal : ITreeTraversal
    {
        private readonly ITreeData _treeData;

        public int Count { get; private set; }

        public StackTreeTraversal(ITreeData treeData)
        {
            if (treeData == null)
                throw new ArgumentException($"{nameof(treeData)} is null");

            _treeData = treeData;
        }

        public void Traversal()
        {
            var stack = new Stack<Node>();
            foreach (var t in _treeData.Tree)
            {
                //Console.WriteLine(t.Header);
                Count+=1;
                stack.Push(t);

                while (stack.Any())
                {
                    var p = stack.Pop();

                    foreach (var c in p.Childs)
                    {
                        Count += 1;
                        //Console.WriteLine(c.Header);
                        stack.Push(c);                        
                    }
                }
            }
        }
    }
}
