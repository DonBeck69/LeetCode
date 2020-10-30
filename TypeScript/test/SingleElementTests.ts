import { expect } from "chai";
import { SingleEmelent } from "../src/SingleElement";

describe('SingleElement', () => {
    it("2", () => {
        let single: SingleEmelent = new SingleEmelent();
        let nums: Array<number> = [1, 1, 2, 3, 3, 4, 4, 8, 8];
        let res: number = single.findElement(nums);
        expect(res).to.deep.equal(2);
    });    
    it("10", () => {
        let single: SingleEmelent = new SingleEmelent();
        let nums: Array<number> = [3, 3, 7, 7, 10, 11, 11];
        let res: number = single.findElement(nums);
        expect(res).to.deep.equal(10);
    });

});