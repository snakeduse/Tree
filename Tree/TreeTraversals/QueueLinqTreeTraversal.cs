using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.TreeData;

namespace Tree.TreeTraversals
{
    public class QueueLinqTreeTraversal : ITreeTraversal
    {
        private readonly ITreeData _treeData;

        public int Count { get; private set; }

        public QueueLinqTreeTraversal(ITreeData treeData)
        {
            if (treeData == null)
                throw new ArgumentException($"{nameof(treeData)} is null");

            _treeData = treeData;
        }

        public void Traversal()
        {
            var items = GetTreeItems().ToList();
            Count = items.Count;
        }

        private IEnumerable<Node> GetTreeItems()
        {
            var queue = new Queue<Node>();
            foreach (var root in _treeData.Tree)
            {
                //Console.WriteLine(root.Header);
                yield return root;
                queue.Enqueue(root);
                while (queue.Any())
                {
                    var dequeueNode = queue.Dequeue();
                    foreach (var child in dequeueNode.Childs)
                    {
                        //Console.WriteLine(child.Header);
                        yield return child;
                        queue.Enqueue(child);
                    }
                }
            }
        }
    }
}
