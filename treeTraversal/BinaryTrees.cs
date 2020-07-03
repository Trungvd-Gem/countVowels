using System;
using System.Collections.Generic;
using System.Text;

namespace treeTraversal
{
    class BinaryTrees
    {
        private TreeNode root;
        public TreeNode Root
        {
            get { return root; }
        }

        public void Insert(int data)
        {
            
            if (root != null)
            {
                root.Insert(data);
            }
            else
            {
                root = new TreeNode(data);
            }
        }

        public void InOrderTraversal()
        {
            if (root != null)
                root.InOrderTraversal();
        }


     
        public void PreorderTraversal()
        {
            if (root != null)
                root.PreOrderTraversal();
        }

      
        public void PostorderTraversal()
        {
            if (root != null)
                root.PostorderTraversal();
        }
    }
}
