// See https://aka.ms/new-console-template for more information
using DFS;

public class Solution
{
    public void Dfs(TreeNode root, int targetSum, int currentSum, ref bool ans)
    {
        if(root == null)
        {
            ans = false;
            return;
        }
        if(ans == true)
        {
            return;
        }
        currentSum += root.val;
        if (root.left == null && root.right == null && currentSum == targetSum)
        {
            ans = true;
            return;
        }
        if(root.left != null)
        {
            Dfs(root.left, targetSum, currentSum, ref ans);
        }
        if(root.right != null)
        {
            Dfs(root.right, targetSum, currentSum, ref ans);
        }
    }
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        var ans = false;
        Dfs(root, targetSum, 0, ref ans);
        return ans;
    }
}
