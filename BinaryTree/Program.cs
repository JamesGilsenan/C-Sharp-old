using System;
using System.Collections.Generic;

namespace BinaryTrees
{
    public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }
 
public class BinaryTree {
    List<int> values = new List<int>();
    public List<int> PreorderTraversal(TreeNode root) {
        Console.WriteLine("Inside traversal method");
        if (!values.Contains(root.val))
        {
            values.Add(root.val);
        }
        if (root.left != null)
        {
            Console.WriteLine("Moving to left child");
            PreorderTraversal(root.left);
        }
        else if (root.right != null)
        {
            Console.WriteLine("Moving to right child");
            PreorderTraversal(root.right);
        }

        return values;
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Staring preorder traversal of binary tree...");
            BinaryTree binaryTree = new BinaryTree();
            TreeNode node3 = new TreeNode(3, null, null);
            TreeNode node2 = new TreeNode(2, node3, null);
            TreeNode node1 = new TreeNode(1, null, node2);
            List<int> nodeValues = new List<int>();
            nodeValues = binaryTree.PreorderTraversal(node1);

            Console.WriteLine("\nPrinting node values");
            for (int i=0; i < nodeValues.Count; i++)
            {
                Console.WriteLine(nodeValues[i]);
            }      
        }
    }
}
