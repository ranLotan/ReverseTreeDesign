using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTreeDesignPattern
{
    public class ReverseNode : IReverseTree
    {
        Node root = null;
        public void BuildTree(int num)
        {
            Queue<Node> queue = buildFreeNodes(num);

            if (num == 1)
            {
                root = new Node(1, null, null);
            }
            while (queue.Count >= 2)
            {
                Node left = queue.Dequeue();
                Node right = queue.Dequeue();
                Node node = new Node(left.count + right.count + 1, left , right);
                left.parent = node;
                right.parent = node;

                queue.Enqueue(node);
            }
            root = queue.Dequeue();
        }

        private Queue<Node> buildFreeNodes(int num)
        {
            Queue<Node> freeNodes = new Queue<Node>();
            while (num > 0)
            {
                freeNodes.Enqueue(new Node(1, null, null));
                num--;
            }
            return freeNodes;
        }

        public int CountNodes()
        {
            if (root == null)
            {
                return 0;
            }
            else return root.count;
        }
    }

    public class Node
    {
        public int count;
        public Node? leftChild;
        public Node? rightChild;
        public Node? parent;

        public Node()
        {
        }

        public Node(int treeCount, Node? left, Node? right) 
        {
            this.count = treeCount;
            this.leftChild = left;
            this.rightChild = right;
        }
    }
}
