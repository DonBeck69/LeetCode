import { expect } from "chai";
import { SymetricTree } from "../src/BinaryTree/SymetricTree";
import { TreeNode } from "../src/Classes/TreeNode";

describe('Symmetric binary tree', () => {

    it("Symmetric 0", () => {
        let tree: SymetricTree = new SymetricTree();
        let res: boolean = tree.isSymmetric(null);     
        expect(res).to.deep.equal(true);        
    });    
    it("Symmetric 1", () => {
        let tree: SymetricTree = new SymetricTree();
        let t1: TreeNode = new TreeNode({val: 1, left: null, right: null});
        let res: boolean = tree.isSymmetric(t1);     
        expect(res).to.deep.equal(true);        
    });

    it("Symmetric 2", () => {
        let tree: SymetricTree = new SymetricTree();
        let t2: TreeNode = new TreeNode({val: 2, left: null, right: null});
        let t1: TreeNode = new TreeNode({val: 1, left: t2, right: null});
        let res: boolean = tree.isSymmetric(t1);     
        expect(res).to.deep.equal(false);        
    });    
    
    it("Symmetric 3", () => {
        let tree: SymetricTree = new SymetricTree();
        let t3: TreeNode = new TreeNode({val: 3,left: null, right: null });
        let t4: TreeNode = new TreeNode({val: 4, left: null, right: null});
        let tl2: TreeNode = new TreeNode({val: 2, left: t3, right: t4 });
        let tr2: TreeNode = new TreeNode({val: 2, left: t4, right: t3 });
        let t1: TreeNode = new TreeNode({val: 1, left: tl2, right: tr2});
        let res: boolean = tree.isSymmetric(t1);
        expect(res).to.deep.equal(true);        
    });

    it("Symmetric 4", () => {
        let tree: SymetricTree = new SymetricTree();
        let t3: TreeNode = new TreeNode({val: 3,left: null, right: null });
        let t4: TreeNode = new TreeNode({val: 4, left: null, right: null});
        let t2: TreeNode = new TreeNode({val: 2, left: t3, right: null });
        let t1: TreeNode = new TreeNode({val: 1, left: t2, right: t2});
        let res: boolean = tree.isSymmetric(t1);
        expect(res).to.deep.equal(false);        
    });


});