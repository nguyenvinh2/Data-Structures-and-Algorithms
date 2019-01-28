using System;
using BST.Classes;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Tree TestTree = new Tree(10);

            TestTree.Root.Left = new TreeNode(8);
            TestTree.Root.Right = new TreeNode(17);

            TestTree.Root.Left.Left = new TreeNode(3);
            TestTree.Root.Left.Right = new TreeNode(14);

            TestTree.Root.Right.Left = new TreeNode(19);
            TestTree.Root.Right.Right = new TreeNode(21);

            Console.WriteLine(TestTree.BST());

            Console.ReadKey();
        }
    }
}
