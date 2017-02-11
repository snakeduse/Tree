using System;
using System.Diagnostics;
using Tree.TreeData;
using Tree.TreeTraversals;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            ITreeData data = new BigTree();

            Print("Recursive", new RecursiveTreeTraversal(data));
            Print("Recursive LINQ", new RecursiveLinqTreeTraversal(data));
            Print("Stack", new StackTreeTraversal(data));
            Print("Stack LINQ", new StackLinqTraveras(data));
            Print("Queue", new QueueTreeTraversal(data));
            Print("Queue LINQ", new QueueLinqTreeTraversal(data));   

            Console.Read();
        }

        private static void Print(string header, ITreeTraversal treeTraversal)
        {
            var stopWatch = new Stopwatch();

            Console.WriteLine(header);
            stopWatch.Start();
            treeTraversal.Traversal();
            stopWatch.Stop();

            Console.WriteLine($"Count: {treeTraversal.Count}");
            Console.WriteLine($"Time: {stopWatch.ElapsedMilliseconds}ms");
            Console.WriteLine();
        }
    }
}
