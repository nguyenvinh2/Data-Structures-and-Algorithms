using System;
using System.Collections.Generic;
using Tree.Classes;

namespace Pathweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node Tree = new Node(5);

            Tree.Left = new Node(6);
            Tree.Right = new Node(7);

            Tree.Left.Left = new Node(8);
            Tree.Left.Right = new Node(9);

            Tree.Right.Left = new Node(12);
            Tree.Right.Right = new Node(13);

            Tree.Left.Left.Left = new Node(10);
            Tree.Left.Left.Right = new Node(11);

            bool result = Weight(Tree, 29);

            Console.WriteLine(result);
            Console.ReadKey();

        }

        public static bool Weight(Node Root, int weight)
        {
            int count = 0;
            return GetCount(Root, weight, count, false);
        }

        public static bool GetCount(Node Root, int weight, int count, bool result)
        {
            if (Root.Left == null && Root.Right == null)
            {
                count += Root.Data;
                if (count == weight)
                {
                    return true;
                }
            }
            if (Root.Left != null)
            {
                count += Root.Data;
                result = GetCount(Root.Left, weight, count, result);
            }
            if (Root.Right != null)
            {
                result = GetCount(Root.Right, weight, count, result);
            }
            
            return result;
        }
    }
}
