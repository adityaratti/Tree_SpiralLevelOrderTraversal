using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_SpiralLevelOrderTraversal
{
    class Node
    {
        public int data;
        public Node left, right;

        public Node(int d)
        {
            data = d;
        }
    }

    class Tree
    {
        public Node root;

        public void horizontalTraversal(Node node)
        {
            Stack<Node> stack = new Stack<Node>();
            Queue<Node> queue = new Queue<Node>();

            bool isLeft = true;

            stack.Push(node);

            while (stack.Count > 0 || queue.Count > 0)
            {
                Node dataNode;

                dataNode = isLeft ? stack.Pop() : queue.Dequeue();

                if (isLeft)
                {
                    if (dataNode.left != null)
                        queue.Enqueue(dataNode.left);
                    if (dataNode.right != null)
                        queue.Enqueue(dataNode.right);
                }
                else
                {
                    if (dataNode.left != null)
                        stack.Push(dataNode.left);
                    if (dataNode.right != null)
                        stack.Push(dataNode.right);
                }

                if (stack.Count == 0 && queue.Count > 0)
                    isLeft = false;

                if (queue.Count == 0 && stack.Count > 0)
                    isLeft = true;

                Console.Write(dataNode.data + " ");

            }
        }
    }
}
