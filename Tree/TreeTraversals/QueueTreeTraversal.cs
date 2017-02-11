using System;
using System.Collections.Generic;
using System.Linq;

namespace Tree.TreeTraversals
{
    class QueueTreeTraversal : ITreeTraversal
    {
            private readonly ITreeData _treeData;

            public int Count { get; private set; }
        
            public QueueTreeTraversal(ITreeData treeData)
            {
                if (treeData == null)
                    throw new ArgumentException($"{nameof(treeData)} is null");

                _treeData = treeData;
            }
               
            public void Traversal()
            {
                var queue = new Queue<Node>();
                foreach(var root in _treeData.Tree)
                {
                    Count++;
                    //Console.WriteLine(root.Header);
                    queue.Enqueue(root);
                    while (queue.Any())
                    {
                        var dequeueNode = queue.Dequeue();
                        foreach(var child in dequeueNode.Childs)
                        {
                            //Console.WriteLine(child.Header);
                            Count++;
                            queue.Enqueue(child);
                        }
                    }
                }
            }
    }
}
