using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(1);
            binaryTree.Add(2);
            binaryTree.Add(7);
            binaryTree.Add(3);
            binaryTree.Add(10);
            binaryTree.Add(5);
            binaryTree.Add(8);

            Node node = binaryTree.Find(5);
            int depth = binaryTree.GetTreeDepth();

            Console.WriteLine("PreOrder Traversal:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("InOrder Traversal:");
            binaryTree.TraverseInOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("PostOrder Traversal:");
            binaryTree.TraversePostOrder(binaryTree.Root);
            Console.WriteLine();

            //binaryTree.Remove(7);
            //binaryTree.Remove(8);

            Console.WriteLine("PreOrder Traversal After Removing Operation:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("Get the number of leaf nodes");
            Console.WriteLine(binaryTree.NumberOfLeafNodes());

            Console.WriteLine("get all non leaf nodes");
            Console.WriteLine(binaryTree.countNonLeafNodes());

            Console.WriteLine("Get the height of the tree");
            Console.WriteLine(binaryTree.Height());

            Console.ReadLine();
        }
    }
}
