using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy110
{
    class Solution
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;
            int hl = root.left != null ? 1 : 0;
            int hr = root.right != null ? 1 : 0;
            var l = GetChildren(root.left);
            var r = GetChildren(root.right);
            while (l != null || r != null)
            {
                if (l != null)
                {
                    hl++;
                    l = GetChildren(l);
                }
                if (r != null)
                {
                    hr++;
                    r = GetChildren(r);
                }
                if (Math.Abs(hr - hl) > 1) return false;
            }
            return true;
        }

        List<TreeNode> GetChildren(List<TreeNode> lst)
        {
            var children = new List<TreeNode>();
            if (lst == null) return null;
            foreach (var item in lst)
            {
                if (item.left != null) children.Add(item.left);
                if (item.right != null) children.Add(item.right);
            }
            return children.Count() > 0 ? children : null;
        }

        List<TreeNode> GetChildren(TreeNode node)
        {
            if (node == null) return null;
            var children = new List<TreeNode>();
            if (node.left != null) children.Add(node.left);
            if (node.right != null) children.Add(node.right);
            return children.Count() > 0 ? children : null;
        }

        public TreeNode GetInitialData()
        {
            //return new TreeNode(1, null, new TreeNode(2, null, new TreeNode(3)));
            //[1,2,2,3,null,null,3,4,null,null,4]
            //return new TreeNode(1,new ) 
            return null;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
