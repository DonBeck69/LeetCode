import { expect } from "chai";
import { LargestPerimiterTriangle } from "../src/LargestPerimiterTriangle";


describe('Largest Triangle Area', () => {

    it("large p 1", () => {
        let large: LargestPerimiterTriangle = new LargestPerimiterTriangle();
        let res: number = large.LargestPerimeter([2, 1, 2]);     
        expect(res).to.deep.equal(5);        
    }); 
    it("large p 2", () => {
        let large: LargestPerimiterTriangle = new LargestPerimiterTriangle();
        let res: number = large.LargestPerimeter([1, 2, 1]);     
        expect(res).to.deep.equal(0);        
    }); 
    it("large p 3", () => {
        let large: LargestPerimiterTriangle = new LargestPerimiterTriangle();
        let res: number = large.LargestPerimeter([3, 6, 2, 3]);     
        expect(res).to.deep.equal(8);        
    });     
    it("large p 4", () => {
        let large: LargestPerimiterTriangle = new LargestPerimiterTriangle();
        let res: number = large.LargestPerimeter([1,2,2,4,18,8]);     
        expect(res).to.deep.equal(5);        
    }); 
});