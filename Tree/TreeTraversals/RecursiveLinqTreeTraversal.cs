using System;
using System.Collections.Generic;
using System.Linq;
using Tree.TreeData;

namespace Tree.TreeTraversals
{
    public class RecursiveLinqTreeTraversal : ITreeTraversal
    {
        private readonly ITreeData _treeData;

        public int Count { get; private set; }

        public RecursiveLinqTreeTraversal(ITreeData treeData)
        {
            if (treeData == null)
                throw new ArgumentException($"{nameof(treeData)} is null");

            _treeData = treeData;
        }

        public void Traversal()
        {
            var tree = RecursiveNode(_treeData.Tree).ToList();
            Count = tree.Count;
        }

        private IEnumerable<Node> RecursiveNode(IList<Node> nodes)
        {
            foreach (var next in nodes)
            {
                yield return next;

                var childs = RecursiveNode(next.Childs);
                foreach (var c in childs)
                {
                    yield return c;
                }
            }
        }

        //private IEnumerable<Node> RecursiveTraversal(IList<Node> tree)
        //{
        //    foreach(var node in tree)
        //    {
        //        yield return node;

        //        var childs = RecursiveTraversal(node.Childs)
        //            {

        //        }
        //    }
        //}
    }
}
