import { expect } from "chai";
import { BestTimeToBuy } from "../src/BestTimeToBuy";


describe('Best Time to Buy', () => {
    it("bttb 1", () => {
        let buy: BestTimeToBuy = new BestTimeToBuy();
        let nums:Array<number> = [7,1,5,3,6,4];
        let res: number = buy.maxProfit(nums);
        expect(res).to.deep.equal(5);
    });
    it("bttb 2", () => {
        let buy: BestTimeToBuy = new BestTimeToBuy();
        let nums:Array<number> = [];
        let res: number = buy.maxProfit(nums);
        expect(res).to.deep.equal(0);
    });    
    it("bttb 3", () => {
        let buy: BestTimeToBuy = new BestTimeToBuy();
        let nums:Array<number> = [2,4,1];
        let res: number = buy.maxProfit(nums);
        expect(res).to.deep.equal(2);
    });   
});