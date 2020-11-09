import { expect } from "chai";
import { LongestSubstring } from "../src/LongestSubstring";


describe('Longest Substring', () => {

    it("substring 1", () => {
        let large: LongestSubstring = new LongestSubstring();
        let res: number = large.LengthOfLongestSubstring("abcabcbb");     
        expect(res).to.deep.equal(3);        
    }); 
    it("substring 2", () => {
        let large: LongestSubstring = new LongestSubstring();
        let res: number = large.LengthOfLongestSubstring("pppppp");     
        expect(res).to.deep.equal(1);        
    }); 
    it("substring 3", () => {
        let large: LongestSubstring = new LongestSubstring();
        let res: number = large.LengthOfLongestSubstring("pwwkew");     
        expect(res).to.deep.equal(3);        
    }); 

    it("substring 4", () => {
        let large: LongestSubstring = new LongestSubstring();
        let res: number = large.LengthOfLongestSubstring("");     
        expect(res).to.deep.equal(0);        
    }); 
});