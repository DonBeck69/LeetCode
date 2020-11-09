import { expect } from "chai";
import { LargestTriangleArea } from "../src/LargestTriangleArea";


describe('Largest Triangle Area', () => {

    it("large 1", () => {
        let large: LargestTriangleArea = new LargestTriangleArea();
        let points: number[][] = [];
        points.push([0,0])
        points.push([0,1]);
        points.push([1,0]);
        points.push([0,2]);
        points.push([2, 0]);

        let res: number = large.LargestArea(points);     
        expect(res).to.deep.equal(1.9999999999999993);        
    }); 

    it("large 2", () => {
        let large: LargestTriangleArea = new LargestTriangleArea();
        let points: number[][] = [];
        points.push([4, 6])
        points.push([6, 5]);
        points.push([3, 1]);

        let res: number = large.LargestArea(points);     
        expect(res).to.deep.equal(5.5);        
    });

    it("large 3", () => {
        let large: LargestTriangleArea = new LargestTriangleArea();
        let points: number[][] = [];
        points.push([0,0])
        points.push([0,1]);
        points.push([1,0]);
        points.push([0,3]);
        points.push([7,0]);

        let res: number = large.LargestArea(points);     
        expect(res).to.deep.equal(10.5);        
    });

    it("large 4", () => {
        let large: LargestTriangleArea = new LargestTriangleArea();
        let points: number[][] = [];
        points.push([-21, 28])
        points.push([-30, -49]);
        points.push([-48, 47]);
        points.push([-22, -20]);
        points.push([19, 3]);
        points.push([5, 48]);
        let res: number = large.LargestArea(points);     
        expect(res).to.deep.equal(2820.00000);        
    });
});