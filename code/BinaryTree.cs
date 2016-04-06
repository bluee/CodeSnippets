using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication4
{
    class Solution
    {
        class Node
        {
            public Node left, right;
            public int data;

            public Node(int newData)
            {
                left = right = null;
                data = newData;
            }
        }

        static Node insert(Node node, int data)
        {
            if (node == null)
            {
                node = new Node(data);
            }
            else
            {
                if (data <= node.data)
                {
                    node.left = insert(node.left, data);
                }
                else
                {
                    node.right = insert(node.right, data);
                }
            }
            return (node);
        }

        static void Main(String[] args)
        {
            Node _root;
            int root_i = 0, root_cnt = 0, root_num = 0;
            root_cnt = Convert.ToInt32(Console.ReadLine());
            _root = null;
            for (root_i = 0; root_i < root_cnt; root_i++)
            {
                root_num = Convert.ToInt32(Console.ReadLine());
                if (root_i == 0)
                    _root = new Node(root_num);
                else
                    insert(_root, root_num);
            }

            int q = Convert.ToInt32(Console.ReadLine());
            int i = 0;

            for (i = 0; i < q; i++)
            {
                int _x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(isPresent(_root, _x));
            }

            return;
        }

        static int isPresent(Node root, int val)
        {
            if (root == null)
                return 0;

            if (root.data == val)
                return 1;

            return isPresent(val < root.data ? root.left : root.right, val);
        }


    }
}
//input
//11
//20
//10
//30
//8
//12
//25
//40
//6
//11
//13
//23
//4
//30
//10
//12
//15
//expected output
//1
//1
//1
//0
