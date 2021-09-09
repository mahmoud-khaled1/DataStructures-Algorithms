using System;

namespace Binary_Search_Tree
{
    public class BST
    {
        public class Node
        {
            public int data;
            public Node left;
            public Node right;

            public Node(int value)
            {
                data = value;
                left = null;
                right = null;
            }
        }
        public Node root = null;

        #region Main Function
        public void Add_iterative(int value)
        {
            Node newNode = new Node();
            newNode.data = value;
            newNode.left = null;
            newNode.right = null;
            if (root == null)
                root = newNode;
            else
            {
                Node Temp = new Node();
                Node Prev = new Node();
                Temp = root;
                Prev = Temp;
                while (Temp != null)
                {
                    Prev = Temp;
                    if (value <= Temp.data)
                        Temp = Temp.left;
                    else
                        Temp = Temp.right;
                }
                if (Prev.data <= value)
                    Prev.right = newNode;
                else
                    Prev.left = newNode;
            }


        }
        public void Add_Recursion(int value)
        {
            if (root == null)
            {
                Node newNode = new Node(value);
                root = newNode;
            }
            else
                AddHelper(value, root);

        }

        #endregion

        #region Helper Functions
        private void AddHelper(int value,Node temp)
        {
            if (value <= temp.data)
            {
                if(temp.left==null)
                {
                    Node newNode = new Node(value);
                    temp.left = newNode;
                }
                else
                    AddHelper(value, temp.left);
            }
            else
            {
                if (temp.right == null)
                {
                    Node newNode = new Node(value);
                    temp.right = newNode;
                }
                else
                    AddHelper(value, temp.right);
            }
        }

        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

}
