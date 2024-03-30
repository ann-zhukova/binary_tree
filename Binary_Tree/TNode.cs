using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree
{
    public class TNode
    {
        private int valueOfNode;
        private TNode left;
        private TNode right;
        public int ValueOfNode
        {
            get
            {
                return this.valueOfNode;
            }
            set
            {
                this.valueOfNode = value;
            }
        }
        public TNode Right
        {
            get
            {
                return right;
            }
            set
            {
                this.right = value;
            }
        }
        public TNode Left
        {
            get
            {
                return left;
            }
            set
            {
                this.left = value;
            }
        }
        public TNode() { }
        public TNode(int value)
        {
            ValueOfNode = value;
            left = null;
            right = null;
        }
        public TNode(int value, TNode left, TNode right)
        {
            Left = left;
            Right = right;
            ValueOfNode = value;
        }
    }
}
