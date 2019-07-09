using System;
using System.Collections.Generic;
using System.Text;

namespace EstudiosAlgoritmosCSharp
{
    class Node
    {
        public int? value;
        public Node l;
        public Node r;
    }
    class BinaryTree
    {
        public Node InsertNode(Node node, int value)
        {
            if(node == null)
            {
                node = new Node();
                node.value = value;
            }
            else if (node.l.value == null)
            {
                node.l.value = value;
            }
            else if (node.r.value == null)
            {
                node.r.value = value;
            }
            return node;
        }

        public void traverse(Node node)
        {
            if(node == null)
            {
                return;
            }

            traverse(node.l);
            traverse(node.r);
        }
    }
}
