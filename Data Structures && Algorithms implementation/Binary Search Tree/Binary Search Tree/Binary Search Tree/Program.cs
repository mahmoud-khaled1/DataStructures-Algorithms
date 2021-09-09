﻿using System;
using System.Collections.Generic;

namespace Binary_Search_Tree
{
    public class BST
    {
        public class Node
        {
            public int data;
            public Node left;
            public Node right;

            public Node()
            {

            }
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
            Node newNode = new Node(value);
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
        public int GetMax_Iteration()
        {
            if (root == null)
                return -1;
            Node Temp = new Node();
            Temp = root;
            while (Temp.right!=null)
            {
                Temp = Temp.right;
            }
            return Temp.data;
        }
        public int GetMin_Iteration()
        {
            if (root == null)
                return -1;
            Node Temp = new Node();
            Temp = root;
            while (Temp.left != null)
            {
                Temp = Temp.left;
            }
            return Temp.data;
        }
        public int GetMax_Recursion()
        {
            if (root == null)
                return -1;
            return GetMAxHelper(root);
        }
        public int GetMin_Recursion()
        {
            if (root == null)
                return -1;
            return GetMAxHelper(root);
        }
        public int GetHeightOfTree()
        {
            if (root == null)
                return 0;
            return GetHeightOfTreeHelper(root);
        }
        public void Display_LevelOrder()
        {
            if (root == null)
                return;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while(queue.Count>0)
            {
                Node Current = queue.Dequeue();
                Console.Write(Current.data+" ");
                if (Current.left != null)
                    queue.Enqueue(Current.left);
                if (Current.right != null)
                    queue.Enqueue(Current.right);
            }
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
        private int GetMAxHelper(Node temp)
        {
            if(temp.right!=null)
            {
                return GetMAxHelper(temp.right);     
            }
            else
            {
                return temp.data;
            }
        }
        private int GetMinHelper(Node temp)
        {
            if (temp.left != null)
            {
                return GetMAxHelper(temp.left);
            }
            else
            {
                return temp.data;
            }
        }
        private int GetHeightOfTreeHelper(Node temp)
        {
            if (temp == null)
                return -1;
            int left_subtree = GetHeightOfTreeHelper(temp.left);
            int right_subtree = GetHeightOfTreeHelper(temp.right);
            return 1 + Math.Max(left_subtree, right_subtree);
        }
        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {
            BST bst = new BST();
            bst.Add_iterative(50);
            bst.Add_iterative(60);
            bst.Add_iterative(70);
            bst.Add_iterative(40);
            bst.Add_iterative(30);
            bst.Add_iterative(44);

            //Console.WriteLine(bst.GetMax_Iteration());
            // Console.WriteLine(bst.GetMin_Iteration());
            //Console.WriteLine(bst.GetMax_Recursion());
            //Console.WriteLine(bst.GetHeightOfTree());
            //bst.Display_LevelOrder();
        }
    }

}
