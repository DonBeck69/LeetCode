import { isUndefined } from "util";
import {TreeNode} from "../Classes/TreeNode";

export class TwoSumIV {

    //public index: Set<number> = new Set<number>();

    public findTarget(root: TreeNode | null, k: number, index?: Set<number>): boolean {
        if (index === undefined) {
            index = new Set<number>();
        }
        let res: boolean = false;
        if (root != null) {
            let diff: number = k - root.val;
            if (index.has(diff)) {
                index.clear();
                res = true;
            } else {
                index.add(root.val);
                res = this.findTarget(root.left, k, index);
                if (res === false) {
                    res = this.findTarget(root.right, k, index);
                }
            }

        }

        return res;
    };
}