import { expect } from "chai";
import { FindDisappeared } from "../src/FindDisappeared/FindDisappeared";

describe('FindDisapeared', () => {


    it("find number 1", () => {
        let find: FindDisappeared = new FindDisappeared();
        let nums:Array<number> = [1, 1];
        let res: Array<number> = find.findDisappearedNumbers(nums);
        expect(res[0]).to.deep.equal(2);
    });
    it("find number 2", () => {
        let find: FindDisappeared = new FindDisappeared();
        let nums:Array<number> = [2, 2];
        let res: Array<number> = find.findDisappearedNumbers(nums);
        expect(res[0]).to.deep.equal(1);
    });    
    it("find number 3", () => {
        let find: FindDisappeared = new FindDisappeared();
        let nums:Array<number> = [1, 2, 2, 4, 5, 5 ];
        let res: Array<number> = find.findDisappearedNumbers(nums);
        expect(res[0]).to.deep.equal(3);
        expect(res[1]).to.deep.equal(6);
    });    
    it("find number 4", () => {
        let find: FindDisappeared = new FindDisappeared();
        let nums:Array<number> = [1, 2, 2, 3, 3, 6 ];
        let res: Array<number> = find.findDisappearedNumbers(nums);
        expect(res[0]).to.deep.equal(4);
        expect(res[1]).to.deep.equal(5);
    });

    it("find number 5", () => {
        let find: FindDisappeared = new FindDisappeared();
        let nums:Array<number> = [4, 3, 2, 7, 8, 2, 3, 1];
        let res: Array<number> = find.findDisappearedNumbers(nums);
        expect(res[0]).to.deep.equal(5);
        expect(res[1]).to.deep.equal(6);
    });

    it("find number 6", () => {
        let find: FindDisappeared = new FindDisappeared();
        let nums:Array<number> = [10,2,5,10,9,1,1,4,3,7];
        let res: Array<number> = find.findDisappearedNumbers(nums);
        expect(res[0]).to.deep.equal(6);
        expect(res[1]).to.deep.equal(8);
    });
});