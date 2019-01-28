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
            TestTree.Root.Right = new TreeNode(11);

            TestTree.Root.Left.Left = new TreeNode(3);
            TestTree.Root.Left.Right = new TreeNode(15);

            Console.WriteLine(TestTree.BST());

            Console.ReadKey();
        }
    }
}
