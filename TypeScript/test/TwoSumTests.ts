import { expect } from "chai";
import { TwoSum } from "../src/TwoSum";


describe('Two Sums', () => {

    it("two sum 1", () => {
        let twoSum: TwoSum = new TwoSum();
        let nums: Array<number> = [2, 7, 11, 15];
        let target: number = 9
        let res: Array<number> = twoSum.twoSums(nums, target);     
        expect(res[0]).to.deep.equal(0);        
        expect(res[1]).to.deep.equal(1);        
    }); 
    it("two sum 2", () => {
        let twoSum: TwoSum = new TwoSum();
        let nums: Array<number> = [2, 3, 4];
        let target: number = 6
        let res: Array<number> = twoSum.twoSums(nums, target);     
        expect(res[0]).to.deep.equal(0);        
        expect(res[1]).to.deep.equal(2);        
    }); 
    it("two sum 3", () => {
        let twoSum: TwoSum = new TwoSum();
        let nums: Array<number> = [-1, 0];
        let target: number = -1
        let res: Array<number> = twoSum.twoSums(nums, target);     
        expect(res[0]).to.deep.equal(0);        
        expect(res[1]).to.deep.equal(1);        
    }); 
    it("two sum 4", () => {
        let twoSum: TwoSum = new TwoSum();
        let nums: Array<number> = [5, 25, 75];
        let target: number = 100
        let res: Array<number> = twoSum.twoSums(nums, target);     
        expect(res[0]).to.deep.equal(1);        
        expect(res[1]).to.deep.equal(2);        
    }); 

    it("two sum 5", () => {
        let twoSum: TwoSum = new TwoSum();
        let nums: Array<number> = [3, 2, 4];
        let target: number = 6
        let res: Array<number> = twoSum.twoSums(nums, target);     
        expect(res[0]).to.deep.equal(1);        
        expect(res[1]).to.deep.equal(2);        
    }); 
 
});