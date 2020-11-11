//TribonacciNumber

import { expect } from "chai";
import { TribonacciNumber } from "../src/TribonacciNumber";

// Fibionachi numbers
describe('Tribonacci Number', () => {
    it("Tribonacci 0", () => {
        let fb: TribonacciNumber = new TribonacciNumber();
        let res: number = fb.tribonacci(0);
        expect(res).to.deep.equal(0);
    });
    it("Tribonacci 1", () => {
        let fb: TribonacciNumber = new TribonacciNumber();
        let res: number = fb.tribonacci(1);
        expect(res).to.deep.equal(1);
    });
    it("Tribonacci 2", () => {
        let fb: TribonacciNumber = new TribonacciNumber();
        let res: number = fb.tribonacci(2);
        expect(res).to.deep.equal(1);
    });
    it("Tribonacci 3", () => {
        let fb: TribonacciNumber = new TribonacciNumber();
        let res: number = fb.tribonacci(3);
        expect(res).to.deep.equal(2);
    });
    
    it("Tribonacci 4", () => {
        let fb: TribonacciNumber = new TribonacciNumber();
        let res: number = fb.tribonacci(4);
        expect(res).to.deep.equal(4);
    });    
    it("Tribonacci 5", () => {
        let fb: TribonacciNumber = new TribonacciNumber();
        let res: number = fb.tribonacci(5);
        expect(res).to.deep.equal(7);
    });
    it("Tribonacci 6", () => {
        let fb: TribonacciNumber = new TribonacciNumber();
        let res: number = fb.tribonacci(8);
        expect(res).to.deep.equal(44);
    });
});