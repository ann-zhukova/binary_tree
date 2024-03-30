using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree
{
    public class BinaryTree
    {
        public static Random random = new Random();
        public static TNode Tree(int n)
        {
            if (n == 0)
            {
                return null;
            }
            else
            {
                TNode node = new TNode(random.Next(10));
                node.Right = Tree(n / 2);
                node.Left = Tree(n - 1 - n / 2);
                return node;
            }
        }
        public static TNode Tree25_1(int n, int[] values)
        {
            if (n == 0)
            {
                return null;
            }
            else
            {
                TNode root = new TNode(values[0]);
                TNode node = root;
                for (int i = 1; i < n; i++)
                {
                    node.Right = new TNode(values[i]);
                    node = node.Right;
                }
                return root;
            }
        }
        public static void Tree44(TNode root)
        {
            if (root != null)
            {
                if (root.Right != null || root.Left != null)
                {
                    Tree44(root.Left);
                    Tree44(root.Right);
                }
                else
                {
                    TNode nodeL = new TNode(10);
                    TNode nodeR = new TNode(11);
                    root.Left = nodeL;
                    root.Right = nodeR;
                }
            }
            else
            {
            }
        }
        public static string Enter(TNode root)
        {
            string result ="";
            if (root != null)
            {
                TNode node = root;
                result += Enter(root.Left);
                result += ","+ root.ValueOfNode;
                result += Enter(root.Right);
            }
            else
            {
            }
            return result;
        }
    }
}
