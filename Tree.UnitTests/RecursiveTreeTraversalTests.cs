using NUnit.Framework;
using Tree.TreeData;
using Tree.TreeTraversals;

namespace Tree.UnitTests
{
    [TestFixture]
    public class RecursiveTreeTraversalTests
    {
        [Test]
        public void Traversal_SimpleTree_AllItems()
        {
            var recursiveTree = new RecursiveTreeTraversal(new SimpleTree());

            recursiveTree.Traversal();

            Assert.AreEqual(12, recursiveTree.Count);            
        }

        [Test]
        public void Traversal_BigTree_AllItems()
        {
            var recursiveTree = new RecursiveTreeTraversal(new BigTree());

            recursiveTree.Traversal();

            Assert.AreEqual(3663, recursiveTree.Count);
        }
    }
}
