using System;
using System.Collections.Generic;
using System.Text;

namespace Tree_Traversal
{
     public class PostorderTraversal
    {
        IList<int> solution = new List<int>();
        public IList<int> PostorderTraverse(TreeNode root)
        {

            if (root == null) return solution;

            if (root.left != null) PostorderTraverse(root.left);

            if (root.right != null) PostorderTraverse(root.right);
            solution.Add(root.val);

            return solution;

        }
    }
}
