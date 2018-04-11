using System;

namespace _285_inorder_successor_bst
{
    class Program
    {
        public class TreeNode{
            public TreeNode left;
            public TreeNode right;
            public int val;
        }
        //Algorithm as follows:
        // - Using the target node value, search through the tree until we hit the target node
        // - Once at the target node, successor will be in the right subtree, search leftmost side of the right subtree (left subtree of the right child)
        // - if the right subtree is null, then the successor is either the parent, or we're at the end of the inorder traversal in which we should return null
        // - in either case, return the value of the right subtree search, (null if no tree exists) and the parent node will check if the returned value is null
        // - if the return value is null, then itself must be the parent, and return itself.
        public TreeNode InorderSuccessor(TreeNode root, TreeNode p) {
            //base case
            if (root == null) return null;
            //if the target value is in the right subtree
            //OR if we're at the target node, search right subtree for min value
            if (p.val >= root.val)
                return InorderSuccessor(root.right, p);
            //search
            else{
                TreeNode left = InorderSuccessor(root.left, p);
                return left ?? root;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
