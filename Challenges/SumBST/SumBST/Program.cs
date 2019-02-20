using System;

namespace SumBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node Input = new Node(5);

            Input.Left = new Node(2);
            Input.Right = new Node(21);

            Input.Left.Left = new Node(-4);
            Input.Left.Right = new Node(3);

            Input.Right.Left = new Node(19);
            Input.Right.Right = new Node(25);

            string[] result = new string[2] { "No Value Found", "No Value Found" };

            result = PreorderSearch(Input, Input, 30, result);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.ReadKey();
            
        }
        static string[] PreorderSearch(Node input, Node input2, int sumValue, string[] result)
        {
            int value;
            if (input != null)
            {
                value = input.Data;
                if (FindBSTValue(input2, sumValue - value, value, false))
                {
                    result[0] = value.ToString();
                    result[1] = (sumValue - value).ToString();
                    return result;
                }

                PreorderSearch(input.Left, input2, sumValue, result);
                PreorderSearch(input.Right, input2, sumValue, result);
            }
            return result;
        }

        static string[] FindSumPositive(Node input, int sumValue)
        {
            string[] result = new string[2];
            for (int i = 0; i < sumValue; i++)
            {
                if (FindBSTValue(input, i, false) && (FindBSTValue(input, sumValue - i, false)))
                {
                    result[0] = i.ToString();
                    result[1] = (sumValue - i).ToString();
                    return result;
                }
            }
            result[0] = "No value found";
            result[1] = "No value found";
            return result;
        }

        static bool FindBSTValue(Node Root, int value, int comp, bool result)
        {
            if (Root.Data > value && Root.Left != null)
            {
                result = FindBSTValue(Root.Left, value, result);
            }
            if (Root.Data < value && Root.Right != null)
            {
                result = FindBSTValue(Root.Right, value, result);
            }
            if (Root.Data == value && value != comp)
            {
                return true;
            }
            return result;
        }


        static bool FindBSTValue(Node Root, int value, bool result)
        {
            if (Root.Data > value && Root.Left != null)
            {
                result = FindBSTValue(Root.Left, value, result);
            }
            if (Root.Data < value && Root.Right != null)
            {
                result = FindBSTValue(Root.Right, value, result);
            }
            if (Root.Data == value)
            {
                return true;
            }
            return result;
        }
    }
    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node()
        {
        }

        /// <summary>
        ///     constructor for node with data
        /// </summary>
        public Node(int input)
        {
            Data = input;
        }
    }
}
