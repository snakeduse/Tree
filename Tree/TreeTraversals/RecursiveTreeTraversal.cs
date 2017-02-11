using System;
using System.Collections.Generic;

namespace Tree.TreeTraversals
{
    /// <summary>
    /// Рекурсивный алгоритм обхода дерева
    /// </summary>
    class RecursiveTreeTraversal : ITreeTraversal
    {
        private readonly ITreeData _treeData;

        private static int _counter;

        public int Count
        {
            get { return _counter; }
        }

        public RecursiveTreeTraversal(ITreeData treeData)
        {
            if (treeData == null)
                throw new ArgumentException($"{nameof(treeData)} is null");

            _treeData = treeData;
        }

        public void Traversal()
        {
            RecursiveTraverals(_treeData.Tree);
        }

        private void RecursiveTraverals(IList<Node> tree)
        {
            //Посетить корень u ордерева tree; 
            foreach (var u in tree)
            {
                //Console.WriteLine(u);
                _counter++;
                foreach (var child in u.Childs)
                {
                    //Console.WriteLine(child);
                    _counter++;
                    RecursiveTraverals(child.Childs);
                }
            }
        }
    }
}
