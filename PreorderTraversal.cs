using System;
using System.Collections.Generic;
using System.Text;

namespace Tree_Traversal
{    
    public class PreorderTraversal
    { 
         IList<int> solution = new List<int>();

         public IList<int> PreorderTraverse(TreeNode root)
         {
             if (root == null) return solution;

             solution.Add(root.val);

             if (root.left != null) PreorderTraverse(root.left);
             if (root.right != null) PreorderTraverse(root.right);

             return solution;
         } 
    }
}
