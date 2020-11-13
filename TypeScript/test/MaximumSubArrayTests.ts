//Max Sub Array

import { expect } from "chai";
import { MaximumSubArray } from "../src/MaximumSubArray";

// Fibionachi numbers
describe('Maximum Sub Array', () => {
    it("max 0", () => {
        let max: MaximumSubArray = new MaximumSubArray();
        let res: number = max.maxSubArray([-2,1,-3,4,-1,2,1,-5,4]);
        expect(res).to.deep.equal(6);
    });
    it("max 1", () => {
        let max: MaximumSubArray = new MaximumSubArray();
        let res: number = max.maxSubArray([1]);
        expect(res).to.deep.equal(1);
    });

    it("max 2", () => {
        let max: MaximumSubArray = new MaximumSubArray();
        let res: number = max.maxSubArray([0]);
        expect(res).to.deep.equal(0);
    });
    it("max 3", () => {
        let max: MaximumSubArray = new MaximumSubArray();
        let res: number = max.maxSubArray([-1]);
        expect(res).to.deep.equal(-1);
    });
    it("max 4", () => {
        let max: MaximumSubArray = new MaximumSubArray();
        let res: number = max.maxSubArray([-2147483647]);
        expect(res).to.deep.equal(-2147483647);
    });
    it("max 5", () => {
        let max: MaximumSubArray = new MaximumSubArray();
        let res: number = max.maxSubArray([-2, 1]);
        expect(res).to.deep.equal(1);
    });
});