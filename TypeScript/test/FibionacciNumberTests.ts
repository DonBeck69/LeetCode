import { expect } from "chai";
import { FibonacciNumber } from "../src/FibonacciNumber";

// Fibionachi numbers
describe('Fibonacci Numbers', () => {
    it("Fibonacci 0", () => {
        let fb: FibonacciNumber = new FibonacciNumber();
        let res: number = fb.fib(0);
        expect(res).to.deep.equal(0);
    });
    it("Fibonacci 1", () => {
        let fb: FibonacciNumber = new FibonacciNumber();
        let res: number = fb.fib(1);
        expect(res).to.deep.equal(1);
    });
    it("Fibonacci 2", () => {
        let fb: FibonacciNumber = new FibonacciNumber();
        let res: number = fb.fib(2);
        expect(res).to.deep.equal(1);
    });
    it("Fibonacci 3", () => {
        let fb: FibonacciNumber = new FibonacciNumber();
        let res: number = fb.fib(3);
        expect(res).to.deep.equal(2);
    });
    
    it("Fibonacci 4", () => {
        let fb: FibonacciNumber = new FibonacciNumber();
        let res: number = fb.fib(4);
        expect(res).to.deep.equal(3);
    });    
    it("Fibonacci 5", () => {
        let fb: FibonacciNumber = new FibonacciNumber();
        let res: number = fb.fib(5);
        expect(res).to.deep.equal(5);
    });
    it("Fibonacci 6", () => {
        let fb: FibonacciNumber = new FibonacciNumber();
        let res: number = fb.fib(6);
        expect(res).to.deep.equal(8);
    });
});