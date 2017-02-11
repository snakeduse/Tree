using System;
using System.Collections.Generic;
using System.Linq;

namespace Tree.TreeTraversals
{
    class StackLinqTraveras : ITreeTraversal
    {
        private readonly ITreeData _treeData;

        public int Count { get; set; }

        public StackLinqTraveras(ITreeData treeData)
        {
            if (treeData == null)
                throw new ArgumentException($"{nameof(treeData)} is null");

            _treeData = treeData;
        }

        public void Traversal()
        {
            var tree = LinqTraversal().ToList();
            Count = tree.Count;
        }

        private IEnumerable<Node> LinqTraversal()
        {
            var stack = new Stack<Node>();

            foreach (var node in _treeData.Tree)
            {
                stack.Push(node);

                while (stack.Any())
                {
                    var next = stack.Pop();
                    yield return next;

                    foreach (var child in next.Childs)
                        stack.Push(child);
                }
            }            
        }
    }
}
