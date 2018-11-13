using System;
using System.Collections.Generic;
using Hashtables.Classes;

namespace TreeIntersectionChallenge
{
    /// <summary>
    /// sets up tree node so outside dll not needed
    /// </summary>
    public class TreeNode
    {
        public int Data { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public TreeNode()
        {
        }
        public TreeNode(int input)
        {
            Data = input;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Match
            TreeNode TreeOne = new TreeNode(5);
            TreeNode TreeTwo = new TreeNode(5);

            TreeOne.Left = new TreeNode(2);
            TreeTwo.Left = new TreeNode(3);

            //Match
            TreeOne.Right = new TreeNode(10);
            TreeTwo.Right = new TreeNode(10);

            //Match
            TreeOne.Left.Left = new TreeNode(16);
            TreeTwo.Left.Left = new TreeNode(16);

            //match
            TreeOne.Left.Right = new TreeNode(23);
            TreeTwo.Right.Left = new TreeNode(23);

            TreeTwo.Left.Right = new TreeNode(25);
            TreeOne.Right.Left = new TreeNode(18);

            TreeOne.Right.Right = new TreeNode(50);
            TreeTwo.Right.Right = new TreeNode(34);

            //Match
            TreeOne.Right.Right.Left = new TreeNode(56);
            TreeTwo.Right.Right.Right = new TreeNode(56);

            List<int> MatchValues = TreeIntersection(TreeOne, TreeTwo);

            foreach (var value in MatchValues)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
        /// <summary>
        /// takes in two trees, returns list of matching values
        /// calls on subfunctions to do the work
        /// </summary>
        /// <param name="One">tree one</param>
        /// <param name="Two">tree two</param>
        /// <returns></returns>
        public static List<int> TreeIntersection(TreeNode One, TreeNode Two)
        {
            Hashtable NodeStorage = new Hashtable();
            PreOrderHash(One, NodeStorage);
            List<int> MatchValues = new List<int>();

            return PreOrderContains(Two, NodeStorage, MatchValues);
        }
        /// <summary>
        /// preorders through tree one, hashes the node and adds to hashtable
        /// </summary>
        /// <param name="Root">root of tree one</param>
        /// <param name="Stored"><hashtable/param>
        /// <returns></returns>
        public static Hashtable PreOrderHash(TreeNode Root, Hashtable Stored)
        {
            if (Root != null)
            {
                Stored.Add(Root.Data.ToString(), "Dummy");
                PreOrderHash(Root.Left, Stored);
                PreOrderHash(Root.Right, Stored);
            }
            return Stored;
        }
        /// <summary>
        /// preorder search threough tree 2, see if each value is contained in the hashtable for one
        /// adds to list of matched values if true
        /// </summary>
        /// <param name="Root">root of second tree</param>
        /// <param name="Stored">Hashtable</param>
        /// <param name="MatchValue">list of return integers</param>
        /// <returns></returns>
        public static List<int> PreOrderContains(TreeNode Root, Hashtable Stored, List<int> MatchValue)
        {
            if (Root != null)
            {
                if (Stored.Contains(Root.Data.ToString()))
                {
                    MatchValue.Add(Root.Data);
                }
                PreOrderContains(Root.Left, Stored, MatchValue);
                PreOrderContains(Root.Right, Stored, MatchValue);
            }
            return MatchValue;
        }
    }
}
