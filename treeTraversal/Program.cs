using System;

namespace treeTraversal
{   
    
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTrees binaryTree = new BinaryTrees();

            binaryTree.Insert(70);
            binaryTree.Insert(49);
            binaryTree.Insert(84);
            binaryTree.Insert(37);
            binaryTree.Insert(54);
            binaryTree.Insert(78);
            binaryTree.Insert(85);
            binaryTree.Insert(22);
            binaryTree.Insert(40);
            binaryTree.Insert(76);
            binaryTree.Insert(80);



            Console.WriteLine("In Order Traversal (Left->Root->Right)");
            binaryTree.InOrderTraversal();
            Console.WriteLine("\nPre Order Traversal (Root->Left->Right)");
            binaryTree.PreorderTraversal();
            Console.WriteLine("\nPost Order Traversal (Left->Right->Root)");
            binaryTree.PostorderTraversal();

            Console.ReadLine();

        }
    }
}
