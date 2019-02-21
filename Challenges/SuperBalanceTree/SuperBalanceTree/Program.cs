using System;
using System.Collections.Generic;

namespace SuperBalanceTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BinaryTreeNode Input = new BinaryTreeNode(15);
            Input.Left = new BinaryTreeNode(7);
            //Input.Left.Left = new BinaryTreeNode(3);
            //Input.Left.Right = new BinaryTreeNode(4);
            //Input.Left.Right.Right = new BinaryTreeNode(5);

            Input.Right = new BinaryTreeNode(19);

            Console.WriteLine(SuperBalance(Input));
            Console.ReadKey();

        }

        static bool SuperBalance(BinaryTreeNode Root)
        {
            int count = 0;
            List<int> TreeHeight = new List<int>();
            PreOrder(Root, TreeHeight, count);
            foreach (int counter in TreeHeight)
            {
                Console.Write(counter);
            }
            Console.WriteLine();
            for (int i = 0; i < TreeHeight.Count; i++)
            {
                for (int j = i + 1; j < TreeHeight.Count; j++)
                {
                    if (Math.Abs(TreeHeight[i] - TreeHeight[j]) > 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void PreOrder(BinaryTreeNode Root, List<int> Result, int count)
        {
            if (Root != null)
            {
                count++;
                if (Root.Left == null && Root.Right == null)
                {
                    Result.Add(count);
                }
                PreOrder(Root.Left, Result, count);
                PreOrder(Root.Right, Result, count);
            }
        }
    }


    class BinaryTreeNode
    {
        public int Value { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }
        public BinaryTreeNode(int value)
        {
            Value = value;
        }
    }
}
