import { expect } from "chai";
import { MergeTwo } from "../src/BinaryTree/MergerTwo";
import { TreeNode } from "../src/Classes/TreeNode";

describe('Merge Two', () => {
    it("merge two 1", () => {
        let mergeTwo: MergeTwo = new MergeTwo();
        let t15: TreeNode = new TreeNode({val: 5,left: null, right: null });
        let t13: TreeNode = new TreeNode({val: 3, left: t15, right: null});
        let t12: TreeNode = new TreeNode({val: 2, left: null, right: null });
        let t1: TreeNode = new TreeNode({val: 1, left: t13, right: t12});

        let t24: TreeNode = new TreeNode({val: 4, left: null, right: null });
        let t27: TreeNode = new TreeNode({val: 7, left: null, right: null });
        let t21: TreeNode = new TreeNode({val: 1, left: null, right: t24});
        let t23: TreeNode = new TreeNode({val: 3, left: null, right: t27});
        let t2: TreeNode = new TreeNode({val: 2, left: t21, right: t23});

        let treeNode: TreeNode = mergeTwo.mergeTrees(t1, t2)!;
       
        expect(treeNode.val).to.deep.equal(3);        
        expect(treeNode?.left?.val).to.deep.equal(4);
        expect(treeNode?.right?.val).to.deep.equal(5);
        expect(treeNode?.left?.left?.val).to.deep.equal(5);
        expect(treeNode?.right?.right?.val).to.deep.equal(7);

    });
});
