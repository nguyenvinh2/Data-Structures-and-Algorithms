using System;

namespace SuperBalanceTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static bool SuperBalance(BinaryTreeNode Root)
        {
            return false;
        }
    }


    class BinaryTreeNode
    {
        int Value { get; set; }
        BinaryTreeNode Left { get; set; }
        BinaryTreeNode Right { get; set; }
        BinaryTreeNode(int value)
        {
            Value = value;
        }
    }
}
