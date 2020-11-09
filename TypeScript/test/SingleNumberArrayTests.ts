import { expect } from "chai";
import { SingleNumberArray } from "../src/SingleNumberArray";


describe('Single Number', () => {

    it("number 1", () => {
        let single: SingleNumberArray = new SingleNumberArray();
        let nums: Array<number> = [2, 2, 1];
        let res: number = single.singleNumber(nums);     
        expect(res).to.deep.equal(1);        
    }); 
    
    it("number 2", () => {
        let single: SingleNumberArray = new SingleNumberArray();
        let nums: Array<number> = [4, 1, 2, 1, 2];
        let res: number = single.singleNumber(nums);     
        expect(res).to.deep.equal(4);        
    });    
    it("number 3", () => {
        let single: SingleNumberArray = new SingleNumberArray();
        let nums: Array<number> = [1];
        let res: number = single.singleNumber(nums);     
        expect(res).to.deep.equal(1);        
    }); 

    it("number X 1", () => {
        let single: SingleNumberArray = new SingleNumberArray();
        let nums: Array<number> = [2, 2, 1];
        let res: number = single.singleNumberX(nums);     
        expect(res).to.deep.equal(1);        
    }); 
    
    it("number X 2", () => {
        let single: SingleNumberArray = new SingleNumberArray();
        let nums: Array<number> = [4, 1, 2, 1, 2];
        let res: number = single.singleNumberX(nums);     
        expect(res).to.deep.equal(4);        
    });    
    it("number X 3", () => {
        let single: SingleNumberArray = new SingleNumberArray();
        let nums: Array<number> = [1];
        let res: number = single.singleNumberX(nums);     
        expect(res).to.deep.equal(1);        
    }); 
});