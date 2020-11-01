import {TreeNode} from "../Classes/TreeNode";
export class MergeTwo{

    public  mergeTrees(t1: TreeNode | null, t2: TreeNode | null): TreeNode | null {
        let treeNode: TreeNode | null = null;
        if (t1 != null && t2 != null){
            //treeNode = new TreeNode({val: t1.val+t2.val});
            treeNode = new TreeNode();
            treeNode.val = t1.val+t2.val;
            treeNode.left = this.mergeTrees(t1.left, t2.left);
            treeNode.right = this.mergeTrees(t1.right, t2.right);
        } else if (t1 != null && t2 == null){
            //treeNode = new TreeNode({val: t1.val});
            treeNode = new TreeNode();
            treeNode.val = t1.val;
            treeNode.val = t1.val;
            treeNode.left = this.mergeTrees(t1.left, null);
            treeNode.right = this.mergeTrees(t1.right, null);
        } else if (t1 == null && t2 != null) {
            //treeNode = new TreeNode({val: t2.val});
            treeNode = new TreeNode();
            treeNode.val = t2.val;
            treeNode.left = this.mergeTrees(null, t2.left);
            treeNode.right = this.mergeTrees(null, t2.right);
        }

        return treeNode;
    };
}