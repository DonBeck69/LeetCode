import { expect } from "chai";
import { MinStack } from "../src/MinStack";

// Fibionachi numbers
describe('Maximum Sub Array', () => {
    it("max 0", () => {
        let mis: MinStack = new MinStack();
        mis.push(-2);
        mis.push(0);
        mis.push(-3);
        let min1: number = mis.getMin();
        mis.pop();
        let top: number = mis.top();
        let min2: number = mis.getMin();
        expect(min1).to.deep.equal(-3);
        expect(min2).to.deep.equal(-2);
        expect(top).to.deep.equal(0);
    });
});