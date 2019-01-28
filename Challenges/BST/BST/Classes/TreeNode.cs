using System;
using System.Collections.Generic;
using System.Text;

namespace BST.Classes
{
    public class TreeNode
    {
        public TreeNode Left { get; set; } 
        public TreeNode Right { get; set; }
        public int Value { get; set; }
        public TreeNode(int value)
        {
            Value = value;
        }


    }

    public class Tree
    {
        public TreeNode Root { get; set; }

        public Tree(int value)
        {
            Root = new TreeNode(value);
            Root.Left = null;
            Root.Right = null;
        }

        public bool BST()
        {
            return BSTCheck(Root, int.MinValue, int.MaxValue);
        }

        public bool BSTCheck(TreeNode Node, int minValue, int maxValue)
        {
            if (Node == null)
            {
                return true;
            }
            if (Node.Value < minValue || Node.Value > maxValue)
            {
                return false;
            }
            return (BSTCheck(Node.Left, minValue, Node.Value - 1) && BSTCheck(Node.Right, Node.Value + 1, maxValue));
        }
    }

}
