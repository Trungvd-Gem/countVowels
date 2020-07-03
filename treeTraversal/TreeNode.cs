using System;
using System.Collections.Generic;
using System.Text;

namespace treeTraversal
{
    class TreeNode
    {
        private int data;
        public int Data
        {
            get { return data; }
        }

        private TreeNode rightNode;
        public TreeNode RightNode
        {
            get { return rightNode; }
            set { rightNode = value; }

        }

        private TreeNode leftNode;
        public TreeNode LeftNode
        {
            get { return leftNode; }
            set { leftNode = value; }
        }

        public TreeNode(int value)
        {
            data = value;
        }

        public void Insert(int value)
        {
           
            if (value >= data)
            {   
                if (rightNode == null)
                {
                    rightNode = new TreeNode(value);
                }
                else
                {
                    rightNode.Insert(value);
                }
            }
            else
            {
                if (leftNode == null)
                {
                    leftNode = new TreeNode(value);
                }
                else
                {
                    leftNode.Insert(value);
                }
            }
        }

        public void InOrderTraversal()
        {
            
            if (leftNode != null)
                leftNode.InOrderTraversal();
          
            Console.Write(data + " ");

           
            if (rightNode != null)
                rightNode.InOrderTraversal();
        }


        
        public void PreOrderTraversal()
        {
          
            Console.Write(data + " ");

         
            if (leftNode != null)
                leftNode.PreOrderTraversal();

         
            if (rightNode != null)
                rightNode.PreOrderTraversal();
        }

        
        public void PostorderTraversal()
        {
         
            if (leftNode != null)
                leftNode.PostorderTraversal();

         
            if (rightNode != null)
                rightNode.PostorderTraversal();

          
            Console.Write(data + " ");
        }

    }
}
