import { expect } from "chai";
import { TwoSumIV } from "../src/BinaryTree/TwoSumIV";
import { TreeNode } from "../src/Classes/TreeNode";

describe('Two Sum IV Tests', () => {
    it("two 1", () => {
        let twoSum: TwoSumIV = new TwoSumIV();
        let t2: TreeNode = new TreeNode({val: 2,left: null, right: null });
        let t4: TreeNode = new TreeNode({val: 4, left: null, right: null});
        let t3: TreeNode = new TreeNode({val: 3, left: t2, right: t4 });
        let t7: TreeNode = new TreeNode({val: 7, left: null, right: null});
        let t6: TreeNode = new TreeNode({val: 6, left: null, right: t7});
        let t5: TreeNode = new TreeNode({val: 5, left: t3, right: t6});
        let res: boolean = twoSum.findTarget(t5, 9);
        expect(res).to.deep.equal(true);        
    });    

    it("two 2", () => {
        let twoSum: TwoSumIV = new TwoSumIV();
        let t2: TreeNode = new TreeNode({val: 2,left: null, right: null });
        let t4: TreeNode = new TreeNode({val: 4, left: null, right: null});
        let t3: TreeNode = new TreeNode({val: 3, left: t2, right: t4 });
        let t7: TreeNode = new TreeNode({val: 7, left: null, right: null});
        let t6: TreeNode = new TreeNode({val: 6, left: null, right: t7});
        let t5: TreeNode = new TreeNode({val: 5, left: t3, right: t6});
        let res: boolean = twoSum.findTarget(t5, 28);
        expect(res).to.deep.equal(false);        
    });

    it("two 3", () => {
        let twoSum: TwoSumIV = new TwoSumIV();
        let t1: TreeNode = new TreeNode({val: 1,left: null, right: null });
        let res: boolean = twoSum.findTarget(t1, 2);
        expect(res).to.deep.equal(false);        
    });
});
//[5,3,6,2,4,null,7]
//9