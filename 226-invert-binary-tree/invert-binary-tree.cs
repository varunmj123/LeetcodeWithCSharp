/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

// Recursive DFS
public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if (root == null){
            return null;
        }
        TreeNode temp = root.left;
        root.left = root.right;
        root.right = temp;
        InvertTree(root.left);
        InvertTree(root.right);
        return root;
    }
}


// Iterative DFS apporach
// public class Solution {
//     public TreeNode InvertTree(TreeNode root) {
//         if(root == null){
//             return null;
//         }
//         Stack<TreeNode> stack = new Stack<TreeNode>();
//         stack.Push(root);

//         while(stack.Count > 0){
//             TreeNode node = stack.Pop();
//             TreeNode temp = node.left;
//             node.left = node.right;
//             node.right = temp;

//             if(node.right != null){
//                 stack.Push(node.right);
//             }
//             if(node.left != null){
//                 stack.Push(node.left);
//             }
//         }
//         return root;    
//     }
// }



// BFS Approach
// public class Solution {
//     public TreeNode InvertTree(TreeNode root) {
//         if(root == null){
//             return null;
//         }
//         Queue<TreeNode> queue = new Queue<TreeNode>();
//         queue.Enqueue(root);
//         while(queue.Count > 0){
//             TreeNode node = queue.Dequeue();
//             TreeNode temp = node.left;
//             node.left = node.right;
//             node.right = temp;

//             if(node.left != null){
//                 queue.Enqueue(node.left);
//             }
//             if(node.right != null){
//                 queue.Enqueue(node.right);
//             }

//         }
//         return root;
//     }
// }
