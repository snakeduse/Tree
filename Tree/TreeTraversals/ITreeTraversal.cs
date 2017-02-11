using System.Collections.Generic;

namespace Tree.TreeTraversals
{
    public interface ITreeTraversal
    {
        int Count { get; }

        void Traversal();
    }
}
