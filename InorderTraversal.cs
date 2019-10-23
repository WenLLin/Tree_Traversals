using System;
using System.Collections.Generic;
using System.Text;

namespace Tree_Traversal
{
    public class InorderTraversal
    {
        IList<int> solution = new List<int>();

        public IList<int> InorderTraverse(TreeNode root)
        {
            if (root == null) return solution;

            if (root.left != null) InorderTraverse(root.left);
            solution.Add(root.val);
            if (root.right != null) InorderTraverse(root.right);

            return solution;
        }
    }
}
