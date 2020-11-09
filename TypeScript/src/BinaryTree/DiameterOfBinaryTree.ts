import {TreeNode} from "../Classes/TreeNode";

export class DiamiterOfBinaryTree{

    public diameter = 0;

    public diameterOfBinaryTree(root: TreeNode | null): number {
        let res: number = 0;
        res = this.deepDive(root);

        return this.diameter;
    };

    public deepDive(root: TreeNode | null): number {
        let ldep: number = 0;
        let rdep: number = 0;
        if (root == null) {
            return 0;
        } else {
            ldep = this.deepDive(root.left);
            rdep = this.deepDive(root.right);
        } 

        this.diameter = Math.max(this.diameter, ldep + rdep);

        return Math.max(ldep, rdep) + 1;
    }
}