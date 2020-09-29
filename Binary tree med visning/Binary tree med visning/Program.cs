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
            //BinaryTree binaryTree = new BinaryTree();

            var Tree = new BinaryTree();

            Tree.Add(100);
            Tree.Add(120);
            Tree.Add(102);
            Tree.Add(105);
            Tree.Add(101);
            Tree.Add(90);
            Tree.Add(80);
            Tree.Add(10);
            Tree.Add(11);
            Tree.Add(9);
            Tree.Add(2000);
            Tree.Add(2225);
            Tree.Add(2233); 
            Tree.Add(2122);

            Console.WriteLine("preorder Traversal:");

            Console.WriteLine();
            Tree.TraversePreOrder(Tree.Root);

            BSTPrinter.Print(Tree.Preorder, 3);





            //Console.WriteLine("InOrder Traversal:");
            //Console.WriteLine(Tree.Inorder);

            //Tree.TraverseInOrder(Tree.Root);

            //BSTPrinter.Print(Tree.Inorder, 3);
            //Console.WriteLine();

            //Console.WriteLine("postorder Traversal:");
            //Console.WriteLine(Tree.Preorder);

            //Tree.TraversePostOrder(Tree.Root);

            //BSTPrinter.Print(Tree.Preorder, 3);
            //Console.WriteLine();


            //Node node = binaryTree.Find(5);
            //int depth = binaryTree.GetTreeDepth();

            //Console.WriteLine("PreOrder Traversal:");
            //Tree.TraversePreOrder(Tree.Root);
            //Console.WriteLine();

            //Console.WriteLine("InOrder Traversal:");
            //binaryTree.TraverseInOrder(binaryTree.Root);
            //Console.WriteLine();

            //Console.WriteLine("PostOrder Traversal:");
            //Tree.TraversePostOrder(Tree.Root);
            //Console.WriteLine();

            //binaryTree.Remove(7);
            //binaryTree.Remove(8);

            //Console.WriteLine("PreOrder Traversal After Removing Operation:");
            //binaryTree.TraversePreOrder(binaryTree.Root);
            //Console.WriteLine();

            //Console.WriteLine("Get the number of leaf nodes");
            //Console.WriteLine(binaryTree.NumberOfLeafNodes());

            //Console.WriteLine("get all non leaf nodes");
            //Console.WriteLine(binaryTree.countNonLeafNodes());

            //Console.WriteLine("Get the height of the tree");
            //Console.WriteLine(binaryTree.Height());

            Console.ReadLine();
        }
    }
}

