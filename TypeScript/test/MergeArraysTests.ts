import { expect } from "chai";
import { MergeArrays } from "../src/MergeArrays";

describe('MergeArrays', () => {
    it("l1=[1,2,3,0,0,0] l2=[2,5,6]", () => {
        let merge: MergeArrays = new MergeArrays();
        let nums1: Array<number> = [1,2,3,0,0,0];
        let nums2: Array<number> = [2,5,6];
        let res: Array<number> = merge.merge(nums1, 3, nums2, 3);
        expect(res[5]).to.deep.equal(6);
    });
    it("l1=[2,5,6,0,0,0] l2=[1,2,3]", () => {
        let merge: MergeArrays = new MergeArrays();
        let nums1: Array<number> = [2,5,6,0,0,0];
        let nums2: Array<number> = [1,2,3];
        let res: Array<number> = merge.merge(nums1, 3, nums2, 3);
        expect(res[5]).to.deep.equal(6);
    });
    it("l1=[-1,0,0,3,3,3,0,0,0] l2=[1,2,2]", () => {
        let merge: MergeArrays = new MergeArrays();
        let nums1: Array<number> = [-1,0,0,3,3,3,0,0,0];
        let nums2: Array<number> = [1,2,2];
        let res: Array<number> = merge.merge(nums1, 6, nums2, 3);
        expect(res[5]).to.deep.equal(2);
    });
    it("l1=[0] l2=[1]", () => {
        let merge: MergeArrays = new MergeArrays();
        let nums1: Array<number> = [0];
        let nums2: Array<number> = [1];
        let res: Array<number> = merge.merge(nums1, 0, nums2, 1);
        expect(res[0]).to.deep.equal(1);
    });
    it("l1=[] l2=[]", () => {
        let merge: MergeArrays = new MergeArrays();
        let nums1: Array<number> = [];
        let nums2: Array<number> = [];
        let res: Array<number> = merge.merge(nums1, 1, nums2, 1);
        expect(res).to.deep.equal([]);
    });
    it("l1=[] l2=[1,2]", () => {
        let merge: MergeArrays = new MergeArrays();
        let nums1: Array<number> = [];
        let nums2: Array<number> = [1,2];
        let res: Array<number> = merge.merge(nums1, 0, nums2, 2);
        expect(res[1]).to.deep.equal(2);
    });
    it("l1=[1,2] l2=[0]", () => {
        let merge: MergeArrays = new MergeArrays();
        let nums1: Array<number> = [1, 2];
        let nums2: Array<number> = [];
        let res: Array<number> = merge.merge(nums1, 2, nums2, 0);
        expect(res[1]).to.deep.equal(2);
    });
    it("l1=[1,0] l2=[2]", () => {
        let merge: MergeArrays = new MergeArrays();
        let nums1: Array<number> = [1, 0];
        let nums2: Array<number> = [2];
        let res: Array<number> = merge.merge(nums1, 1, nums2, 1);
        expect(res[1]).to.deep.equal(2);
    });
    it("l1=[4,0,0,0,0,0] l2=[1,2,3,5,6]", () => {
        let merge: MergeArrays = new MergeArrays();
        let nums1: Array<number> = [4,0,0,0,0,0];
        let nums2: Array<number> = [1,2,3,5,6];
        let res: Array<number> = merge.merge(nums1, 1, nums2, 5);
        expect(res[5]).to.deep.equal(6);//[1,2,3,4,5,6]
    });
    it("l1=[1,0,0,0,0,0] l2=[2,3,4,5,6]", () => {
        let merge: MergeArrays = new MergeArrays();
        let nums1: Array<number> = [1,0,0,0,0,0];
        let nums2: Array<number> = [2,3,4,5,6];
        let res: Array<number> = merge.merge(nums1, 1, nums2, 5);
        expect(res[5]).to.deep.equal(6);//[1,2,3,4,5,6]
    });
});

/*
[1,0,0,0,0,0]
1
[2,3,4,5,6]
5
*/
