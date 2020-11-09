import { expect } from "chai";
import { DiamiterOfBinaryTree } from "../src/BinaryTree/DiameterOfBinaryTree";
import { TreeNode } from "../src/Classes/TreeNode";

describe('Diameter of binary tree', () => {

    it("diameter 0", () => {
        let diameter: DiamiterOfBinaryTree = new DiamiterOfBinaryTree();
        let res: number = diameter.diameterOfBinaryTree(null);     
        expect(res).to.deep.equal(0);        
    });    
    it("diameter 1", () => {
        let diameter: DiamiterOfBinaryTree = new DiamiterOfBinaryTree();
        let t1: TreeNode = new TreeNode({val: 1, left: null, right: null});
        let res: number = diameter.diameterOfBinaryTree(t1);     
        expect(res).to.deep.equal(0);        
    });
    it("diameter 2", () => {
        let diameter: DiamiterOfBinaryTree = new DiamiterOfBinaryTree();
        let t2: TreeNode = new TreeNode({val: 2, left: null, right: null});
        let t1: TreeNode = new TreeNode({val: 1, left: t2, right: null});
        let res: number = diameter.diameterOfBinaryTree(t1);     
        expect(res).to.deep.equal(1);        
    });    
    
    it("diameter 3", () => {
        let diameter: DiamiterOfBinaryTree = new DiamiterOfBinaryTree();
        let t3: TreeNode = new TreeNode({val: 3, left: null, right: null});
        let t2: TreeNode = new TreeNode({val: 2, left: t3, right: null});
        let t1: TreeNode = new TreeNode({val: 1, left: t2, right: null});
        let res: number = diameter.diameterOfBinaryTree(t1);     
        expect(res).to.deep.equal(2);        
    });

    it("diameter 4", () => {
        let diameter: DiamiterOfBinaryTree = new DiamiterOfBinaryTree();
        let tl4: TreeNode = new TreeNode({val: 4,left: null, right: null });
        let tr5: TreeNode = new TreeNode({val: 5, left: null, right: null});
        let tl2: TreeNode = new TreeNode({val: 2, left: tl4, right: tr5 });
        let t3: TreeNode = new TreeNode({val: 3, left: null, right: null});
        let t1: TreeNode = new TreeNode({val: 1, left: tl2, right: t3});

        let res: number = diameter.diameterOfBinaryTree(t1);
       
        expect(res).to.deep.equal(3);        
    });
});