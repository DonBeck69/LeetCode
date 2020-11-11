import { TreeNode } from "../Classes/TreeNode";

export class SymetricTree {
    public isSymmetric(root: TreeNode | null): boolean {
        if (root === null) {
            return true;
        }

        let res: boolean = this.testSym(root.left, root.right);
        return res;
    }; 

    public testSym (left: TreeNode | null | undefined, right: TreeNode | null | undefined): boolean {
        let res: boolean = false;
        if (left === null && right === null) {
            return true;
        }
        
        if (left === null || right === null) {
            return false;
        }

        if (left?.val != right?.val) {
            return false;
        }

        let lres: boolean = this.testSym(left?.left, right?.right);
        let rres: boolean = this.testSym(left?.right, right?.left);
        if (lres === true && rres === true) {
            res = true;
        }

        return res;
    }
}