import { expect } from "chai";
import { ViralAdvertising } from "../src/ViralAdvertising";


describe('Course schedue tests', () => {
    it("viral 5", () => {
        let helper: ViralAdvertising = new ViralAdvertising();
        let res: number = helper.ViralAdvertising(5);
        expect(res).to.deep.equal(24);
    });


});